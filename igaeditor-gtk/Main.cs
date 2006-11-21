// project created on 19/11/2006 at 1:30 A
using System;
using Gtk;
using System.Drawing;
using System.Drawing.Imaging;
using au.id.micolous.libs.DDSReader;

namespace igaeditorgtk
{
	class MainClass
	{
		public static OpenWindow owin;
	
		public static void Main (string[] args)
		{
			Application.Init ();
			owin = new OpenWindow ();
			owin.Show ();
			Application.Run ();
		}
		
		public static Gdk.Pixbuf CreatePixbufFromResource( Bitmap bitmap ) {
			// creates a Gdk.Pixbuf from a Bitmap object
			// thanks to bratshche (Cody Russell) on #mono for the help!
			BitmapData data = bitmap.LockBits( new Rectangle( 0, 0,
				bitmap.Width,
				bitmap.Height),
				ImageLockMode.ReadOnly,
				System.Drawing.Imaging.PixelFormat.Format32bppArgb );
			IntPtr scan = data.Scan0;
			int size = bitmap.Width * bitmap.Height * 4;
			byte[] bdata = new byte[ size ];
			Gdk.Pixbuf pixbuf = null;
			unsafe {
				byte* p = (byte*)scan;
				for (int i = 0; i < size; i+=4) {
					// iterate through bytes.
					// Bitmap stores it's data in RGBA order.
					// Pixbuf stores it's data in BGRA order.
					bdata[ i ]   = p[ i+2 ]; // blue
					bdata[ i+1 ] = p[ i+1 ]; // green
					bdata[ i+2 ] = p[ i ];   // red
					bdata[ i+3 ] = p[ i+3 ]; // alpha
				}
			}
			pixbuf = new Gdk.Pixbuf( bdata, true, 8,
				bitmap.Width, bitmap.Height,
				data.Stride, null );
			bitmap.UnlockBits( data );
			return pixbuf;
		}
		
		public static void ShowPreviewImage(byte[] ddsimage) {
			// convert to bitmap first
			ShowPreviewImage(DDSReader.LoadImage(ddsimage));
		}
		
		public static void ShowPreviewImage(Bitmap image) {
			// convert to gdk.pixbuf first
			ShowPreviewImage(CreatePixbufFromResource(image));
		}
		
		public static void ShowPreviewImage(Gdk.Pixbuf image) {
			// now show window of things.
			Window win = new Window("Image Preview");
			win.SetDefaultSize(image.Width, image.Height);
			Gtk.Image im = new Gtk.Image(image);
			win.Add(im);
			win.ShowAll();
		
		}
			

	}
}