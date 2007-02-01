using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.Data.SQLite;
using System.Collections;
using System.IO;
using System.Diagnostics;
using System.Net;
using au.id.micolous.libs.DDSReader;
using au.id.micolous.libs.igacommon;

namespace au.id.micolous.apps.igaeditor
{
    partial class MainForm : Form
    {
        //private static SQLiteConnection sqlite;

        private String[] args;
        private SortedDictionary<uint, ContentEntry> itemCache;
        //private static SortedList<int, int> contentTypes;
        //public static SortedList<int, int> ContentTypes { get { return contentTypes; } }
        //private static int appID;
        //public static int AppID { get { return appID; } }
        
        private IGADatabaseConnector _igaconnector;

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
                    try {
                    	_igaconnector = new IGADatabaseConnector(OpenDatabaseDialogue.FileName);
                        if (_igaconnector.AppID == 0)
                        {
                            // no appid
                            OverrideAppidForm oaf = new OverrideAppidForm();
                            oaf.ShowDialog();

                            if (oaf.Success)
                            {
                                _igaconnector.AppID = oaf.AppID;
                                if (oaf.SaveToDatabase)
                                {
                                    _igaconnector.ChangeAppID(oaf.AppID);
                                }
                            }
                            else
                            {
                                throw new Exception("The operation to select an appid was cancelled.");
                            }
                        }

                        if (!_igaconnector.AppSupported)
                        {
                            // unsupported appid
                            UnsupportedApplicationForm uaf = new UnsupportedApplicationForm(_igaconnector.AppID);
                            uaf.ShowDialog();
                        }
                    } catch (DatabaseConnectionFailureException) {
                        res = MessageBox.Show("There was a problem loading the cache file.\r\n\r\nWould you like to try again?", "Battlefield 2142 Ad Cache Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
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
                ViewSwitchButton.Visible = true;
                SetReadonlyRestrictions(_igaconnector.AppSupported);
                RefreshList();
            }

            return cont;
        }

        private void SetReadonlyRestrictions(bool ReadOnly)
        {
            if (ReadOnly)
            {
                EditingGroup.Text = "Ad Cache Entries for " + _igaconnector.appInfo.AppName + ":";
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
                EditingGroup.Text = "Ad Cache Entries for Unknown Application (#" + _igaconnector.AppID.ToString() + "):";
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
                vacuumDatabaseToolStripMenuItem.Enabled = true; //false;
            }
        }

        private void BigOpenButton_Click(object sender, EventArgs e)
        {
            OpenDatabaseConnection();
        }

        private void RefreshList()
        {
            CacheEntryList.Items.Clear();
            AdPreviews.Images.Clear();
            int ii = 0;

            // populate list
            itemCache = _igaconnector.GetAllEntries(true);

            foreach (KeyValuePair<uint, ContentEntry> item in itemCache)
            {
                String ActiveS = "Yes";
                if (!item.Value.Active) {
                    ActiveS = "No";
                }
                String ActivateS = item.Value.Activate.ToString(Common.DateTimeFormat);
                String ExpiryS = "Never";
                if (item.Value.Expires)
                {
                    ExpiryS = item.Value.Expiry.ToString(Common.DateTimeFormat);
                }

                String DayPartsS = "Always";
                if (item.Value.DayParts == 0)
                {
                    DayPartsS = "Never";
                }
                else if (item.Value.DayParts < 16777215)
                {
                    DayPartsS = "Sometimes";
                }
                else if (item.Value.DayParts > 16777215)
                {
                    DayPartsS = "Invalid";
                }

                String ViewsS = item.Value.ViewCount.ToString();
                if (item.Value.ViewLimit > 0) {
                    ViewsS += " of " + item.Value.ViewLimit.ToString();
                }

                Size isize = new Size(0,0);
                String sizeS = "Unknown";
                try
                {
                    isize = item.Value.contentType.GetSize();
                    sizeS = isize.Width + "x" + isize.Height;
                }
                catch (UnsupportedImageSizeException)
                {
                    // pass, we'll just skip right over that.
                }

                String typeS = "Unknown";
                switch (item.Value.contentType.GetItemType())
                {
                    case ItemType.BinkVideo:
                        typeS = "BINK Video";
                        break;
                    case ItemType.DDSImage:
                        typeS = "DDS Image";
                        break;
                }
                String[] i = { item.Value.ContentID.ToString(), ActiveS, ActivateS, ExpiryS, DayPartsS, sizeS, typeS, ViewsS };
                try
                {
                    if (isize.Width == 0 || isize.Height == 0)
                    {
                        // break out
                        throw new Exception("No image is there...");
                    }
                    AdPreviews.Images.Add(DDSReader.LoadImage(item.Value.Data));

                    // image addition/decoding okay, use as thumbnail.
                    CacheEntryList.Items.Add(new ListViewItem(i, ii));
                    ii++;
                }
                catch (Exception)
                {
                    // error loading image...
                    CacheEntryList.Items.Add(new ListViewItem(i));
                }
            }

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
                byte[] idata = _igaconnector.ExportImage(UInt32.Parse(CacheEntryList.SelectedItems[0].SubItems[0].Text));

                if (idata.Length == 0)
                {
                    MessageBox.Show("Sorry, there is currently no image data stored for that ad.");
                    return;
                }

                if (Common.IsBIK(idata))
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
                        fs.Write(idata, 0, idata.Length);
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
                uint contentId = UInt32.Parse(CacheEntryList.SelectedItems[0].SubItems[0].Text);
                byte[] ddsimage = _igaconnector.ExportImage(contentId);
                DialogResult result = LoadDDSDialogue.ShowDialog();
                if (result != DialogResult.Cancel)
                {
                    // shove new ad data into the array     
                    try
                    {
                        FileStream fs = new FileStream(LoadDDSDialogue.FileName, FileMode.Open, FileAccess.Read);
                        if (ddsimage == null) {
                            ddsimage = new byte[0];
                        }
                        if (ddsimage.Length > 0 && fs.Length != ddsimage.Length && !LoadDDSDialogue.FileName.EndsWith("bik", StringComparison.InvariantCultureIgnoreCase))
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failure reading file.  The error was: " + ex.Message);
                        return;
                    }

                    try
                    {
                        _igaconnector.ImportImage(contentId, ddsimage);
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
                uint contentId = UInt32.Parse(CacheEntryList.SelectedItems[0].SubItems[0].Text);
                ContentEntry entry = _igaconnector.GetEntry(contentId, false);
                if (entry == null)
                {
                    MessageBox.Show("Oops, no data was returned from IGADatabaseConnector.GetEntry.  This probably means that there was a problem retriving the row from the database, or it doesn't exist.");
                    return;
                }
                AdEditorForm aef = new AdEditorForm(_igaconnector, entry);
                aef.ShowDialog();
                if (aef.Success)
                {
                    try
                    {
                        _igaconnector.EditEntry(contentId, aef.Entry, false);
                    }
                    catch (DatabaseUpdateFailureException)
                    {
                        MessageBox.Show("There was an error updating the database!");
                    }

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
            
            AdEditorForm aef = new AdEditorForm(_igaconnector);
            aef.ShowDialog();

            if (aef.Success)
            {
                // success!
                try
                {
                    uint newcid = _igaconnector.NewEntry(aef.Entry);

                    MessageBox.Show("Record added successfully.  You should now import a DDS image for the ad.\r\n\r\nThe new record's contentId is " + newcid.ToString() + ".", "Ad Cache Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (DatabaseUpdateFailureException)
                {
                    MessageBox.Show("There was a problem trying to updating the cache file!");
                }

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
                uint contentId = UInt32.Parse(CacheEntryList.SelectedItems[0].SubItems[0].Text);
                if (MessageBox.Show("Are you sure you want to delete this ad?", "Ad Cache Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    // no was pressed, dropout
                    return;
                }

                try
                {
                    _igaconnector.DeleteEntry(contentId);
                }
                catch (Exception)
                {
                    MessageBox.Show("There was a problem deleting the selected entry from the database.\r\n\r\nPerhaps another program using the database has already deleted it?");
                }

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
            AdPack ap = new AdPack(_igaconnector.AppID);
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
            AdPackImportForm apif = new AdPackImportForm(_igaconnector, ap);
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
            AdPackExportForm apef = new AdPackExportForm(_igaconnector);
            apef.ShowDialog();
        }

        private void closeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseDatabase();
        }

        private void CloseDatabase()
        {
            _igaconnector = null;
            WelcomeGroup.Show();
            EditingGroup.Hide();
            refreshToolStripMenuItem.Enabled = false;
            importAdpackFilebfadsToolStripMenuItem.Enabled = false;
            exportAdpackFilebfadsToolStripMenuItem.Enabled = false;
            closeDatabaseToolStripMenuItem.Enabled = false;
            vacuumDatabaseToolStripMenuItem.Enabled = false;
            debugToolStripMenuItem.Enabled = false;
            ViewSwitchButton.Visible = false;
        }

        private void vacuumDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VacuumDatabase();
        }

        private void VacuumDatabase()
        {
            _igaconnector.VaccumDatabase();
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
                String oldwintitle = this.Text;
                this.Text = "Loading, please wait...";
                uint contentId = UInt32.Parse(CacheEntryList.SelectedItems[0].SubItems[0].Text);
                //MessageBox.Show("Selected item ID #" + contentId.ToString() + ".");
                //int adIndex = Common.cids.IndexOf(contentId);
                byte[] idata = _igaconnector.ExportImage(contentId);
                if (idata == null || idata.Length == 0)
                {
                    MessageBox.Show("There is no image in the data block, so there is nothing to see.");
                    this.Text = oldwintitle;
                    return;
                }
                if (Common.IsBIK(idata))
                {
                    MessageBox.Show("Sorry, cannot preview BINK video files.");
                    this.Text = oldwintitle;
                    return;
                }

                try
                {
                    PreviewBox.Image = LoadImagePreview(idata);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem trying to load the preview.  The message was: " + ex.GetType().Name + "-> " + ex.Message, "Ad Cache Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Text = oldwintitle;
                    return;
                }

                this.Text = oldwintitle;
                EditingGroup.Hide();
                menuStrip1.Hide();
                ImagePreviewGroup.Show();


            }
        }

        private Image LoadImagePreview(byte[] idata)
        {
            // .net is annoying so we have to seal the call to make it modular
            DDSReader.Ping();
            return DDSReader.LoadImage(idata);
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
                
                _igaconnector.AppID = oaf.AppID;
                if (oaf.SaveToDatabase)
                {
                    _igaconnector.ChangeAppID(oaf.AppID);
                }
                SetReadonlyRestrictions(_igaconnector.AppSupported);
                //RefreshList();
                MessageBox.Show("The operation was completed.");
            }
        }

        private void executeSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlInjectorForm sif = new SqlInjectorForm(_igaconnector.GetConnection());
            sif.ShowDialog();
            RefreshList();
        }

        private void PreviewBox_Click(object sender, EventArgs e)
        {
            ImagePreviewGroup.Hide();
            menuStrip1.Show();
            EditingGroup.Show();
            
        }

        private void theGIMPopenSourceImageEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.gimp.org/windows/");
        }

        private void nVidiaDDSPhotoshopPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://developer.nvidia.com/object/photoshop_dds_plugins.html");
        }

        private void nVidiaDDSWindowsExplorerThumbnailerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://developer.nvidia.com/object/dds_thumbnail_viewer.html");
        }

        private void theGIMPDDSPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://registry.gimp.org/plugin?id=4816");
        }

        private void aTIsCompressonatorDDSConverteradvancedUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://ati.amd.com/developer/compressonator.html");
        }

        private void rADVideoToolsforCreatingBINKVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.radgametools.com/bnkdown.htm");
        }

        private void subversionSourceCodeRepositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://sourceforge.net/svn/?group_id=181663");
        }

        private void theGodfathersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.pcgamingboards.com/smf/index.php?topic=129.msg279#msg279");
        }

        private void downloadPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://sourceforge.net/project/showfiles.php?group_id=181663");
        }

        private void wikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://igaeditor.sourceforge.net/wiki/");
        }

        private void ViewSwitchButton_Click(object sender, EventArgs e)
        {
            if (CacheEntryList.View == View.Details)
            {
                CacheEntryList.BeginUpdate();
                CacheEntryList.Visible = false;
                CacheEntryList.View = View.Tile;
                CacheEntryList.Columns.RemoveAt(1);
                CacheEntryList.Columns.RemoveAt(1);
                CacheEntryList.Columns.RemoveAt(1);
                CacheEntryList.Columns.RemoveAt(1);
                CacheEntryList.Columns.RemoveAt(1);
                CacheEntryList.Columns.RemoveAt(1);
                CacheEntryList.Columns.RemoveAt(1);
                CacheEntryList.Visible = true;
                CacheEntryList.EndUpdate();
            }
            else
            {
                CacheEntryList.BeginUpdate();
                CacheEntryList.Visible = false;
                CacheEntryList.View = View.Details;
                this.CacheEntryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            //this.contentId,
            this.active,
            this.activate,
            this.expire,
            this.dayparts,
            this.imageSize,
            this.isVideo,
            this.viewCount});
                //RefreshList();
                CacheEntryList.Visible = true;
                CacheEntryList.EndUpdate();

            }
        }
    }
}
