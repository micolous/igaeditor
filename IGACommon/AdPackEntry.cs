using System;
using System.Collections.Generic;
using System.Text;

namespace au.id.micolous.libs.igacommon
{
    /// <summary>
    /// AdPackEntry is a class that defines a single record to be loaded into,
    /// or loaded from an adpack.  It isn't designed to hold records from
    /// icontent.cache, as some of the data that is redundant isn't stored in
    /// the file format.
    /// </summary>
    public class AdPackEntry
    {
        private byte[] _ddsdata;
        /// <summary>
        /// Returns a copy of the DDS or BIK data stored in the data block.
        /// </summary>
        public byte[] DDSData { get { return _ddsdata; } }
        private String _filename;
        /// <summary>
        /// The filename of the image to be used in the adpack file.
        /// </summary>
        public String FileName { get { return _filename; } set { _filename = value; } }
        private String _description;
        /// <summary>
        /// The description of the file, aka, the "title".
        /// </summary>
        public String Description { get { return _description; } set { _description = value; } }
        private ContentType _contentType;
        /// <summary>
        /// An contentType for the record.
        /// </summary>
        public ContentType ContentType { get { return _contentType; } }

        /// <summary>
        /// Creates an empty AdPackEntry.
        /// </summary>
        public AdPackEntry()
        {
            // create an empty adpackentry
        }

        /// <summary>
        /// Creates an AdPackEntry with no data block.
        /// </summary>
        /// <param name="filename">The filename to use.</param>
        /// <param name="description">The description of the file.  This is called
        /// the "title" parameter in filelist.dat.</param>
        /// <param name="contentType">A IGA-style contentType code.</param>
        public AdPackEntry(String filename, String description, ContentType contentType)
            :
            this(filename, description, contentType, null)
        {
        }

        /// <summary>
        /// Creates an AdPackEntry with a data block.
        /// </summary>
        /// <param name="filename">The filename to use.</param>
        /// <param name="description">The description of the file.  This is called
        /// the "title" parameter in filelist.dat.</param>
        /// <param name="contentType">A contentType.</param>
        /// <param name="ddsdata">The DDS image data (or BIK) to load into the file.</param>
        public AdPackEntry(String filename, String description, ContentType contentType, byte[] ddsdata)
        {
            this._contentType = contentType;
            this._ddsdata = ddsdata;
            this._description = description;
            this._filename = filename;
        }

        /// <summary>
        /// Sets the DDS data block to be 'data'.
        /// </summary>
        /// <param name="data">The new contents of the data block to be inserted.</param>
        public void SetDDSData(byte[] data)
        {
            if (data.Length == 0)
            {
                throw new Exception("Data has no length, cannot insert!");
            }

            this._ddsdata = data;
        }


        /// <summary>
        /// Converts an AdPackEntry to a ContentEntry object.
        /// </summary>
        /// <returns>The new, converted ContentEntry object.</returns>
        public ContentEntry ToContentEntry()
        {
            ContentEntry entry = new ContentEntry();
            entry.Size = (uint)this._ddsdata.Length;
            entry.Data = this._ddsdata;
            entry.contentType = this._contentType;
            return entry;
        }      
    }
}
