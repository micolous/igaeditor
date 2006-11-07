using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Net;
using au.id.micolous.libs.DDSReader;


namespace au.id.micolous.apps.igaeditor
{
    partial class MainForm : Form
    {
        private static SQLiteConnection sqlite;

        private String[] args;
        private static SortedList<int, int> contentTypes;
        public static SortedList<int, int> ContentTypes { get { return contentTypes; } }
        private static int appID;
        public static int AppID { get { return appID; } }

        public MainForm(String[] args)
        {
            this.args = args;
            InitializeComponent();
        }

        private bool OpenDatabaseConnection()
        {

            DialogResult res = DialogResult.Cancel;
            bool cont = true;
            
            do
            {
                res = OpenDatabaseDialogue.ShowDialog();
                if (res == DialogResult.Cancel)
                {
                    res = MessageBox.Show("You canceled opening the icontent.cache file.  You need to locate it to use this program.\r\n\r\nWould you like to try again?", "Battlefield 2142 Ad Cache Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.No)
                    {
                        cont = false;
                    }
                }
                else
                {
                    // try opening file.
                    try
                    {
                        sqlite = new SQLiteConnection("Data Source=\"" + OpenDatabaseDialogue.FileName + "\"");
                        sqlite.Open();
                        SQLiteCommand query = new SQLiteCommand("SELECT [appId] FROM [contentlist] LIMIT 1", sqlite);
                        Object result = query.ExecuteScalar();
                        sqlite.Close();
                        if (result == null)
                        {
                            // offer to add one.
                            if (MessageBox.Show("There was no appid found in the cache.  Most likely the 'contentlist' table is corrupt.\r\n\r\nYou must specify an appid to be able to open the file.  Would you like to specify one now?", "Ad Cache Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                // yes
                                OverrideAppidForm oaf = new OverrideAppidForm();
                                oaf.ShowDialog();

                                if (oaf.Success)
                                {
                                    appID = oaf.AppID;
                                    if (oaf.SaveToDatabase)
                                    {
                                        // try to write back
                                        query = new SQLiteCommand(@"UPDATE [contentlist] SET [appid]=@appid", sqlite);
                                        query.Parameters.Add(new SQLiteParameter("appid", appID));
                                        sqlite.Open();
                                        if (query.ExecuteNonQuery() == 0)
                                        {
                                            // no data in contentlist... add new.
                                            sqlite.Close();
                                            query = new SQLiteCommand(@"INSERT INTO [contentlist] ([appid]) VALUES (@appid)", sqlite);
                                            query.Parameters.Add(new SQLiteParameter("appid", appID));
                                            sqlite.Open();
                                            query.ExecuteNonQuery();
                                        }

                                        sqlite.Close();
                                    }

                                }
                                else
                                {
                                    throw new Exception("The operation to select an appid was cancelled.");
                                }

                            }
                            else
                            {
                                // no
                                throw new Exception("No appid was found in the cache and you didn't want to specify one manually.");
                            }
                        }
                        else
                        {
                            appID = (int)(long)result;
                        }
                        
                        if (!Common.AppInfos.ContainsKey(appID))
                        {
                            UnsupportedApplicationForm upf = new UnsupportedApplicationForm(appID);
                            upf.ShowDialog();
                        }
                    }
                    catch (/*SQLite*/Exception ex)
                    {
                        res = MessageBox.Show("There was a problem loading the cache file.  " + ex.Message + "\r\n\r\nWould you like to try again?", "Battlefield 2142 Ad Cache Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                        if (res == DialogResult.No)
                        {
                            cont = false;
                        }
                        else
                        {
                            res = DialogResult.Cancel;
                        }
                    }
                }
            } while (res == DialogResult.Cancel && cont);

            if (cont)
            {
                WelcomeGroup.Hide();
                EditingGroup.Show();
                refreshToolStripMenuItem.Enabled = true;
                exportAdpackFilebfadsToolStripMenuItem.Enabled = true;
                closeDatabaseToolStripMenuItem.Enabled = true;
                debugToolStripMenuItem.Enabled = true;
                SetReadonlyRestrictions(appID);
                RefreshList();
            }

            return cont;
        }

        private void SetReadonlyRestrictions(int AppID)
        {
            this.SetReadonlyRestrictions(Common.AppInfos.ContainsKey(appID));
        }

        private void SetReadonlyRestrictions(bool ReadOnly)
        {
            if (ReadOnly)
            {
                EditingGroup.Text = "Ad Cache Entries for " + Common.AppInfos[appID].AppName + ":";
                AddRecordButton.Enabled = true;
                EditRecordButton.Enabled = true;
                DeleteRecordButton.Enabled = true;
                editItemContext.Enabled = true;
                deleteItemContext.Enabled = true;
                importImageContext.Enabled = true;
                ImportImageButton.Enabled = true;
                importAdpackFilebfadsToolStripMenuItem.Enabled = true;
                exportAdpackFilebfadsToolStripMenuItem.Enabled = true;
                vacuumDatabaseToolStripMenuItem.Enabled = true;
            }
            else
            {
                EditingGroup.Text = "Ad Cache Entries for Unknown Application (#" + appID.ToString() + "):";
                // prevent write actions
                AddRecordButton.Enabled = false;
                EditRecordButton.Enabled = false;
                DeleteRecordButton.Enabled = false;
                editItemContext.Enabled = false;
                deleteItemContext.Enabled = false;
                importImageContext.Enabled = false;
                ImportImageButton.Enabled = false;
                importAdpackFilebfadsToolStripMenuItem.Enabled = false;
                exportAdpackFilebfadsToolStripMenuItem.Enabled = false;
                vacuumDatabaseToolStripMenuItem.Enabled = false;
            }

        }

        private void BigOpenButton_Click(object sender, EventArgs e)
        {
            OpenDatabaseConnection();
        }

        private void RefreshList()
        {
            CacheEntryList.Items.Clear();
            Common.ads = new List<byte[]>(100);
            Common.cids = new List<int>(100);
            contentTypes = new SortedList<int, int>(100);
            SQLiteCommand cmd = sqlite.CreateCommand();
            cmd.CommandText = @"SELECT * FROM [content] ORDER BY [contentId]";
            sqlite.Open();
            SQLiteDataReader reader =  cmd.ExecuteReader();

            while (reader.Read())
            {
                // read in rows
                int contentId = reader.GetInt32(0);
                Common.cids.Add(contentId);
                DateTime activate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                activate = activate.AddSeconds(reader.GetInt32(2));
                //activate = activate.ToLocalTime();
                String activateS = activate.ToString(Common.DateTimeFormat);
                String activeS = "No";
                if (reader.GetInt32(1) >= 1)
                {
                    activeS = "Yes";
                }
                String Expires = "Never";
                if (reader.GetInt32(3) > 0)
                {
                    DateTime expires = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                    expires = expires.AddSeconds(reader.GetInt32(3));
                    //-expires = expires.ToLocalTime();
                    Expires = expires.ToString(Common.DateTimeFormat);
                }
                int DayParts = reader.GetInt32(4);
                String DayPartsS = "Never";
                if (DayParts == 16777215)
                {
                    // always
                    DayPartsS = "Always";
                }
                else if (DayParts > 0 && DayParts < 16777215)
                {
                    DayPartsS = "Sometimes";
                }
                else if (DayParts > 16777215)
                {
                    DayPartsS = "Invalid";
                }
                int ContentType = reader.GetInt32(5);
                contentTypes[contentId] = ContentType;
                Size s = Common.ContentTypeToSize(ContentType);

                bool isVideo = false;
                if (ContentType % 10000 == 1000)
                {
                    isVideo = true;
                }

                String dataType = "DDS Image";
                if (isVideo)
                {
                    dataType = "BIK Video";
                }
                String dimensions = String.Format("{0}x{1}", s.Width, s.Height);
                int ImageSizeBytes = reader.GetInt32(7);
                int ViewCount = reader.GetInt32(8);
                int ViewLimit = reader.GetInt32(9);
                String ViewsString = ViewCount.ToString();
                if (ViewLimit > 0)
                {
                    ViewsString = ViewsString + " of " + ViewLimit.ToString();
                }

                long fileLength;
                try
                {
                    fileLength = reader.GetBytes(12, 0, null, 0, 0);
                }
                catch (Exception ex)
                {
                    // data blob is empty
                    ex.ToString();
                    fileLength = 0;
                }
                byte[] ddsimage = new byte[fileLength];
                if (fileLength > 0)
                {
                    reader.GetBytes(12, 0, ddsimage, 0, ddsimage.Length);
                }
                Common.ads.Add(ddsimage);
                string[] row = { contentId.ToString(), activeS, activateS, Expires.ToString(), DayPartsS, dimensions, dataType, ViewsString };
                CacheEntryList.Items.Add(new ListViewItem(row));

            }
            sqlite.Close();
        }

        private void SaveAdImageButton_Click(object sender, EventArgs e)
        {
            if (CacheEntryList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select only one item first.");
            }
            else
            {
                int contentId = Int32.Parse(CacheEntryList.SelectedItems[0].SubItems[0].Text);
                //MessageBox.Show("Selected item ID #" + contentId.ToString() + ".");
                int adIndex = Common.cids.IndexOf(contentId);
                if (Common.ads[adIndex].Length == 0)
                {
                    MessageBox.Show("Sorry, there is currently no image data stored for that ad.");
                    return;
                }

                if (Common.IsBIK(Common.ads[adIndex]))
                {
                    SaveDDSDialogue.FileName = contentId.ToString() + ".bik";
                    SaveDDSDialogue.DefaultExt = "bik";
                    SaveDDSDialogue.FilterIndex = 2;
                }
                else
                {
                    SaveDDSDialogue.FileName = contentId.ToString() + ".dds";
                    SaveDDSDialogue.DefaultExt = "dds";
                    SaveDDSDialogue.FilterIndex = 1;
                }
                DialogResult result = SaveDDSDialogue.ShowDialog();
                if (result != DialogResult.Cancel)
                {
                    // ok!
                    try
                    {
                        FileStream fs = new FileStream(SaveDDSDialogue.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                        fs.Write(Common.ads[adIndex], 0, Common.ads[adIndex].Length);
                        fs.Flush();
                        fs.Close();
                        MessageBox.Show("File saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was a problem saving the image.  The error was: " + ex.Message);
                    }
                }

            }
        }

        private void ImportImageButton_Click(object sender, EventArgs e)
        {
            if (CacheEntryList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select only one item first.");
            }
            else
            {
                int contentId = Int32.Parse(CacheEntryList.SelectedItems[0].SubItems[0].Text);

                int adIndex = Common.cids.IndexOf(contentId);
                byte[] ddsimage;
                DialogResult result = LoadDDSDialogue.ShowDialog();
                if (result != DialogResult.Cancel)
                {
                    // shove new ad data into the array     
                    try
                    {
                        FileStream fs = new FileStream(LoadDDSDialogue.FileName, FileMode.Open, FileAccess.Read);
                        if (Common.ads[adIndex].Length > 0 && fs.Length != Common.ads[adIndex].Length && !LoadDDSDialogue.FileName.EndsWith("bik", StringComparison.InvariantCultureIgnoreCase))
                        {
                            if (MessageBox.Show("File size doesn't match old image!  Image sizes must be the same!\r\n\r\nNon-matching images sizes can result in data corruption, and the game crashing!  Ensure you are using a 24-bit (RGB) image, you have generated mipmaps, and are using DXT1 compression.\r\n\r\nDo you want to continue?", "Import Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
                            {
                                fs.Close();
                                return;
                            }
                        }
                        else if (LoadDDSDialogue.FileName.EndsWith("bik", StringComparison.InvariantCultureIgnoreCase))
                        {
                            MessageBox.Show("Warning: Not all games support BIK video format.  Continuing anyway.");
                        }
                        ddsimage = new byte[fs.Length];
                        fs.Read(ddsimage, 0, (int)fs.Length);
                        fs.Close();
                        Common.ads[adIndex] = ddsimage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failure reading file.  The error was: " + ex.Message);
                        return;
                    }

                    try
                    {
                        // now write back to db
                        sqlite.Open();
                        SQLiteCommand query = new SQLiteCommand(@"UPDATE [content] SET [data] = @data, [size] = @size WHERE [contentId] = @cid", sqlite);
                        SQLiteParameter d = new SQLiteParameter("data", ddsimage);
                        SQLiteParameter s = new SQLiteParameter("size", ddsimage.Length);
                        SQLiteParameter c = new SQLiteParameter("cid", contentId);
                        query.Parameters.Add(c);
                        query.Parameters.Add(s);
                        query.Parameters.Add(d);
                        query.ExecuteNonQuery();
                        sqlite.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failure committing data to database.\r\n\r\nInternal buffers are now inconsistant.  It is recommended you restart this program.\r\n\r\nThe error was: " + ex.Message);
                        return;
                    }

                    MessageBox.Show("Imported file successfully!");

                }
            }
        }

        private void refreshDatabaseMenuItem_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            appExit();
        }

        private void appExit()
        {
            if (sqlite != null)
            {
                sqlite.Close();
            }

            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // hook shutdown nicely.
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                appExit();
            }
        }

        private void EditRecordButton_Click(object sender, EventArgs e)
        {
            if (CacheEntryList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select only one item first.");
            }
            else
            {
                int contentId = Int32.Parse(CacheEntryList.SelectedItems[0].SubItems[0].Text);
                sqlite.Open();
                SQLiteCommand query = new SQLiteCommand(@"SELECT * FROM [content] WHERE [contentId] = @cid", sqlite);
                SQLiteParameter c = new SQLiteParameter("cid", contentId);
                query.Parameters.Add(c);
                SQLiteDataReader reader = query.ExecuteReader();
                reader.Read();
                AdEditorForm aef = new AdEditorForm(reader);
                aef.ShowDialog();
                sqlite.Close();
                if (aef.Success)
                {
                    int ave = aef.VActive;
                    int ate = aef.VActivate;
                    int ex = aef.VExpire;
                    int dp = aef.VDayParts;
                    int ct = aef.VContentType;
                    String des = aef.VDescriptor;
                    int s = aef.VSize;
                    int vc = aef.VViewCount;
                    int vl = aef.VViewLimit;
                    int da = aef.VDisplayAfter;
                    String p = aef.VProps;
                    sqlite.Open();
                    query = new SQLiteCommand(@"UPDATE [content] SET [active]=@active, [activate]=@activate, [expire]=@expire, [dayparts]=@dayparts, [contentType]=@contentType, [descriptor]=@descriptor, [size]=@size, [viewcount]=@viewcount, [viewlimit]=@viewlimit, [displayafter]=@displayafter, [props]=@props WHERE [contentId]=@cid", sqlite);
                    //query = new SQLiteCommand(@"UPDATE [content] SET [active]=@active, [activate]=@activate, [expire]=@expire, [props]=@props WHERE [contentId]=@cid", sqlite);
                    query.Parameters.Add(c);
                    query.Parameters.Add(new SQLiteParameter("active", ave));
                    query.Parameters.Add(new SQLiteParameter("activate", ate));
                    query.Parameters.Add(new SQLiteParameter("expire", ex));
                    query.Parameters.Add(new SQLiteParameter("dayparts", dp));
                    query.Parameters.Add(new SQLiteParameter("contentType", ct));
                    query.Parameters.Add(new SQLiteParameter("descriptor", des));
                    query.Parameters.Add(new SQLiteParameter("size", s));
                    query.Parameters.Add(new SQLiteParameter("viewcount", vc));
                    query.Parameters.Add(new SQLiteParameter("viewlimit", vl));
                    query.Parameters.Add(new SQLiteParameter("displayafter", da));
                    query.Parameters.Add(new SQLiteParameter("props", p));

                    if (query.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("There was an error updating the database!");
                    }
                    sqlite.Close();
                    RefreshList();
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxForm abf = new AboutBoxForm();
            abf.ShowDialog();
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            AdEditorForm aef = new AdEditorForm();
            aef.ShowDialog();

            if (aef.Success)
            {
                // success!
                int ave = aef.VActive;
                int ate = aef.VActivate;
                int ex = aef.VExpire;
                int dp = aef.VDayParts;
                int ct = aef.VContentType;
                String des = aef.VDescriptor;
                int s = aef.VSize;
                int vc = aef.VViewCount;
                int vl = aef.VViewLimit;
                int da = aef.VDisplayAfter;
                String p = aef.VProps;
                sqlite.Open();
                SQLiteCommand query = new SQLiteCommand(@"INSERT INTO [content] ([active], [activate], [expire], [dayparts], [contentType], [descriptor], [size], [viewcount], [viewlimit], [displayafter], [props]) VALUES (@active, @activate, @expire, @dayparts, @contentType, @descriptor, @size, @viewcount, @viewlimit, @displayafter, @props); SELECT last_insert_rowid() AS contentId;", sqlite);
                query.Parameters.Add(new SQLiteParameter("active", ave));
                query.Parameters.Add(new SQLiteParameter("activate", ate));
                query.Parameters.Add(new SQLiteParameter("expire", ex));
                query.Parameters.Add(new SQLiteParameter("dayparts", dp));
                query.Parameters.Add(new SQLiteParameter("contentType", ct));
                query.Parameters.Add(new SQLiteParameter("descriptor", des));
                query.Parameters.Add(new SQLiteParameter("size", s));
                query.Parameters.Add(new SQLiteParameter("viewcount", vc));
                query.Parameters.Add(new SQLiteParameter("viewlimit", vl));
                query.Parameters.Add(new SQLiteParameter("displayafter", da));
                query.Parameters.Add(new SQLiteParameter("props", p));

                // get the contentId back
                Object cidR = query.ExecuteScalar();
                int cid = (int)((long)cidR);
                //MessageBox.Show("New CID was #" + cid.ToString() + ".");
                // shove cid into props
                p = "contentId=" + cid.ToString() + "&" + p;

                // reset connection
                sqlite.Close();
                sqlite.Open();

                query = new SQLiteCommand(@"UPDATE [content] SET [props]=@props WHERE [contentId]=@cid", sqlite);
                query.Parameters.Add(new SQLiteParameter("props", p));
                query.Parameters.Add(new SQLiteParameter("cid", cid));
                query.ExecuteNonQuery();

                sqlite.Close();
                MessageBox.Show("Record added successfully.  You should now import a DDS image for the ad.\r\n\r\nThe new record's contentId is " + cid.ToString() + ".", "Ad Cache Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshList();
            }
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            if (CacheEntryList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select only one item first.");
            }
            else
            {
                int contentId = Int32.Parse(CacheEntryList.SelectedItems[0].SubItems[0].Text);
                if (MessageBox.Show("Are you sure you want to delete this ad?", "Ad Cache Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    // no was pressed, dropout
                    return;
                }

                sqlite.Open();
                SQLiteCommand query = new SQLiteCommand(@"DELETE FROM [content] WHERE [contentId]=@cid", sqlite);
                query.Parameters.Add(new SQLiteParameter("cid", contentId));
                if (query.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Successfully deleted entry from database.");
                }
                else
                {
                    MessageBox.Show("There was a problem deleting the selected entry from the database.\r\n\r\nPerhaps another program using the database has already deleted it?");
                }
                
                sqlite.Close();
                RefreshList();
            }
        }



        private void importAdpackFilebfadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenAdpackDialogue.ShowDialog() != DialogResult.Cancel)
            {
                ImportAdPack(OpenAdpackDialogue.FileName);

            }
        }

        private void ImportAdPack(String filename)
        {
            // attempt to open
            FileStream fs;
            try
            {
                fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem opening the adpack.  The error was: " + ex.Message);
                return;
            }
            AdPack ap = new AdPack(MainForm.AppID);
            try
            {
                ap.Deserialize(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured reading the adpack.  The error was: " + ex.Message);
                return;
            }

            if (ap.Files.Count == 0)
            {
                MessageBox.Show("Sorry, no importable ads were found.");
                return;
            }

            // jump to import wizard thingy
            AdPackImportForm apif = new AdPackImportForm(ap, ContentTypes);
            apif.ShowDialog();

            if (apif.Success)
            {
                RefreshList();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // handle commandline args
            if (args.Length == 1 && File.Exists(args[0]))
            {
                if (MessageBox.Show("You (or another application) has tried to open an adpack file.  Would you like to import it into your cache file?", "Battlefield 2142 Ad Cache Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Load Up
                    bool success = OpenDatabaseConnection();

                    if (success)
                    {
                        // import a single file
                        ImportAdPack(args[0]);
                    }
                    else
                    {
                        appExit();
                    }
                }
                else
                {
                    appExit();
                }
            }
            databaseToolStripMenuItem.Image = SystemIcons.Application.ToBitmap();
            helpToolStripMenuItem.Image = SystemIcons.Information.ToBitmap();
            debugToolStripMenuItem.Image = SystemIcons.Warning.ToBitmap();
            CacheEntryList.Focus();
        }

        private void exportAdpackFilebfadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdPackExportForm apef = new AdPackExportForm(AppID, ContentTypes);
            apef.ShowDialog();
        }

        private void closeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseDatabase();
        }

        private void CloseDatabase()
        {
            sqlite.Close();
            sqlite = null;
            Common.ads = null;
            Common.cids = null;
            contentTypes = null;
            WelcomeGroup.Show();
            EditingGroup.Hide();
            refreshToolStripMenuItem.Enabled = false;
            importAdpackFilebfadsToolStripMenuItem.Enabled = false;
            exportAdpackFilebfadsToolStripMenuItem.Enabled = false;
            closeDatabaseToolStripMenuItem.Enabled = false;
            vacuumDatabaseToolStripMenuItem.Enabled = false;
            debugToolStripMenuItem.Enabled = false;
        }

        private void vacuumDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VacuumDatabase();
        }

        private void VacuumDatabase()
        {
            sqlite.Open();
            SQLiteCommand query = new SQLiteCommand("VACUUM", sqlite);
            query.ExecuteNonQuery();
            sqlite.Close();
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://igaeditor.sourceforge.net/");
        }

        private void researchForumThreadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.totalbf2142.com/forums/showthread.php?t=5342");
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            byte[] d;
            try
            {
                d = wc.DownloadData("http://igaeditor.sourceforge.net/latest.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem contacting the webserver.  Please ensure you are connected to the internet.  The error was: " + ex.Message, "Ad Cache Editor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (d.Length > 15)
            {
                MessageBox.Show("Got more than 15 bytes back from the webserver.  This could mean that the format of the update file has changed.");
                return;
            }
            String latestVersionS = ASCIIEncoding.ASCII.GetString(d).Trim();
            if (latestVersionS == Application.ProductVersion)
            {
                MessageBox.Show("You already have the latest version installed (" + Application.ProductVersion + ")");
            }
            else
            {
                if (MessageBox.Show(String.Format("You don't have the current version of the software.  The latest version is {0}, your version is {1}.\r\n\r\nWould you like to visit the website now to download the current version?", latestVersionS, Application.ProductVersion), "Ad Cache Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Process.Start("http://igaeditor.sourceforge.net/");
                }
            }
        }

        private void PreviewImageButton_Click(object sender, EventArgs e)
        {
            if (CacheEntryList.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select only one item first.");
            }
            else
            {
                int contentId = Int32.Parse(CacheEntryList.SelectedItems[0].SubItems[0].Text);
                //MessageBox.Show("Selected item ID #" + contentId.ToString() + ".");
                int adIndex = Common.cids.IndexOf(contentId);
                if (Common.ads[adIndex].Length == 0)
                {
                    MessageBox.Show("There is no image in the data block, so there is nothing to see.");
                    return;
                }
                if (Common.IsBIK(Common.ads[adIndex]))
                {
                    MessageBox.Show("Sorry, cannot preview BI(N)K video ads.");
                    return;
                }

                try
                {
                    DDSReader.Ping();
                    PreviewBox.Image = DDSReader.LoadImage(Common.ads[adIndex]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem trying to load the preview.  The message was: " + ex.Message, "Ad Cache Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EditingGroup.Hide();
                menuStrip1.Hide();
                ImagePreviewGroup.Show();


            }
        }

        private void CacheEntryList_MouseClick(object sender, MouseEventArgs e)
        {
            // This simulates a contextMenuStrip, so that we are more compatible with Mono.
            if (e.Button == MouseButtons.Right)
            {
                // simulate context menu?
                if (CacheEntryList.SelectedItems.Count == 1)
                {
                    AdContextMenu.Show((Control)sender, new Point(e.X, e.Y));
                }
            }
        }

        private void changeAppIDOfCacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OverrideAppidForm oaf = new OverrideAppidForm();
            oaf.ShowDialog();
            

            if (oaf.Success)
            {
                
                appID = oaf.AppID;
                if (oaf.SaveToDatabase)
                {
                    // try to write back
                    SQLiteCommand query = new SQLiteCommand(@"UPDATE [contentlist] SET [appid]=@appid", sqlite);
                    query.Parameters.Add(new SQLiteParameter("appid", appID));
                    sqlite.Open();
                    if (query.ExecuteNonQuery() == 0)
                    {
                        // no data in contentlist... add new.
                        sqlite.Close();
                        query = new SQLiteCommand(@"INSERT INTO [contentlist] ([appid]) VALUES (@appid)", sqlite);
                        query.Parameters.Add(new SQLiteParameter("appid", appID));
                        sqlite.Open();
                        query.ExecuteNonQuery();
                    }

                    sqlite.Close();
                }
                SetReadonlyRestrictions(appID);
                RefreshList();
                MessageBox.Show("The operation was completed.");
            }
        }

        private void executeSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlInjectorForm sif = new SqlInjectorForm(sqlite);
            sif.ShowDialog();
            RefreshList();
        }

        private void PreviewBox_Click(object sender, EventArgs e)
        {
            ImagePreviewGroup.Hide();
            menuStrip1.Show();
            EditingGroup.Show();
            
        }
    }
}