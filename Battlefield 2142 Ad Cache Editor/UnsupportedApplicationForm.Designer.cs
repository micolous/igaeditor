namespace au.id.micolous.apps.igaeditor
{
    partial class UnsupportedApplicationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnsupportedApplicationForm));
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageTextBox.Location = new System.Drawing.Point(0, 0);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.ReadOnly = true;
            this.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageTextBox.Size = new System.Drawing.Size(530, 294);
            this.MessageTextBox.TabIndex = 0;
            this.MessageTextBox.Text = resources.GetString("MessageTextBox.Text");
            // 
            // UnsupportedApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 294);
            this.Controls.Add(this.MessageTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnsupportedApplicationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Warning!";
            this.Load += new System.EventHandler(this.UnsupportedApplicationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageTextBox;
    }
}