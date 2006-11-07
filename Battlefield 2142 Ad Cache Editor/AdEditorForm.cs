using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace au.id.micolous.apps.igaeditor
{
    partial class AdEditorForm : Form
    {

        private bool _active;
        private int _activate;
        private int _expire;
        private int _dayparts;
        private int _contentType;
        private String _descriptor;
        private int _size = 0;
        private int _viewcount;
        private int _viewlimit;
        private int _displayafter;
        private bool _success = false;
        private SortedList<String, String> _props = new SortedList<string,string>();

        private String _propsS;

        public int VActive { get { if (_active) { return 1; } else { return 0; } } }
        public int VActivate { get { return _activate; } }
        public int VExpire { get { return _expire; } }
        public int VDayParts { get { return _dayparts; } }
        public int VContentType { get { return _contentType; } }
        public String VDescriptor { get { return _descriptor; } }
        public int VSize { get { return _size; } }
        public int VViewCount { get { return _viewcount; } }
        public int VViewLimit { get { return _viewlimit; } }
        public int VDisplayAfter { get { return _displayafter; } }
        public bool Success { get { return _success; } }
        public String VProps { get { return _propsS; } }

        public AdEditorForm() : this(null) {
        }

        public AdEditorForm(SQLiteDataReader row)
        {
            InitializeComponent();

            ActivationDatePicker.CustomFormat = Common.DateTimeFormat;
            ExpiryDatePicker.CustomFormat = Common.DateTimeFormat;

            // deserialize data row
            if (row != null)
            {
                // real row, pass to populator.
                PopulateEditor(row);
            }
            else
            {
                // not a row, pass to creator
                PopulateCreator();
            }

            DrawToForm();
        }

        private void PopulateEditor(SQLiteDataReader row)
        {
            _active = (row.GetInt32(1) >= 1);
            _activate = row.GetInt32(2);
            _expire = row.GetInt32(3);
            _dayparts = row.GetInt32(4);
            _contentType = row.GetInt32(5);
            _descriptor = row.GetString(6);
            _size = row.GetInt32(7);
            _viewcount = row.GetInt32(8);
            _viewlimit = row.GetInt32(9);
            _displayafter = row.GetInt32(10);
            String props = row.GetString(11);

            foreach (String prop in props.Split('&'))
            {
                if (prop.Length > 0)
                {
                    String[] pk = prop.Split('=');
                    _props.Add(pk[0], pk[1]);
                }
            }
        }


        /// <summary>
        /// Sets the form in a mode for creating a new ad.
        /// </summary>
        private void PopulateCreator()
        {
            _active = true;
            _activate = 
            _expire = 0;
            _contentType = 2021100;
            _dayparts = 16777215;
            _descriptor = (31).ToString() ;
            _viewcount = 0;
            _viewlimit = 0;
            _displayafter = 0;

            //zoneId=16&
            //userInfo=m18&
            //MinSize=4&
            //MaxSize=100&
            //Deflection=80&
            //MinTime=2000&
            _props.Add("zoneid", "16");
            _props.Add("userInfo", "m18");
            _props.Add("MinSize", "4");
            _props.Add("MaxSize", "100");
            _props.Add("Deflection", "80");

            if (Common.doesAppStoreMinTimeAsSecond(MainForm.AppID))
            {
                _props.Add("MinTime", "2");
            }
            else
            {
                _props.Add("MinTime", "2000");
            }
        }

        /// <summary>
        /// Clean up everything back into variables so we can take
        /// a nice big dump.
        /// </summary>
        private void FinishUpForSaving()
        {
            _active = ActiveCheckBox.Checked;
            _activate = (int)((TimeSpan)ActivationDatePicker.Value.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0))).TotalSeconds;
            if (ExpiryDatePicker.Checked == true)
            {
                _expire = (int)((TimeSpan)ExpiryDatePicker.Value.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, 0))).TotalSeconds;
            }
            else
            {
                _expire = 0;
            }
            _contentType = Common.ContentTypes[ImageSizeCombo.SelectedIndex];
            if (VideoAdCheckbox.Checked)
            {
                _contentType -= 100;
            }
            _viewcount = (int)ViewTimesSpinner.Value;
            if (MaxViewsCheckBox.Checked)
            {
                _viewlimit = (int)ViewMaxSpinner.Value;
            }
            else
            {
                _viewlimit = 0;
            }
            _props["MinTime"] = MinTimeSpinner.Value.ToString();
            char gender = 'm';
            if (GenderComboBox.SelectedIndex == 1)
            {
                gender = 'f';
            }
            _props["userInfo"] = gender.ToString() + AgeSpinner.Value.ToString();

            // random redundant stuffs
            _props["contentType"] = _contentType.ToString();
            _props["Activate"] = _activate.ToString();
            _props["Expire"] = _expire.ToString();
            _props["DayParts"] = _dayparts.ToString();
            _props["Size"] = _size.ToString();
            _props["PerUserLimit"] = _viewlimit.ToString();
            _props["DisplayAfter"] = _displayafter.ToString();
            _props["CellDiscriptors"] = _descriptor;
            _propsS = "";
            foreach (KeyValuePair<String, String> prop in _props)
            {
                _propsS = _propsS + prop.Key + "=" + prop.Value + "&";
            }
        }

        private void DrawToForm()
        {
            ActiveCheckBox.Checked = _active;

            if (_activate > 86400) // 1970-01-01
            {
                DateTime activate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                activate = activate.AddSeconds(_activate);
                //activate = activate.ToLocalTime();

                ActivationDatePicker.Value = activate;
            }
            else
            {
                _activate = 0;
                ActivationDatePicker.Value = DateTime.Now.ToUniversalTime();
            }


            if (_expire > 0)
            {
                DateTime expires = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                expires = expires.AddSeconds(_expire);
                //expires = expires.ToLocalTime();
                ExpiryDatePicker.Value = expires;
                ExpiryDatePicker.Checked = true;
            }
            else
            {
                ExpiryDatePicker.Value = DateTime.Now.ToUniversalTime();
                ExpiryDatePicker.Checked = false;
            }



            int contentCleaned = _contentType;
            if (_contentType % 10000 == 1000)
            {
                VideoAdCheckbox.Checked = true;
                contentCleaned += 100;
            }
            else
            {
                VideoAdCheckbox.Checked = false;
            }

            
            int impos = Array.IndexOf(Common.ContentTypes, contentCleaned);
            if (impos == -1)
            {
                MessageBox.Show(String.Format("Got an unknown contentType, {0}. You probably shouldn't edit this.", _contentType));
            }
            else
            {
                ImageSizeCombo.SelectedIndex = impos;
            }
            if (_dayparts != 0 && _dayparts != 16777215)
            {
                MessageBox.Show("dayparts gave a non-minimum and non-maximum value, so I don't know how to map the times yet.\r\n\r\nPlease send your icontent.cache file to micolous -at- gmail -dot- com with details, or check for a new version of this program at http://micolous.id.au/projects/bf2142/.  Thankyou!");
            }

            // got all-times
            if (_dayparts == 16777215)
            {
                for (int x = 1; x <= 7; x++)
                {
                    for (int y = 1; y <= 3; y++)
                    {
                        ((CheckBox)AdTimeTable.GetControlFromPosition(x, y)).Checked = true;
                    }
                }
            }

            ViewTimesSpinner.Value = _viewcount;
            ViewMaxSpinner.Value = _viewlimit;
            if (_viewlimit == 0)
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

            MinTimeSpinner.Value = Decimal.Parse(_props["MinTime"]);
            if (Common.doesAppStoreMinTimeAsSecond(MainForm.AppID))
            {
                MinViewTimeUnitLabel.Text = "sec";
            }

            if (_props["userInfo"][0].ToString().ToLowerInvariant() == "m")
            {
                // male
                GenderComboBox.SelectedIndex = 0;
            }
            else
            {
                // female
                GenderComboBox.SelectedIndex = 1;
            }
            AgeSpinner.Value = Decimal.Parse(_props["userInfo"].Substring(1));
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