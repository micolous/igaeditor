namespace au.id.micolous.apps.igaeditor
{
    partial class OverrideAppidForm
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
            this.AppIdSelectionCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WriteAppIdToCacheCheckbox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FormCancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppIdSelectionCombo
            // 
            this.AppIdSelectionCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppIdSelectionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppIdSelectionCombo.FormattingEnabled = true;
            this.AppIdSelectionCombo.Location = new System.Drawing.Point(3, 16);
            this.AppIdSelectionCombo.Name = "AppIdSelectionCombo";
            this.AppIdSelectionCombo.Size = new System.Drawing.Size(494, 21);
            this.AppIdSelectionCombo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AppIdSelectionCombo);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 40);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New AppID";
            // 
            // WriteAppIdToCacheCheckbox
            // 
            this.WriteAppIdToCacheCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.WriteAppIdToCacheCheckbox.AutoSize = true;
            this.WriteAppIdToCacheCheckbox.Location = new System.Drawing.Point(0, 43);
            this.WriteAppIdToCacheCheckbox.Name = "WriteAppIdToCacheCheckbox";
            this.WriteAppIdToCacheCheckbox.Size = new System.Drawing.Size(245, 17);
            this.WriteAppIdToCacheCheckbox.TabIndex = 2;
            this.WriteAppIdToCacheCheckbox.Text = "Write this AppID to the cache file permanently.";
            this.WriteAppIdToCacheCheckbox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(339, 40);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "OK";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FormCancelButton
            // 
            this.FormCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FormCancelButton.Location = new System.Drawing.Point(419, 40);
            this.FormCancelButton.Name = "FormCancelButton";
            this.FormCancelButton.Size = new System.Drawing.Size(75, 23);
            this.FormCancelButton.TabIndex = 4;
            this.FormCancelButton.Text = "Cancel";
            this.FormCancelButton.UseVisualStyleBackColor = true;
            this.FormCancelButton.Click += new System.EventHandler(this.FormCancelButton_Click);
            // 
            // OverrideAppidForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.FormCancelButton;
            this.ClientSize = new System.Drawing.Size(500, 65);
            this.ControlBox = false;
            this.Controls.Add(this.FormCancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.WriteAppIdToCacheCheckbox);
            this.Controls.Add(this.groupBox1);
            this.Name = "OverrideAppidForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AppID Manual Override";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OverrideAppidForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AppIdSelectionCombo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox WriteAppIdToCacheCheckbox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button FormCancelButton;
    }
}