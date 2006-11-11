using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;
using au.id.micolous.libs.igacommon;

namespace au.id.micolous.apps.igaeditor
{
    /// <summary>
    /// This class defines a complete adpack object.  It can be serialised or
    /// deserialised directly to the native format, and has handlers for easily
    /// adding new objects to the package.
    /// </summary>
    public class AdPack
    {
        /// <summary>
        /// This defines the metadata of the package, stored in metainfo.dat.
        /// </summary>
        public SortedList<String, String> Metadata;

        /// <summary>
        /// This defines the files to be stored in the package, as well as
        /// fileinfo.dat.
        /// </summary>
        public SortedList<String, AdPackEntry> Files;

        private int AppID;


        /// <summary>
        /// Creates a new, empty adpack file.
        /// <param name="AppID">The appid for the cache file to be minipulated.</param>
        /// </summary>
        public AdPack(int AppID)
        {
            // create a new empty adpack
            Metadata = new SortedList<string, string>();
            Metadata["version"] = "1";
            Metadata["product"] = Common.AppInfos[AppID].AppNameShort;
            Files = new SortedList<string, AdPackEntry>();
            this.AppID = AppID;
        }

        /// <summary>
        /// Serialises the adpack to a file (ZIP).
        /// </summary>
        /// <param name="s">A stream pointing to the file to write to.</param>
        public void Serialize(Stream s)
        {
            ZipOutputStream zos = new ZipOutputStream(s);
            zos.SetLevel(9);
            ZipEntry metadata = new ZipEntry("metadata.dat");
            byte[] metadataB = OutputMetadata();
            ZipEntry filelist = new ZipEntry("filelist.dat");
            byte[] filelistB = OutputFileList();
            zos.PutNextEntry(metadata);
            zos.Write(metadataB, 0, metadataB.Length);
            zos.PutNextEntry(filelist);
            zos.Write(filelistB, 0, filelistB.Length);

            // iterate through files
            foreach (KeyValuePair<String, AdPackEntry> file in Files)
            {
                ZipEntry zef = new ZipEntry(file.Value.FileName);
                zos.PutNextEntry(zef);
                zos.Write(file.Value.DDSData, 0, file.Value.DDSData.Length);
            }

            zos.Finish();
            zos.Close(); 
        }


        /// <summary>
        /// This deserializes an adpack from a file.
        /// </summary>
        /// <param name="s">The stream to read from.</param>
        public void Deserialize(Stream s)
        {
            ZipInputStream zis = new ZipInputStream(s);
            ZipEntry entry;
            Metadata = new SortedList<string, string>();
            Files = new SortedList<string, AdPackEntry>();

            SortedList<String, byte[]> otherFiles = new SortedList<string, byte[]>();

            while ((entry = zis.GetNextEntry()) != null)
            {
                if (entry.IsCrypted)
                {
                    MessageBox.Show("This adpack is encrypted, so it cannot be displayed.  Please do not encrypt adpack files.");
                    throw new Exception("Adpack is encrypted!");
                }
                switch (entry.Name.ToLowerInvariant())
                {
                    case "metadata.dat":
                        byte[] meta = new byte[entry.Size];
                        zis.Read(meta, 0, (int)entry.Size);
                        HandleMetadata(meta);
                        break;
                    case "filelist.dat":
                        byte[] fl = new byte[entry.Size];
                        zis.Read(fl, 0, (int)entry.Size);
                        HandleFileList(fl);
                        break;
                    default:
                        byte[] d = new byte[entry.Size];
                        zis.Read(d, 0, (int)entry.Size);
                        otherFiles[entry.Name] = d;
                        break;
                }

                zis.CloseEntry();
            }

            // check product id, because it's not just for bf2142
            if (Metadata["product"].ToLowerInvariant() != Common.AppInfos[AppID].AppNameShort)
            {
                String correctApp = "";
                if (Common.AppShortNames.ContainsKey(Metadata["product"].ToLowerInvariant())) {
                    correctApp = Common.AppInfos[Common.AppShortNames[Metadata["product"].ToLowerInvariant()]].AppName;
                } else {
                    correctApp = "Unsupported (" + Metadata["product"].ToLowerInvariant() + ")";
                }
                throw new Exception("Adpack is not for " + Common.AppInfos[AppID].AppName + ", it is for " + correctApp + ".");
            }

            // iterate through the other files
            foreach (KeyValuePair<String, byte[]> file in otherFiles)
            {
                if (Files.ContainsKey(file.Key))
                {
                    // referenced data.
                    Files[file.Key].SetDDSData(file.Value);
                }
            }

            List<String> RemovalList = new List<string>();
            foreach (KeyValuePair<String, AdPackEntry> file in Files)
            {
                // check each has data attached.
                if (file.Value.DDSData == null)
                {
                    MessageBox.Show("Warning: Missing DDS image file '" + file.Key + "'.  The adpack file may be corrupt or encrypted.");
                    RemovalList.Add(file.Key);
                }
            }
            foreach (String item in RemovalList)
            {
                Files.Remove(item);
            }


            

        }

        private void HandleMetadata(byte[] metafile)
        {
            String meta = ASCIIEncoding.ASCII.GetString(metafile);
            foreach (String pair in meta.Split(';'))
            {
                if (pair.Trim().Length > 1)
                {
                    String[] kv = pair.Trim().Split('=');
                    Metadata[kv[0].Trim()] = kv[1].Trim();
                }
            }
        }

        private byte[] OutputMetadata()
        {
            String outstring = "";
            foreach (KeyValuePair<String, String> kvp in Metadata)
            {
                outstring = outstring + kvp.Key.Replace("=", "").Replace(";", "") + "=" + kvp.Value.Replace("=", "").Replace(";", "") + ";";
            }
            byte[] output = ASCIIEncoding.ASCII.GetBytes(outstring);
            return output;
        }

        private void HandleFileList(byte[] filelist)
        {
            String fl = ASCIIEncoding.ASCII.GetString(filelist);
            foreach (String entry in fl.Split('\n'))
            {
                String centry = entry.Trim();
                if (centry.Length > 1)
                {
                    SortedList<String, String> entryitems = new SortedList<string, string>();
                    foreach (String pair in centry.Split(';'))
                    {
                        if (pair.Trim().Length > 1)
                        {
                            String[] kv = pair.Trim().Split('=');
                            entryitems[kv[0].Trim()] = kv[1].Trim();
                        }
                    }

                    // handle the entry
                    Files[entryitems["filename"]] = new AdPackEntry(entryitems["filename"], entryitems["title"], new ContentType(UInt32.Parse(entryitems["contentType"])));
                }
            }
        }

        private byte[] OutputFileList()
        {
            String outstring = "";
            foreach (KeyValuePair<String, AdPackEntry> kvp in Files)
            {
                outstring = outstring + "title=" + kvp.Value.Description.Replace("=", "").Replace(";", "").Replace("\n", "").Replace("\r", "") + ";";
                outstring = outstring + "filename=" + kvp.Value.FileName.Replace("=", "").Replace(";", "").Replace("\n", "").Replace("\r", "") + ";";
                outstring = outstring + "contentType=" + kvp.Value.ContentType.ToString() + ";";
                outstring = outstring + "\n";
            }
            byte[] output = ASCIIEncoding.ASCII.GetBytes(outstring);
            return output;
        }
    }
}
