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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverrideAppidForm));
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
            resources.ApplyResources(this.AppIdSelectionCombo, "AppIdSelectionCombo");
            this.AppIdSelectionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AppIdSelectionCombo.FormattingEnabled = true;
            this.AppIdSelectionCombo.Name = "AppIdSelectionCombo";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.AppIdSelectionCombo);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // WriteAppIdToCacheCheckbox
            // 
            resources.ApplyResources(this.WriteAppIdToCacheCheckbox, "WriteAppIdToCacheCheckbox");
            this.WriteAppIdToCacheCheckbox.Name = "WriteAppIdToCacheCheckbox";
            this.WriteAppIdToCacheCheckbox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FormCancelButton
            // 
            resources.ApplyResources(this.FormCancelButton, "FormCancelButton");
            this.FormCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FormCancelButton.Name = "FormCancelButton";
            this.FormCancelButton.UseVisualStyleBackColor = true;
            this.FormCancelButton.Click += new System.EventHandler(this.FormCancelButton_Click);
            // 
            // OverrideAppidForm
            // 
            this.AcceptButton = this.SaveButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.FormCancelButton;
            this.ControlBox = false;
            this.Controls.Add(this.FormCancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.WriteAppIdToCacheCheckbox);
            this.Controls.Add(this.groupBox1);
            this.Name = "OverrideAppidForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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