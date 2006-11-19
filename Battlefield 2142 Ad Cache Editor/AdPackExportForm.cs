using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using au.id.micolous.libs.igacommon;

namespace au.id.micolous.apps.igaeditor
{
    /// <summary>
    /// This class defines an Export form for AdPacks.
    /// </summary>
    partial class AdPackExportForm : Form
    {
        private SortedList<uint, AdPackEntry> ads = new SortedList<uint, AdPackEntry>(100);
        private List<uint> adcontentids = new List<uint>(100);
        private int AppID;
        private SortedList<uint, ContentType> ContentTypes = new SortedList<uint,ContentType>();
        private IGADatabaseConnector conn;

        /// <summary>
        /// Creates a new AdPackExportForm.
        /// </summary>
        /// <param name="conn">The connection to get images from.</param>
        public AdPackExportForm(IGADatabaseConnector conn)
        {
            this.AppID = conn.AppID;

            foreach (KeyValuePair<uint, ContentEntry> item in conn.GetAllEntries(false))
            {
                ContentTypes.Add(item.Key, item.Value.contentType);
            }

            //this.ContentTypes = null;
            this.conn = conn;
            InitializeComponent();
        }

        private void AdPackExportForm_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<uint, ContentType> kvpctype in ContentTypes)
            {
                adcontentids.Add(kvpctype.Key);
                String extension = ".dds";
                if (kvpctype.Value.GetItemType() == ItemType.BinkVideo)
                {
                    extension = ".bik";
                }
                ads[kvpctype.Key] = new AdPackEntry(kvpctype.Key.ToString() + extension, kvpctype.Key.ToString(), kvpctype.Value);
            }
            RedrawControls();
        }

        private void RedrawControls()
        {
            SelectedAdsCheckListBox.Items.Clear();
            foreach (KeyValuePair<uint, AdPackEntry> ad in ads) {
                SelectedAdsCheckListBox.Items.Add(ad.Key.ToString());
            }
        }

        private void FormCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectedAdsCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdFilenameTextBox.Text = ads[adcontentids[SelectedAdsCheckListBox.SelectedIndex]].FileName;
            AdTitleTextBox.Text = ads[adcontentids[SelectedAdsCheckListBox.SelectedIndex]].Description;
        }

        private void AdFilenameTextBox_Leave(object sender, EventArgs e)
        {
            if (SelectedAdsCheckListBox.SelectedIndex >= 0)
            {
                AdFilenameTextBox.Text = AdFilenameTextBox.Text.Trim();
                if (AdFilenameTextBox.Text.Length > ".dds".Length && adcontentids[SelectedAdsCheckListBox.SelectedIndex] % 10000 != 1000)
                {
                    if (!AdFilenameTextBox.Text.EndsWith(".dds", StringComparison.InvariantCultureIgnoreCase))
                    {
                        // add .dds
                        AdFilenameTextBox.Text = AdFilenameTextBox.Text.Trim() + ".dds";
                    }
                }
                else if (AdFilenameTextBox.Text.Length > ".bik".Length)
                {
                    if (!AdFilenameTextBox.Text.EndsWith(".bik", StringComparison.InvariantCultureIgnoreCase))
                    {
                        // add .bik
                        AdFilenameTextBox.Text = AdFilenameTextBox.Text.Trim() + ".bik";
                    }
                }
                else
                {
                    AdFilenameTextBox.Text = adcontentids[SelectedAdsCheckListBox.SelectedIndex].ToString() + ".dds";
                }
            }
        }

        private void AdTitleTextBox_Leave(object sender, EventArgs e)
        {
            if (SelectedAdsCheckListBox.SelectedIndex >= 0)
            {
                AdTitleTextBox.Text = AdTitleTextBox.Text.Trim();
                if (AdTitleTextBox.Text.Length == 0)
                {
                    AdTitleTextBox.Text = adcontentids[SelectedAdsCheckListBox.SelectedIndex].ToString();
                }
            }
        }

        private void FormExportButton_Click(object sender, EventArgs e)
        {
            if (SelectedAdsCheckListBox.CheckedItems.Count > 0)
            {
                if (AuthorTextBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You must enter an author name.");
                    return;
                }

                if (TitleTextBox.Text.Trim().Length == 0)
                {
                    MessageBox.Show("You must enter a title.");
                    return;
                }

                if (DescriptionTextBox.Text.Trim().Length == 0)
                {
                    DescriptionTextBox.Text = "No description.";
                }

                if (ExportAdpackSaveDialogue.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                // there are items
                AdPack adpack = new AdPack(AppID);
                for (uint x = 0; x < SelectedAdsCheckListBox.CheckedItems.Count; x++)
                {
                    // iterate through selected items...
                    uint index = (uint)SelectedAdsCheckListBox.Items.IndexOf(SelectedAdsCheckListBox.CheckedItems[(int)x]);
                    
                    // grab data of image
                    byte[] ImageData = (conn.ExportImage(adcontentids[(int)index]));
                    if (ImageData.Length > 0)
                    {

                        // insert into system
                        AdPackEntry ape = ads[adcontentids[(int)index]];
                        ape.SetDDSData(ImageData);

                        adpack.Files.Add(ape.FileName, ape);
                    }
                    else
                    {
                        MessageBox.Show("Image #" + adcontentids[(int)index].ToString() + " (" + ads[index].FileName + ") cannot be exported as it has no data.");
                    }
                }
                adpack.Metadata["author"] = AuthorTextBox.Text.Trim();
                adpack.Metadata["title"] = TitleTextBox.Text.Trim();
                adpack.Metadata["description"] = DescriptionTextBox.Text.Trim();
                // all done, zip it up and finalize.
                FileStream fs;
                try
                {
                    fs = new FileStream(ExportAdpackSaveDialogue.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to open adpack file for writing.  The error was: " + ex.Message);
                    return;
                }

                adpack.Serialize(fs);

                this.Close();

            }
            else
            {
                MessageBox.Show("You haven't selected any items for export.");
            }
        }

        private void SaveAdButton_Click(object sender, EventArgs e)
        {
            if (SelectedAdsCheckListBox.SelectedIndex >= 0)
            {
                AdFilenameTextBox.Text = AdFilenameTextBox.Text.Trim();
                
                if (AdFilenameTextBox.Text.Length > ".dds".Length && adcontentids[SelectedAdsCheckListBox.SelectedIndex] % 10000 != 1000)
                {
                    if (!AdFilenameTextBox.Text.EndsWith(".dds", StringComparison.InvariantCultureIgnoreCase))
                    {
                        // add .dds
                        AdFilenameTextBox.Text = AdFilenameTextBox.Text.Trim() + ".dds";
                    }
                }
                else if (AdFilenameTextBox.Text.Length > ".bik".Length)
                {
                    if (!AdFilenameTextBox.Text.EndsWith(".bik", StringComparison.InvariantCultureIgnoreCase))
                    {
                        // add .bik
                        AdFilenameTextBox.Text = AdFilenameTextBox.Text.Trim() + ".bik";
                    }
                }
                else
                {
                    AdFilenameTextBox.Text = adcontentids[SelectedAdsCheckListBox.SelectedIndex].ToString() + ".dds";
                }

                // write back to list
                ads[adcontentids[SelectedAdsCheckListBox.SelectedIndex]].FileName = AdFilenameTextBox.Text;
            }

            if (SelectedAdsCheckListBox.SelectedIndex >= 0)
            {
                AdTitleTextBox.Text = AdTitleTextBox.Text.Trim();
                if (AdTitleTextBox.Text.Length == 0)
                {
                    AdTitleTextBox.Text = adcontentids[SelectedAdsCheckListBox.SelectedIndex].ToString();
                }
            }

            ads[adcontentids[SelectedAdsCheckListBox.SelectedIndex]].Description = AdTitleTextBox.Text;
        }
    }
}