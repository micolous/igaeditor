namespace au.id.micolous.apps.igaeditor
{
    partial class AdPackExportForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AdTitleTextBox = new System.Windows.Forms.TextBox();
            this.AdFilenameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedAdsCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.FormCancelButton = new System.Windows.Forms.Button();
            this.FormExportButton = new System.Windows.Forms.Button();
            this.ExportAdpackSaveDialogue = new System.Windows.Forms.SaveFileDialog();
            this.SaveAdButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescriptionTextBox);
            this.groupBox1.Controls.Add(this.AuthorTextBox);
            this.groupBox1.Controls.Add(this.TitleTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metadata";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.AcceptsReturn = true;
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(72, 60);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(360, 56);
            this.DescriptionTextBox.TabIndex = 14;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthorTextBox.Location = new System.Drawing.Point(72, 36);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(360, 20);
            this.AuthorTextBox.TabIndex = 13;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(72, 12);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(360, 20);
            this.TitleTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SaveAdButton);
            this.groupBox2.Controls.Add(this.AdTitleTextBox);
            this.groupBox2.Controls.Add(this.AdFilenameTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.SelectedAdsCheckListBox);
            this.groupBox2.Location = new System.Drawing.Point(0, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ads to Export";
            // 
            // AdTitleTextBox
            // 
            this.AdTitleTextBox.Location = new System.Drawing.Point(64, 120);
            this.AdTitleTextBox.Name = "AdTitleTextBox";
            this.AdTitleTextBox.Size = new System.Drawing.Size(312, 20);
            this.AdTitleTextBox.TabIndex = 4;
            this.AdTitleTextBox.Leave += new System.EventHandler(this.AdTitleTextBox_Leave);
            // 
            // AdFilenameTextBox
            // 
            this.AdFilenameTextBox.Location = new System.Drawing.Point(64, 96);
            this.AdFilenameTextBox.Name = "AdFilenameTextBox";
            this.AdFilenameTextBox.Size = new System.Drawing.Size(312, 20);
            this.AdFilenameTextBox.TabIndex = 3;
            this.AdFilenameTextBox.Leave += new System.EventHandler(this.AdFilenameTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filename";
            // 
            // SelectedAdsCheckListBox
            // 
            this.SelectedAdsCheckListBox.FormattingEnabled = true;
            this.SelectedAdsCheckListBox.Location = new System.Drawing.Point(8, 16);
            this.SelectedAdsCheckListBox.Name = "SelectedAdsCheckListBox";
            this.SelectedAdsCheckListBox.Size = new System.Drawing.Size(424, 79);
            this.SelectedAdsCheckListBox.TabIndex = 0;
            this.SelectedAdsCheckListBox.SelectedIndexChanged += new System.EventHandler(this.SelectedAdsCheckListBox_SelectedIndexChanged);
            // 
            // FormCancelButton
            // 
            this.FormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FormCancelButton.Location = new System.Drawing.Point(368, 264);
            this.FormCancelButton.Name = "FormCancelButton";
            this.FormCancelButton.Size = new System.Drawing.Size(75, 23);
            this.FormCancelButton.TabIndex = 2;
            this.FormCancelButton.Text = "Cancel";
            this.FormCancelButton.UseVisualStyleBackColor = true;
            this.FormCancelButton.Click += new System.EventHandler(this.FormCancelButton_Click);
            // 
            // FormExportButton
            // 
            this.FormExportButton.Location = new System.Drawing.Point(288, 264);
            this.FormExportButton.Name = "FormExportButton";
            this.FormExportButton.Size = new System.Drawing.Size(75, 23);
            this.FormExportButton.TabIndex = 3;
            this.FormExportButton.Text = "Export...";
            this.FormExportButton.UseVisualStyleBackColor = true;
            this.FormExportButton.Click += new System.EventHandler(this.FormExportButton_Click);
            // 
            // ExportAdpackSaveDialogue
            // 
            this.ExportAdpackSaveDialogue.DefaultExt = "adpack";
            this.ExportAdpackSaveDialogue.Filter = "Adpack Files|*.adpack";
            // 
            // SaveAdButton
            // 
            this.SaveAdButton.Location = new System.Drawing.Point(376, 96);
            this.SaveAdButton.Name = "SaveAdButton";
            this.SaveAdButton.Size = new System.Drawing.Size(56, 40);
            this.SaveAdButton.TabIndex = 5;
            this.SaveAdButton.Text = "Save";
            this.SaveAdButton.UseVisualStyleBackColor = true;
            this.SaveAdButton.Click += new System.EventHandler(this.SaveAdButton_Click);
            // 
            // AdPackExportForm
            // 
            this.AcceptButton = this.FormExportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.FormCancelButton;
            this.ClientSize = new System.Drawing.Size(443, 288);
            this.Controls.Add(this.FormExportButton);
            this.Controls.Add(this.FormCancelButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "AdPackExportForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Export Ads";
            this.Load += new System.EventHandler(this.AdPackExportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox AdTitleTextBox;
        private System.Windows.Forms.TextBox AdFilenameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox SelectedAdsCheckListBox;
        private System.Windows.Forms.Button FormCancelButton;
        private System.Windows.Forms.Button FormExportButton;
        private System.Windows.Forms.SaveFileDialog ExportAdpackSaveDialogue;
        private System.Windows.Forms.Button SaveAdButton;
    }
}