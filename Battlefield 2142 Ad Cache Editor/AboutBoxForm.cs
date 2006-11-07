using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace au.id.micolous.apps.igaeditor
{
    partial class AboutBoxForm : Form
    {
        public AboutBoxForm()
        {
            InitializeComponent();
        }

        private void AboutBoxForm_Load(object sender, EventArgs e)
        {
            VersionLabel.Text = Application.ProductVersion;
            textBox1.Select(0, 0);
        }
    }
}