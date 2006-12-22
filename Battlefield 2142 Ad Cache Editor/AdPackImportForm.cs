using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using au.id.micolous.libs.igacommon;

namespace au.id.micolous.apps.igaeditor
{
    /// <summary>
    /// This class implements a form allowing you to import ads from a file.
    /// </summary>
    partial class AdPackImportForm : Form
    {
        private AdPack ads;
        private bool success = false;
        /// <summary>
        /// This is set to true if the dialogue's operation was accepted.
        /// </summary>
        public bool Success { get { return success; } }
        private SortedList<uint, ContentType> ContentTypes = new SortedList<uint,ContentType>();
        private IGADatabaseConnector conn;

        /// <summary>
        /// Creates a new AdParkImportForm
        /// </summary>
        /// <param name="conn">An IGADatabaseConnector object.</param>
        /// <param name="ads">An AdPack instance to import</param>
        public AdPackImportForm(IGADatabaseConnector conn, AdPack ads)
        {
            this.ads = ads;
            foreach (KeyValuePair<uint, ContentEntry> item in conn.GetAllEntries(false))
            {
                ContentTypes.Add(item.Key, item.Value.contentType);
            }
            this.conn = conn;
            InitializeComponent();
        }

        private void AdPackImportForm_Load(object sender, EventArgs e)
        {
            AuthorTextBox.Text = ads.Metadata["author"];
            TitleTextBox.Text = ads.Metadata["title"];
            DescriptionTextBox.Text = ads.Metadata["description"];

            foreach (KeyValuePair<String, AdPackEntry> kvpape in ads.Files)
            {
                Label title = new Label();
                title.Text = kvpape.Value.FileName;
                title.Dock = DockStyle.Fill;
                Label desc = new Label();
                desc.Text = kvpape.Value.Description;
                desc.Dock = DockStyle.Fill;
                ComboBox assign = new ComboBox();
                assign.Items.Add("<New Record>");
                assign.Items.Add("<Unassigned>");
                foreach (KeyValuePair<uint, ContentType> cidctype in ContentTypes)
                {
                    if (cidctype.Value.Equals(kvpape.Value.ContentType))
                    {
                        assign.Items.Add(cidctype.Key.ToString());
                    }
                }
                assign.Dock = DockStyle.Fill;
                assign.DropDownStyle = ComboBoxStyle.DropDownList;
                assign.SelectedIndex = 0;

                EntryTable.Controls.Add(title);
                EntryTable.Controls.Add(desc);
                EntryTable.Controls.Add(assign);
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinishUp();
        }

        private void FinishUp()
        {
            int errorCount = 0;
            for (int x = 1; x < EntryTable.Controls.Count / 3; x++)
            {
                // iterate through row table
                ComboBox scbo = (ComboBox)EntryTable.GetControlFromPosition(2, x);
                AdPackEntry ad = ads.Files[((Label)EntryTable.GetControlFromPosition(0, x)).Text];

                switch (scbo.SelectedIndex) {
                    case 0: // new entry
                        try
                        {
                            conn.NewEntry(ad);
                        }
                        catch (DatabaseUpdateFailureException)
                        {
                            errorCount++;
                        }
                        break;
                    case 1: // ignore
                        break;
                    default: // ressign at
                        try
                        {
                            conn.ImportImage(UInt32.Parse(scbo.Text), ad);
                        }
                        catch (DatabaseUpdateFailureException)
                        {
                            errorCount++;
                        }
                        break;
                }
            }

            if (errorCount > 0)
            {
                MessageBox.Show(String.Format("There were some problems trying to update the cache file.  {0} entries may not be inserted as a result.", errorCount));
            }
            success = true;
            this.Close();
        }

        private void AdPackImportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!success)
            {
                if (MessageBox.Show("Are you sure you want to cancel the import?", "Ad Cache Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

    }
}