
using System;
using au.id.micolous.libs.igacommon;
using System.Collections.Generic;
using System.Drawing;
using Gtk;

namespace igaeditorgtk
{
	public class MainForm : Gtk.Window
	{
		protected Gtk.TreeView RecordTreeView;
		protected IGADatabaseConnector _igaconnector;
		protected Gtk.Label DatabaseTitleLabel;
		protected Gtk.Button AddRecordButton;
		protected Gtk.Button EditRecordButton;
		protected Gtk.Button DeleteRecordButton;
		protected Gtk.Button ImportImageButton;
		protected Gtk.Action ImportAdpack;
		protected Gtk.Action ExportAdpack;
		
		public MainForm(IGADatabaseConnector connector) : 
				base("")
		{
			Stetic.Gui.Build(this, typeof(igaeditorgtk.MainForm));
			
			// open database
			this._igaconnector = connector;

			this.RecordTreeView.AppendColumn("ID", new CellRendererText(), "text", 0);
			this.RecordTreeView.AppendColumn("Active?", new CellRendererText(), "text", 1);
			this.RecordTreeView.AppendColumn("Activates", new CellRendererText(), "text", 2);
			this.RecordTreeView.AppendColumn("Expires", new CellRendererText(), "text", 3);
			this.RecordTreeView.AppendColumn("Shown", new CellRendererText(), "text", 4);
			this.RecordTreeView.AppendColumn("Size", new CellRendererText(), "text", 5);
			this.RecordTreeView.AppendColumn("Type", new CellRendererText(), "text", 6);
			this.RecordTreeView.AppendColumn("Views", new CellRendererText(), "text", 7);
			this.RecordTreeView.HeadersVisible = true;
			this.RepopulateList();
			this.Show();
			if (this._igaconnector.AppSupported) {
				this.DatabaseTitleLabel.Text = "Ad Cache Entries for " + this._igaconnector.appInfo.AppName + ":";
			} else {
				this.DatabaseTitleLabel.Text = "Ad Cache Entries for Unknown Application (#" + this._igaconnector.AppID.ToString() + "):";
				// disable write functions
				this.AddRecordButton.Sensitive = false;
				this.EditRecordButton.Sensitive = false;
				this.DeleteRecordButton.Sensitive = false;
				this.ImportImageButton.Sensitive = false;
				this.ImportAdpack.Sensitive = false;
				this.ExportAdpack.Sensitive = false;
				// display warning
				MessageDialog d = new MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok,
					"The application that created this cache file is not officially supported.  Write functions have been disabled to prevent potential damage to the file.");
				d.Run();
				d.Destroy();		
			}
		}
		
		private void RepopulateList() {
			TreeStore store = new TreeStore(typeof(uint), typeof(string), typeof(string), 
				typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));
			
			SortedDictionary <uint, ContentEntry> data = this._igaconnector.GetAllEntries(false);
			
			foreach (KeyValuePair<uint, ContentEntry> row in data) {
				String ActiveS = "Yes";
				if (!row.Value.Active) {
					ActiveS = "No";
				}
				
				String ExpiryS = "Never";
				if (row.Value.Expires) {
					ExpiryS = row.Value.Expiry.ToString(Common.DateTimeFormat);
				}
				
				String DayPartsS = "Always";
                if (row.Value.DayParts == 0)
                {
                    DayPartsS = "Never";
                }
                else if (row.Value.DayParts < 16777215)
                {
                    DayPartsS = "Sometimes";
                }
                else if (row.Value.DayParts > 16777215)
                {
                    DayPartsS = "Invalid";
                }
                
                String ViewsS = row.Value.ViewCount.ToString();
                if (row.Value.ViewLimit > 0) {
                    ViewsS += " of " + row.Value.ViewLimit.ToString();
                }
                Size isize = row.Value.contentType.GetSize();
                
                String typeS = "Unknown";
                switch (row.Value.contentType.GetItemType())
                {
                    case ItemType.BinkVideo:
                        typeS = "BINK Video";
                        break;
                    case ItemType.DDSImage:
                        typeS = "DDS Image";
                        break;
                }
                
				store.AppendValues(row.Value.ContentID, ActiveS, row.Value.Activate.ToString(Common.DateTimeFormat),
					ExpiryS, DayPartsS, isize.Width + "x" + isize.Height, typeS, ViewsS);
				
				
				
			}
			
			this.RecordTreeView.Model = store;
		}

		protected virtual void OnVaccumShrinkDatabaseActivated(object sender, System.EventArgs e)
		{
			this._igaconnector.VaccumDatabase();
			MessageDialog d = new MessageDialog(this, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok,
				"Database has been vaccumed successfully.");
			d.Run();
			d.Destroy();
		}

		protected virtual void OnReloadActivated(object sender, System.EventArgs e)
		{
			this.RepopulateList();
		}

		protected virtual void OnExitActivated(object sender, System.EventArgs e)
		{
			this.AppExit();
		}

		protected virtual void OnDeleteEvent(object o, Gtk.DeleteEventArgs args)
		{
			this.AppExit();
		}
		
		protected void AppExit() {
			this._igaconnector = null;
			Application.Quit();
		}

		protected virtual void OnCloseDatabaseActivated(object sender, System.EventArgs e)
		{
			this._igaconnector = null;
			MainClass.owin = new OpenWindow();
			MainClass.owin.Show();
			MainClass.owin.Activate();
			this.Hide();
			this.Destroy();
		}

		protected virtual void OnPreviewImageButtonPressed(object sender, System.EventArgs e)
		{
			uint cid;
			try {
				cid = this.GetSelectedCid();
			} catch (NoItemSelectedException) {
				return;
			}
			
			this.ShowImagePreview(cid);
		}

		protected uint GetSelectedCid() {
			TreeSelection sel = this.RecordTreeView.Selection;
			
			if (sel != null) {
				TreeIter iter;
				TreeModel model;
	 
				if (sel.GetSelected (out model, out iter)) {
					uint cid = (uint) model.GetValue (iter, 0);
					Console.WriteLine ("{0} was selected", cid);
					return cid;
				}
			}
			
			MessageDialog d = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok,
				"You must select a record first.");
			d.Run();
			d.Destroy();
			throw new NoItemSelectedException();
		}

		protected void ShowImagePreview(uint contentId) {
			
			byte[] ddsimage = this._igaconnector.ExportImage(contentId);
			if (ddsimage.Length > 0) {
				if (!Common.IsBIK(ddsimage)) {
					MainClass.ShowPreviewImage(ddsimage);
				} else {
					MessageDialog d = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok,
						"BINK Video cannot be previewed.  Please export it first, and view it with RAD Video Tools instead.");
					d.Run();
					d.Destroy();
				}
			} else {
				MessageDialog d = new MessageDialog(this, DialogFlags.Modal, MessageType.Error, ButtonsType.Ok,
					"There is no image stored in this record.");
				d.Run();
				d.Destroy();
			}
		}
	}
}
