using System;
using System.Collections.Generic;
using System.Text;

namespace au.id.micolous.libs.igacommon
{
    /// <summary>
    /// This is a single row of "content".
    /// </summary>
    public class ContentEntry
    {
        /// <summary>
        /// The ad's contentId.
        /// </summary>
        public uint ContentID = 0;
        /// <summary>
        /// Wether or not the ad is presently active.
        /// </summary>
        public bool Active = true;
        /// <summary>
        /// When the ad becomes active.
        /// </summary>
        public DateTime Activate = DateTime.Now.ToUniversalTime();
        /// <summary>
        /// Wether or not the ad expires.
        /// </summary>
        public bool Expires = false;
        /// <summary>
        /// When the ad expires.
        /// </summary>
        public DateTime Expiry;
        /// <summary>
        /// The times of the day and week that the ad is shown.
        /// </summary>
        public uint DayParts = 16777215;
        /// <summary>
        /// The contentType of the ad.
        /// </summary>
        public ContentType contentType = new ContentType();
        /// <summary>
        /// The "cellDescriptor" of the ad (unknown).
        /// </summary>
        public String Descriptor = "31";
        /// <summary>
        /// The size of the file in the data block.
        /// </summary>
        public uint Size = 0;
        /// <summary>
        /// The number of times that the ad has been viewed.
        /// </summary>
        public uint ViewCount = 0;
        /// <summary>
        /// The number of times that the ad may be viewed before it expires.
        /// </summary>
        public uint ViewLimit = 0;
        /// <summary>
        /// Unknown
        /// </summary>
        public uint DisplayAfter = 0;
        /// <summary>
        /// Some other properties are attached here.  And others are redundantly stored here.
        /// </summary>
        public SortedDictionary<String, String> Properties = new SortedDictionary<string,string>();
        /// <summary>
        /// The image or video file that is the ad.
        /// </summary>
        public byte[] Data;

        /// <summary>
        /// Creates a new ContentEntry, with default values.
        /// </summary>
        public ContentEntry()
        {
            Properties.Add("zoneid", "16");
            Properties.Add("userInfo", "m18");
            Properties.Add("MinSize", "4");
            Properties.Add("MaxSize", "100");
            Properties.Add("MinTime", "2000");
            Properties.Add("Deflection", "80");
            Sync();
        }

        /// <summary>
        /// This function syncs the main attributes of the class to the Properties list.
        /// 
        /// You should call this after you've finished modifying attributes.
        /// </summary>
        public void Sync()
        {
            this.Properties["contentType"] = this.contentType.contentType.ToString();
            this.Properties["Activate"] = this.Activate.ToString();
            this.Properties["Expire"] = this.Expiry.ToString();
            this.Properties["DayParts"] = this.DayParts.ToString();
            this.Properties["Size"] = this.Size.ToString();
            this.Properties["PerUserLimit"] = this.ViewLimit.ToString();
            this.Properties["DisplayAfter"] = this.DisplayAfter.ToString();
            this.Properties["CellDiscriptors"] = this.Descriptor;
        }

        /// <summary>
        /// Get all the properties as a string for entering into the database.
        /// </summary>
        /// <returns>A string containing all the properties.</returns>
        public String GetPropsAsString()
        {
            Sync();
            String propS = "";
            foreach (KeyValuePair<String, String> prop in Properties)
            {
                propS += prop.Key + "=" + prop.Value + "&";
            }
            return propS;
        }

    }
}
