using System;
using Gtk;
using au.id.micolous.libs.igacommon;

namespace igaeditorgtk {
	public class OpenWindow: Gtk.Window
	{
		protected Gtk.FileChooserWidget FileChooserControl;
		private bool Success = false;
		protected Gtk.ComboBox FileFilterCombo;

		
		public OpenWindow (): base ("")
		{
			Stetic.Gui.Build (this, typeof(OpenWindow));
			FileFilter f = new FileFilter();
			f.AddPattern("icontent.cache");
			f.Name = "icontent.cache";
			this.FileChooserControl.AddFilter(f);
			f = new FileFilter();
			f.AddPattern("*.cache");
			f.Name = "Cache Files";
			this.FileChooserControl.AddFilter(f);
			f = new FileFilter();
			f.AddPattern("*");
			f.Name = "All Files";
			this.FileChooserControl.AddFilter(f);
			
		}

		protected virtual void OnOpenDatabaseButtonClicked(object sender, System.EventArgs e)
		{
			if (this.FileChooserControl.Filename != null) {
				this.OpenDatabase(this.FileChooserControl.Filename);
			} else {
				MessageDialog d = new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok,
					"Please select a file to open first.");
				d.Run();
				d.Destroy();
			}		
		}
		
		protected void OpenDatabase(String filename) {
			// open db
			IGADatabaseConnector connector;
			try {
				connector = new IGADatabaseConnector(this.FileChooserControl.Filename);
				
				// connected okay, now spawn mainform
				this.Success = true;
				this.Hide();
				new MainForm(connector);
				this.Destroy();
				MainClass.owin = null;
			} catch (DatabaseConnectionFailureException) {
				MessageDialog d = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok,
					"There was a problem trying to open the cache file.  It is probably not in the right format, or it has been corrupted.");
				d.Run();
				d.Destroy();
			}
		
		}

		protected virtual void OnDeleteEvent(object o, Gtk.DeleteEventArgs args)
		{
			if (!this.Success) {
				Application.Quit();
			}
		}

		protected virtual void OnFileFilterComboChanged(object sender, System.EventArgs e)
		{
			//this.FileChooserControl.Filter = new FileFilter();
			//this.FileChooserControl.Filter.AddPattern(FileFilterCombo.ActiveText);
			
		}

		protected virtual void OnFileChooserControlFileActivated(object sender, System.EventArgs e)
		{
			if (this.FileChooserControl.Filename != null) {
				this.OpenDatabase(this.FileChooserControl.Filename);
			}
		}
	}
}