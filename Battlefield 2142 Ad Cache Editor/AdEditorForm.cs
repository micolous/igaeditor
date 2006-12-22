using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.Data.SQLite;
using au.id.micolous.libs.igacommon;

namespace au.id.micolous.apps.igaeditor
{
    partial class AdEditorForm : Form
    {

        private ContentEntry _entry;
        private bool _success = false;
        public bool Success { get { return _success; } }
        //private SortedList<String, String> _props = new SortedList<string,string>();

        //private String _propsS;

        private IGADatabaseConnector _conn;
        public ContentEntry Entry { get { return _entry; } }
        private bool unsupportedImageSize = false;
        

        public AdEditorForm(IGADatabaseConnector conn) : this(conn, new ContentEntry()) {
        }

        public AdEditorForm(IGADatabaseConnector conn, ContentEntry entry)
        {
            InitializeComponent();
            this._conn = conn;

            ActivationDatePicker.CustomFormat = Common.DateTimeFormat;
            ExpiryDatePicker.CustomFormat = Common.DateTimeFormat;

            // deserialize data row
            if (entry != null)
            {
                // real row
                _entry = entry;
            }
            else
            {
                _entry = new ContentEntry();

                // work around limitation of the library
                if (_conn.MinTimeStoredInSeconds)
                {
                    _entry.Properties["MinTime"] = "2";
                }
            }

            DrawToForm();
        }

        /// <summary>
        /// Clean up everything back into variables so we can take
        /// a nice big dump.
        /// </summary>
        private void FinishUpForSaving()
        {
            _entry.Active = ActiveCheckBox.Checked;
            _entry.Activate = ActivationDatePicker.Value;
            _entry.Expires = ExpiryDatePicker.Checked;
            if (_entry.Expires)
            {
                _entry.Expiry = ExpiryDatePicker.Value;
            }
            else
            {
                _entry.Expiry = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            }

            if (!this.unsupportedImageSize)
            {
                String[] imagesizearr = ((String)ImageSizeCombo.SelectedItem).Split('x');
                ItemType it = ItemType.DDSImage;
                if (VideoAdCheckbox.Checked)
                {
                    it = ItemType.BinkVideo;
                }
                _entry.contentType = new ContentType(new Size(Int32.Parse(imagesizearr[0]), Int32.Parse(imagesizearr[1])), it);
            }

            _entry.ViewCount = (uint)ViewTimesSpinner.Value;

            if (MaxViewsCheckBox.Checked)
            {
                _entry.ViewLimit = (uint)ViewMaxSpinner.Value;
            }
            else
            {
                _entry.ViewLimit = 0;
            }

            _entry.Properties["MinTime"] = MinTimeSpinner.Value.ToString();
            char gender = 'm';
            if (GenderComboBox.SelectedIndex == 1)
            {
                gender = 'f';
            }
            _entry.Properties["userInfo"] = gender.ToString() + AgeSpinner.Value.ToString();

            // random redundant stuffs
            _entry.Sync();
        }

        private void DrawToForm()
        {
            ActiveCheckBox.Checked = _entry.Active;

            if (_entry.Activate.CompareTo(new DateTime(1970,1,1,0,0,0)) > 0) // 1970-01-01
            {
                ActivationDatePicker.Value = _entry.Activate;
            }
            else
            {
                //_activate = 0;
                ActivationDatePicker.Value = DateTime.Now.ToUniversalTime();
            }


            if (_entry.Expires)
            {
                ExpiryDatePicker.Value = _entry.Expiry;
                ExpiryDatePicker.Checked = true;
            }
            else
            {
                ExpiryDatePicker.Value = DateTime.Now.ToUniversalTime();
                ExpiryDatePicker.Checked = false;
            }


            VideoAdCheckbox.Checked = (_entry.contentType.GetItemType() == ItemType.BinkVideo);
            try
            {
                Size isize = _entry.contentType.GetSize();
                ImageSizeCombo.SelectedIndex = ImageSizeCombo.Items.IndexOf(isize.Width.ToString() + "x" + isize.Height.ToString());
            }
            catch (UnsupportedImageSizeException)
            {
                MessageBox.Show(String.Format("Got an unknown contentType, {0}. You probably shouldn't edit this.", _entry.contentType.contentType));
                ImageSizeCombo.Enabled = false;
                VideoAdCheckbox.Enabled = false;
                this.unsupportedImageSize = true;

            }

            if (_entry.DayParts != 0 && _entry.DayParts != 16777215)
            {
                MessageBox.Show("dayparts gave a non-minimum and non-maximum value, so I don't know how to map the times yet.\r\n\r\nPlease send your icontent.cache file to micolous -at- gmail -dot- com with details, or check for a new version of this program at http://micolous.id.au/projects/bf2142/.  Thankyou!");
            }

            // got all-times
            if (_entry.DayParts == 16777215)
            {
                for (int x = 1; x <= 7; x++)
                {
                    for (int y = 1; y <= 3; y++)
                    {
                        ((CheckBox)AdTimeTable.GetControlFromPosition(x, y)).Checked = true;
                    }
                }
            }

            ViewTimesSpinner.Value = _entry.ViewCount;
            ViewMaxSpinner.Value = _entry.ViewLimit;
            if (_entry.ViewLimit == 0)
            {
                // unlimited
                ViewMaxSpinner.Visible = false;
                ViewMaxLabel.Visible = false;
                MaxViewsCheckBox.Checked = false;
            }
            else
            {
                MaxViewsCheckBox.Checked = true;
                ViewMaxSpinner.Visible = true;
                ViewMaxLabel.Visible = true;
            }

            MinTimeSpinner.Value = Decimal.Parse(_entry.Properties["MinTime"]);
            if (_conn.MinTimeStoredInSeconds)
            {
                MinViewTimeUnitLabel.Text = "sec";
            }

            if (_entry.Properties["userInfo"][0].ToString().ToLowerInvariant() == "m")
            {
                // male
                GenderComboBox.SelectedIndex = 0;
            }
            else
            {
                // female
                GenderComboBox.SelectedIndex = 1;
            }
            AgeSpinner.Value = Decimal.Parse(_entry.Properties["userInfo"].Substring(1));
        }

        private void AllTimesSelectButton_Click(object sender, EventArgs e)
        {
            bool state = !((CheckBox)AdTimeTable.GetControlFromPosition(1, 1)).Checked;
            for (int x = 1; x <= 7; x++)
            {
                for (int y = 1; y <= 3; y++)
                {
                    ((CheckBox)AdTimeTable.GetControlFromPosition(x, y)).Checked = state;
                }
            }
        }

        private void MorningSelectButton_Click(object sender, EventArgs e)
        {
            SetRowState(1);
        }

        private void SetRowState(int row)
        {
            bool state = !((CheckBox)AdTimeTable.GetControlFromPosition(1, row)).Checked;
            for (int x = 1; x <= 7; x++)
            {
                ((CheckBox)AdTimeTable.GetControlFromPosition(x, row)).Checked = state;
            }
        }
        private void SetColumnState(int column)
        {
            bool state = !((CheckBox)AdTimeTable.GetControlFromPosition(column, 1)).Checked;
            for (int y = 1;y <= 3; y++)
            {
                ((CheckBox)AdTimeTable.GetControlFromPosition(column, y)).Checked = state;
            }
        }

        private void AfternoonSelectButton_Click(object sender, EventArgs e)
        {
            SetRowState(2);
        }

        private void NightSelectButton_Click(object sender, EventArgs e)
        {
            SetRowState(3);
        }

        private void MondaySelectButton_Click(object sender, EventArgs e)
        {
            SetColumnState(1);
        }

        private void TuesdaySelectButton_Click(object sender, EventArgs e)
        {
            SetColumnState(2);
        }

        private void WednesdaySelectButton_Click(object sender, EventArgs e)
        {
            SetColumnState(3);
        }

        private void ThursdaySelectButton_Click(object sender, EventArgs e)
        {
            SetColumnState(4);
        }

        private void FridaySelectButton_Click(object sender, EventArgs e)
        {
            SetColumnState(5);
        }

        private void SaturdaySelectButton_Click(object sender, EventArgs e)
        {
            SetColumnState(6);
        }

        private void SundaySelectButton_Click(object sender, EventArgs e)
        {
            SetColumnState(7);
        }

        private void MaxViewsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ViewMaxLabel.Visible = MaxViewsCheckBox.Checked;
            ViewMaxSpinner.Visible = MaxViewsCheckBox.Checked;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "Ad Cache Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                // user really wants to cancel
                _success = false;
                this.Close();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _success = true;
            FinishUpForSaving();
            this.Close();
        }
    }
}