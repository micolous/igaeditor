using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data.SQLite;
using System.Globalization;

namespace au.id.micolous.libs.igacommon
{
    /// <summary>
    /// This class contains common static functions used throughout the program.
    /// 
    /// All readonly data should have a getter-only accessor.
    /// </summary>
    public class Common
    {
        private static SortedDictionary<int, AppInfo> appInfos = new SortedDictionary<int, AppInfo>();
        private static SortedDictionary<String, int> appShortNames = new SortedDictionary<string, int>();
        //private static String dateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        private static String dateTimeFormat = DateTimeFormatInfo.CurrentInfo.ShortDatePattern + " " + DateTimeFormatInfo.CurrentInfo.LongTimePattern;
        private static int[] contentTypes =
            { 2021100, 2041100, 2081100, 2101100, 3021100, 3041100, 4111100 };
        /*
        /// <summary>
        /// A storage cache for the data contents of ads.
        /// </summary>
        public static List<byte[]> ads;
        /// <summary>
        /// A storage cache for the ContentID values.  Also used to retrieve ads.
        /// </summary>
        public static List<int> cids;
        */

        /// <summary>
        /// A list of valid contentTypes that are supported by the program.  They all
        /// use the "image" (*1100) form, so you will need to minus 100 to get the
        /// video form.
        /// </summary>
        public static int[] ContentTypes { get { return contentTypes; } }

        /// <summary>
        /// A list of <typeparamref name="AppInfo"/>, with a key of the appid.
        /// </summary>
        public static SortedDictionary<int, AppInfo> AppInfos { get { return appInfos; } }

        /// <summary>
        /// A list of appids, with a key sorted by the app's short name.
        /// </summary>
        public static SortedDictionary<String, int> AppShortNames { get { return appShortNames; } }

        /// <summary>
        /// The format of time to be used for a date + time combination, in short form.
        /// </summary>
        public static String DateTimeFormat { get { return dateTimeFormat; } }

        /// <summary>
        /// A pointer to the <typeparamref name="SQLiteConnection"/> to be used in the program.
        /// </summary>
        //public static SQLiteConnection sqlite;


        static Common()
        {
            initAppData();
        }

        private static void addApp(String appName, String appShortName, int appID)
        {
            AppInfo newapp = new AppInfo(appName, appShortName, appID);
            appInfos.Add(appID, newapp);
            appShortNames.Add(appShortName, appID);
        }

        private static void initAppData()
        {
            addApp("Battlefield 2142", "bf2142", 52);
            addApp("Trackmania Nations ESWC", "tmneswc", 27);
        }

        /// <summary>
        /// This converts a integer contentType into the image's size, stored as a Size.
        /// </summary>
        /// <param name="contentType">The integer containing the contentType to convert from.</param>
        /// <returns>A Size containing the reported size of the image.</returns>
        public static Size ContentTypeToSize(uint contentType)
        {
            int ImageSizeX = 0, ImageSizeY = 0;
            switch (contentType / 10000)
            {
                case 202:
                    ImageSizeX = 128;
                    ImageSizeY = 256;
                    break;
                case 204:
                    ImageSizeX = 128;
                    ImageSizeY = 128;
                    break;
                case 208:
                    ImageSizeX = 512;
                    ImageSizeY = 256;
                    break;
                case 210:
                    ImageSizeX = 512;
                    ImageSizeY = 128;
                    break;
                case 302:
                    ImageSizeX = 256;
                    ImageSizeY = 512;
                    break;
                case 304:
                    ImageSizeX = 256;
                    ImageSizeY = 256;
                    break;
                case 411:
                    ImageSizeX = 512;
                    ImageSizeY = 64;
                    break;
                default:
                    throw new UnsupportedImageSizeException();
            }

            return new Size(ImageSizeX, ImageSizeY);
        }

        /// <summary>
        /// Determines wether the header of a file is BIK/BINK video.
        /// </summary>
        /// <param name="data">The data to examine.</param>
        /// <returns>True if it is BI(N)K video.</returns>
        public static bool IsBIK(byte[] data)
        {
            if (data[0] == 'B' && data[1] == 'I' && data[2] == 'K')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*
        /// <summary>
        /// Get image data from the cache.
        /// </summary>
        /// <param name="contentId">The contentId to get the image data for.</param>
        /// <returns>A byte array containing the raw image data.</returns>
        public static byte[] GetImageData(int contentId)
        {
            int adIndex = cids.IndexOf(contentId);
            return ads[adIndex];
        }*/

    }
}
