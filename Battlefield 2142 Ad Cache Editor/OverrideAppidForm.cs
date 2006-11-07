using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace au.id.micolous.apps.igaeditor
{
    /// <summary>
    /// This form allows a user to override the appid set in an icontent.cache
    /// file.
    /// </summary>
    partial class OverrideAppidForm : Form
    {
        private bool _success = false;
        private int _appid = 0;
        /// <summary>
        /// If this is true, then the user successfully completed the dialog.
        /// </summary>
        public bool Success { get { return _success; } }
        /// <summary>
        /// This is the new appid to set for the application.
        /// </summary>
        public int AppID { get { return _appid; } }
        /// <summary>
        /// If this is true, then the user desires for their icontent.cache file to
        /// be updated to use this application ID.
        /// </summary>
        public bool SaveToDatabase { get { return this.WriteAppIdToCacheCheckbox.Checked; } }

        public OverrideAppidForm()
        {
            InitializeComponent();
        }

        private void FormCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // derive appid
            if (AppIdSelectionCombo.SelectedItem != null)
            {
                String[] s = AppIdSelectionCombo.SelectedItem.ToString().Split(':');
                _appid = Int32.Parse(s[0]);
                _success = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Must have an application selected!");
            }
        }

        private void OverrideAppidForm_Load(object sender, EventArgs e)
        {
            // populate combo
            AppIdSelectionCombo.Items.Clear();
            foreach (KeyValuePair<int, AppInfo> kvpai in Common.AppInfos)
            {
                AppIdSelectionCombo.Items.Add(String.Format("{0}: {1}", kvpai.Value.AppID, kvpai.Value.AppName));
            }
        }
    }
}