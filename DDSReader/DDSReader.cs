using System;
//using DevIL;
using System.Drawing;
using System.IO;

namespace au.id.micolous.libs.DDSReader
{
    /// <summary>
    /// This is the main class of the library.  All static methods are contained within.
    /// </summary>
    public static class DDSReader
    {

        /// <summary>
        /// Loads an image file with DevIL.NET, and returns a Bitmap object of the image.
        /// </summary>
        /// <param name="data">The image data.</param>
        /// <returns>The Bitmap representation of the image.</returns>
        public static Bitmap LoadImage(byte[] data)
        {
        	DDSImage im = new DDSImage(data);
        	return im.GetBitmap();
            // write the data to a temporary file.
            /*String tempFile = Path.GetTempFileName();
            FileStream fs = new FileStream(tempFile, FileMode.Create, FileAccess.Write);

            fs.Write(data, 0, data.Length);
            fs.Flush();
            fs.Close();

            // now load the image.
            Bitmap b = DevIL.DevIL.LoadBitmap(tempFile);

            File.Delete(tempFile);

            return b;*/
        }
        
        

        /// <summary>
        /// "Pings" the library.
        /// </summary>
        /// <returns>Always returns true.</returns>
        public static bool Ping()
        {
            return true;
        }
       
    }
}
