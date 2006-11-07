using System;
using System.Collections.Generic;
using System.Text;

namespace au.id.micolous.apps.igaeditor
{
    /// <summary>
    /// This class defines a simple application name.
    /// </summary>
    public class AppInfo
    {
        /// <summary>
        /// The application's full name.  eg: "Battlefield 2142".
        /// </summary>
        public String AppName;
        /// <summary>
        /// The application's "short" name, used in metainfo.dat in adpack files.
        /// This should be in all lower case, and unique.
        /// eg: "bf2142".
        /// </summary>
        public String AppNameShort; 
        /// <summary>
        /// The appid for the program.  This is determined by the IGA library.
        /// eg: 52  (for BF2142).
        /// </summary>
        public int AppID;

        /// <summary>
        /// Creates a new AppInfo.
        /// </summary>
        /// <param name="AppName">The application's name.</param>
        /// <param name="AppNameShort">The application's short name.  This should be in all lower case.</param>
        /// <param name="AppID">The application's ID, as determined by the IGA library.</param>
        public AppInfo(String AppName, String AppNameShort, int AppID)
        {
            this.AppID = AppID;
            this.AppName = AppName;
            this.AppNameShort = AppNameShort;
        }
    }
}
