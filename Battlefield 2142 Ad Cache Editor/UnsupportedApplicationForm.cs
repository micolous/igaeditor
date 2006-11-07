using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace au.id.micolous.apps.igaeditor
{
    partial class UnsupportedApplicationForm : Form
    {
        private int appID;

        public UnsupportedApplicationForm(int appID)
        {
            this.appID = appID;
            InitializeComponent();
        }

        private void UnsupportedApplicationForm_Load(object sender, EventArgs e)
        {
            MessageTextBox.Text = MessageTextBox.Text.Replace("$VER$", Application.ProductVersion).Replace("$AppID$", this.appID.ToString());

        }
    }
}