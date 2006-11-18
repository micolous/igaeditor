namespace au.id.micolous.apps.igaeditor
{
    partial class SqlInjectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlInjectorForm));
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.AcceptsReturn = true;
            this.QueryTextBox.AcceptsTab = true;
            resources.ApplyResources(this.QueryTextBox, "QueryTextBox");
            this.QueryTextBox.Name = "QueryTextBox";
            // 
            // ExecuteButton
            // 
            resources.ApplyResources(this.ExecuteButton, "ExecuteButton");
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ResultTextbox
            // 
            resources.ApplyResources(this.ResultTextbox, "ResultTextbox");
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.ReadOnly = true;
            // 
            // SqlInjectorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ResultTextbox);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.QueryTextBox);
            this.MinimizeBox = false;
            this.Name = "SqlInjectorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.TextBox ResultTextbox;

    }
}