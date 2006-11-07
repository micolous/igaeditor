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
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.AcceptsReturn = true;
            this.QueryTextBox.AcceptsTab = true;
            this.QueryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryTextBox.Location = new System.Drawing.Point(0, 0);
            this.QueryTextBox.Multiline = true;
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(432, 64);
            this.QueryTextBox.TabIndex = 1;
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteButton.Location = new System.Drawing.Point(432, 0);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(80, 64);
            this.ExecuteButton.TabIndex = 2;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTextbox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextbox.Location = new System.Drawing.Point(0, 64);
            this.ResultTextbox.Multiline = true;
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.ReadOnly = true;
            this.ResultTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextbox.Size = new System.Drawing.Size(512, 248);
            this.ResultTextbox.TabIndex = 4;
            // 
            // SqlInjectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 310);
            this.Controls.Add(this.ResultTextbox);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.QueryTextBox);
            this.MinimizeBox = false;
            this.Name = "SqlInjectorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Execute SQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.TextBox ResultTextbox;

    }
}