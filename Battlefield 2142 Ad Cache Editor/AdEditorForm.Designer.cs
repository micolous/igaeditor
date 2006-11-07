namespace au.id.micolous.apps.igaeditor
{
    partial class AdEditorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdEditorForm));
            this.ActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.ActivationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ExpiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AdTimeTable = new System.Windows.Forms.TableLayoutPanel();
            this.SuNCheckBox = new System.Windows.Forms.CheckBox();
            this.SaNCheckBox = new System.Windows.Forms.CheckBox();
            this.FrNCheckBox = new System.Windows.Forms.CheckBox();
            this.ThNCheckBox = new System.Windows.Forms.CheckBox();
            this.WeNCheckBox = new System.Windows.Forms.CheckBox();
            this.TuNCheckBox = new System.Windows.Forms.CheckBox();
            this.MoNCheckBox = new System.Windows.Forms.CheckBox();
            this.SuACheckBox = new System.Windows.Forms.CheckBox();
            this.SaACheckBox = new System.Windows.Forms.CheckBox();
            this.FrACheckBox = new System.Windows.Forms.CheckBox();
            this.ThACheckBox = new System.Windows.Forms.CheckBox();
            this.WeACheckBox = new System.Windows.Forms.CheckBox();
            this.TuACheckBox = new System.Windows.Forms.CheckBox();
            this.MoACheckBox = new System.Windows.Forms.CheckBox();
            this.SuMCheckBox = new System.Windows.Forms.CheckBox();
            this.SaMCheckBox = new System.Windows.Forms.CheckBox();
            this.FrMCheckBox = new System.Windows.Forms.CheckBox();
            this.ThMCheckBox = new System.Windows.Forms.CheckBox();
            this.WeMCheckBox = new System.Windows.Forms.CheckBox();
            this.TuMCheckBox = new System.Windows.Forms.CheckBox();
            this.MoMCheckBox = new System.Windows.Forms.CheckBox();
            this.MondaySelectButton = new System.Windows.Forms.Button();
            this.TuesdaySelectButton = new System.Windows.Forms.Button();
            this.WednesdaySelectButton = new System.Windows.Forms.Button();
            this.ThursdaySelectButton = new System.Windows.Forms.Button();
            this.FridaySelectButton = new System.Windows.Forms.Button();
            this.SaturdaySelectButton = new System.Windows.Forms.Button();
            this.SundaySelectButton = new System.Windows.Forms.Button();
            this.MorningSelectButton = new System.Windows.Forms.Button();
            this.AfternoonSelectButton = new System.Windows.Forms.Button();
            this.NightSelectButton = new System.Windows.Forms.Button();
            this.AllTimesSelectButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ImageSizeCombo = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ViewMaxSpinner = new System.Windows.Forms.NumericUpDown();
            this.ViewMaxLabel = new System.Windows.Forms.Label();
            this.MaxViewsCheckBox = new System.Windows.Forms.CheckBox();
            this.ViewTimesSpinner = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.MinViewTimeUnitLabel = new System.Windows.Forms.Label();
            this.MinTimeSpinner = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.HintTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.VideoAdCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.AgeSpinner = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelActionButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.AdTimeTable.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMaxSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewTimesSpinner)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinTimeSpinner)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // ActiveCheckBox
            // 
            this.ActiveCheckBox.AutoSize = true;
            this.ActiveCheckBox.Location = new System.Drawing.Point(8, 0);
            this.ActiveCheckBox.Name = "ActiveCheckBox";
            this.ActiveCheckBox.Size = new System.Drawing.Size(87, 17);
            this.ActiveCheckBox.TabIndex = 0;
            this.ActiveCheckBox.Text = "Activate Ad?";
            this.HintTooltip.SetToolTip(this.ActiveCheckBox, "Is the ad activated?");
            this.ActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ActivationDatePicker
            // 
            this.ActivationDatePicker.CustomFormat = "";
            this.ActivationDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActivationDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ActivationDatePicker.Location = new System.Drawing.Point(3, 16);
            this.ActivationDatePicker.MaxDate = new System.DateTime(2038, 1, 1, 0, 0, 0, 0);
            this.ActivationDatePicker.MinDate = new System.DateTime(1970, 1, 2, 0, 0, 0, 0);
            this.ActivationDatePicker.Name = "ActivationDatePicker";
            this.ActivationDatePicker.Size = new System.Drawing.Size(362, 20);
            this.ActivationDatePicker.TabIndex = 1;
            this.HintTooltip.SetToolTip(this.ActivationDatePicker, "Use this to set when the ad should be activated.  The time stated is using the Co" +
                    "ordinated Universal Time (UTC).");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ActivationDatePicker);
            this.groupBox1.Location = new System.Drawing.Point(0, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 40);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ad Activation Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ExpiryDatePicker);
            this.groupBox2.Location = new System.Drawing.Point(0, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 40);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ad Expiry Date";
            // 
            // ExpiryDatePicker
            // 
            this.ExpiryDatePicker.Checked = false;
            this.ExpiryDatePicker.CustomFormat = "";
            this.ExpiryDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpiryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpiryDatePicker.Location = new System.Drawing.Point(3, 16);
            this.ExpiryDatePicker.MaxDate = new System.DateTime(2038, 1, 1, 0, 0, 0, 0);
            this.ExpiryDatePicker.MinDate = new System.DateTime(1970, 1, 2, 0, 0, 0, 0);
            this.ExpiryDatePicker.Name = "ExpiryDatePicker";
            this.ExpiryDatePicker.ShowCheckBox = true;
            this.ExpiryDatePicker.Size = new System.Drawing.Size(362, 20);
            this.ExpiryDatePicker.TabIndex = 1;
            this.HintTooltip.SetToolTip(this.ExpiryDatePicker, "Enable the checkbox to be able to set an expiry date for the ad.\r\nUncheck the che" +
                    "ckbox to make the ad never expire.\r\nThe time stated is in Coordinated Universal " +
                    "Time.");
            // 
            // AdTimeTable
            // 
            this.AdTimeTable.ColumnCount = 8;
            this.AdTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AdTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AdTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AdTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AdTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AdTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AdTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AdTimeTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AdTimeTable.Controls.Add(this.SuNCheckBox, 7, 3);
            this.AdTimeTable.Controls.Add(this.SaNCheckBox, 6, 3);
            this.AdTimeTable.Controls.Add(this.FrNCheckBox, 5, 3);
            this.AdTimeTable.Controls.Add(this.ThNCheckBox, 4, 3);
            this.AdTimeTable.Controls.Add(this.WeNCheckBox, 3, 3);
            this.AdTimeTable.Controls.Add(this.TuNCheckBox, 2, 3);
            this.AdTimeTable.Controls.Add(this.MoNCheckBox, 1, 3);
            this.AdTimeTable.Controls.Add(this.SuACheckBox, 7, 2);
            this.AdTimeTable.Controls.Add(this.SaACheckBox, 6, 2);
            this.AdTimeTable.Controls.Add(this.FrACheckBox, 5, 2);
            this.AdTimeTable.Controls.Add(this.ThACheckBox, 4, 2);
            this.AdTimeTable.Controls.Add(this.WeACheckBox, 3, 2);
            this.AdTimeTable.Controls.Add(this.TuACheckBox, 2, 2);
            this.AdTimeTable.Controls.Add(this.MoACheckBox, 1, 2);
            this.AdTimeTable.Controls.Add(this.SuMCheckBox, 7, 1);
            this.AdTimeTable.Controls.Add(this.SaMCheckBox, 6, 1);
            this.AdTimeTable.Controls.Add(this.FrMCheckBox, 5, 1);
            this.AdTimeTable.Controls.Add(this.ThMCheckBox, 4, 1);
            this.AdTimeTable.Controls.Add(this.WeMCheckBox, 3, 1);
            this.AdTimeTable.Controls.Add(this.TuMCheckBox, 2, 1);
            this.AdTimeTable.Controls.Add(this.MoMCheckBox, 1, 1);
            this.AdTimeTable.Controls.Add(this.MondaySelectButton, 1, 0);
            this.AdTimeTable.Controls.Add(this.TuesdaySelectButton, 2, 0);
            this.AdTimeTable.Controls.Add(this.WednesdaySelectButton, 3, 0);
            this.AdTimeTable.Controls.Add(this.ThursdaySelectButton, 4, 0);
            this.AdTimeTable.Controls.Add(this.FridaySelectButton, 5, 0);
            this.AdTimeTable.Controls.Add(this.SaturdaySelectButton, 6, 0);
            this.AdTimeTable.Controls.Add(this.SundaySelectButton, 7, 0);
            this.AdTimeTable.Controls.Add(this.MorningSelectButton, 0, 1);
            this.AdTimeTable.Controls.Add(this.AfternoonSelectButton, 0, 2);
            this.AdTimeTable.Controls.Add(this.NightSelectButton, 0, 3);
            this.AdTimeTable.Controls.Add(this.AllTimesSelectButton, 0, 0);
            this.AdTimeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdTimeTable.Location = new System.Drawing.Point(3, 16);
            this.AdTimeTable.Name = "AdTimeTable";
            this.AdTimeTable.RowCount = 4;
            this.AdTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AdTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AdTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AdTimeTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AdTimeTable.Size = new System.Drawing.Size(362, 117);
            this.AdTimeTable.TabIndex = 4;
            // 
            // SuNCheckBox
            // 
            this.SuNCheckBox.AutoSize = true;
            this.SuNCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SuNCheckBox.Location = new System.Drawing.Point(326, 90);
            this.SuNCheckBox.Name = "SuNCheckBox";
            this.SuNCheckBox.Size = new System.Drawing.Size(15, 24);
            this.SuNCheckBox.TabIndex = 31;
            this.SuNCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaNCheckBox
            // 
            this.SaNCheckBox.AutoSize = true;
            this.SaNCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaNCheckBox.Location = new System.Drawing.Point(286, 90);
            this.SaNCheckBox.Name = "SaNCheckBox";
            this.SaNCheckBox.Size = new System.Drawing.Size(15, 24);
            this.SaNCheckBox.TabIndex = 30;
            this.SaNCheckBox.UseVisualStyleBackColor = true;
            // 
            // FrNCheckBox
            // 
            this.FrNCheckBox.AutoSize = true;
            this.FrNCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FrNCheckBox.Location = new System.Drawing.Point(246, 90);
            this.FrNCheckBox.Name = "FrNCheckBox";
            this.FrNCheckBox.Size = new System.Drawing.Size(15, 24);
            this.FrNCheckBox.TabIndex = 29;
            this.FrNCheckBox.UseVisualStyleBackColor = true;
            // 
            // ThNCheckBox
            // 
            this.ThNCheckBox.AutoSize = true;
            this.ThNCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ThNCheckBox.Location = new System.Drawing.Point(206, 90);
            this.ThNCheckBox.Name = "ThNCheckBox";
            this.ThNCheckBox.Size = new System.Drawing.Size(15, 24);
            this.ThNCheckBox.TabIndex = 28;
            this.ThNCheckBox.UseVisualStyleBackColor = true;
            // 
            // WeNCheckBox
            // 
            this.WeNCheckBox.AutoSize = true;
            this.WeNCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.WeNCheckBox.Location = new System.Drawing.Point(166, 90);
            this.WeNCheckBox.Name = "WeNCheckBox";
            this.WeNCheckBox.Size = new System.Drawing.Size(15, 24);
            this.WeNCheckBox.TabIndex = 27;
            this.WeNCheckBox.UseVisualStyleBackColor = true;
            // 
            // TuNCheckBox
            // 
            this.TuNCheckBox.AutoSize = true;
            this.TuNCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TuNCheckBox.Location = new System.Drawing.Point(126, 90);
            this.TuNCheckBox.Name = "TuNCheckBox";
            this.TuNCheckBox.Size = new System.Drawing.Size(15, 24);
            this.TuNCheckBox.TabIndex = 26;
            this.TuNCheckBox.UseVisualStyleBackColor = true;
            // 
            // MoNCheckBox
            // 
            this.MoNCheckBox.AutoSize = true;
            this.MoNCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MoNCheckBox.Location = new System.Drawing.Point(84, 90);
            this.MoNCheckBox.Name = "MoNCheckBox";
            this.MoNCheckBox.Size = new System.Drawing.Size(15, 24);
            this.MoNCheckBox.TabIndex = 25;
            this.MoNCheckBox.UseVisualStyleBackColor = true;
            // 
            // SuACheckBox
            // 
            this.SuACheckBox.AutoSize = true;
            this.SuACheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SuACheckBox.Location = new System.Drawing.Point(326, 61);
            this.SuACheckBox.Name = "SuACheckBox";
            this.SuACheckBox.Size = new System.Drawing.Size(15, 23);
            this.SuACheckBox.TabIndex = 23;
            this.SuACheckBox.UseVisualStyleBackColor = true;
            // 
            // SaACheckBox
            // 
            this.SaACheckBox.AutoSize = true;
            this.SaACheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaACheckBox.Location = new System.Drawing.Point(286, 61);
            this.SaACheckBox.Name = "SaACheckBox";
            this.SaACheckBox.Size = new System.Drawing.Size(15, 23);
            this.SaACheckBox.TabIndex = 22;
            this.SaACheckBox.UseVisualStyleBackColor = true;
            // 
            // FrACheckBox
            // 
            this.FrACheckBox.AutoSize = true;
            this.FrACheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FrACheckBox.Location = new System.Drawing.Point(246, 61);
            this.FrACheckBox.Name = "FrACheckBox";
            this.FrACheckBox.Size = new System.Drawing.Size(15, 23);
            this.FrACheckBox.TabIndex = 21;
            this.FrACheckBox.UseVisualStyleBackColor = true;
            // 
            // ThACheckBox
            // 
            this.ThACheckBox.AutoSize = true;
            this.ThACheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ThACheckBox.Location = new System.Drawing.Point(206, 61);
            this.ThACheckBox.Name = "ThACheckBox";
            this.ThACheckBox.Size = new System.Drawing.Size(15, 23);
            this.ThACheckBox.TabIndex = 20;
            this.ThACheckBox.UseVisualStyleBackColor = true;
            // 
            // WeACheckBox
            // 
            this.WeACheckBox.AutoSize = true;
            this.WeACheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.WeACheckBox.Location = new System.Drawing.Point(166, 61);
            this.WeACheckBox.Name = "WeACheckBox";
            this.WeACheckBox.Size = new System.Drawing.Size(15, 23);
            this.WeACheckBox.TabIndex = 19;
            this.WeACheckBox.UseVisualStyleBackColor = true;
            // 
            // TuACheckBox
            // 
            this.TuACheckBox.AutoSize = true;
            this.TuACheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TuACheckBox.Location = new System.Drawing.Point(126, 61);
            this.TuACheckBox.Name = "TuACheckBox";
            this.TuACheckBox.Size = new System.Drawing.Size(15, 23);
            this.TuACheckBox.TabIndex = 18;
            this.TuACheckBox.UseVisualStyleBackColor = true;
            // 
            // MoACheckBox
            // 
            this.MoACheckBox.AutoSize = true;
            this.MoACheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MoACheckBox.Location = new System.Drawing.Point(84, 61);
            this.MoACheckBox.Name = "MoACheckBox";
            this.MoACheckBox.Size = new System.Drawing.Size(15, 23);
            this.MoACheckBox.TabIndex = 17;
            this.MoACheckBox.UseVisualStyleBackColor = true;
            // 
            // SuMCheckBox
            // 
            this.SuMCheckBox.AutoSize = true;
            this.SuMCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SuMCheckBox.Location = new System.Drawing.Point(326, 32);
            this.SuMCheckBox.Name = "SuMCheckBox";
            this.SuMCheckBox.Size = new System.Drawing.Size(15, 23);
            this.SuMCheckBox.TabIndex = 15;
            this.SuMCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaMCheckBox
            // 
            this.SaMCheckBox.AutoSize = true;
            this.SaMCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaMCheckBox.Location = new System.Drawing.Point(286, 32);
            this.SaMCheckBox.Name = "SaMCheckBox";
            this.SaMCheckBox.Size = new System.Drawing.Size(15, 23);
            this.SaMCheckBox.TabIndex = 14;
            this.SaMCheckBox.UseVisualStyleBackColor = true;
            // 
            // FrMCheckBox
            // 
            this.FrMCheckBox.AutoSize = true;
            this.FrMCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.FrMCheckBox.Location = new System.Drawing.Point(246, 32);
            this.FrMCheckBox.Name = "FrMCheckBox";
            this.FrMCheckBox.Size = new System.Drawing.Size(15, 23);
            this.FrMCheckBox.TabIndex = 13;
            this.FrMCheckBox.UseVisualStyleBackColor = true;
            // 
            // ThMCheckBox
            // 
            this.ThMCheckBox.AutoSize = true;
            this.ThMCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ThMCheckBox.Location = new System.Drawing.Point(206, 32);
            this.ThMCheckBox.Name = "ThMCheckBox";
            this.ThMCheckBox.Size = new System.Drawing.Size(15, 23);
            this.ThMCheckBox.TabIndex = 12;
            this.ThMCheckBox.UseVisualStyleBackColor = true;
            // 
            // WeMCheckBox
            // 
            this.WeMCheckBox.AutoSize = true;
            this.WeMCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.WeMCheckBox.Location = new System.Drawing.Point(166, 32);
            this.WeMCheckBox.Name = "WeMCheckBox";
            this.WeMCheckBox.Size = new System.Drawing.Size(15, 23);
            this.WeMCheckBox.TabIndex = 11;
            this.WeMCheckBox.UseVisualStyleBackColor = true;
            // 
            // TuMCheckBox
            // 
            this.TuMCheckBox.AutoSize = true;
            this.TuMCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TuMCheckBox.Location = new System.Drawing.Point(126, 32);
            this.TuMCheckBox.Name = "TuMCheckBox";
            this.TuMCheckBox.Size = new System.Drawing.Size(15, 23);
            this.TuMCheckBox.TabIndex = 10;
            this.TuMCheckBox.UseVisualStyleBackColor = true;
            // 
            // MoMCheckBox
            // 
            this.MoMCheckBox.AutoSize = true;
            this.MoMCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MoMCheckBox.Location = new System.Drawing.Point(84, 32);
            this.MoMCheckBox.Name = "MoMCheckBox";
            this.MoMCheckBox.Size = new System.Drawing.Size(15, 23);
            this.MoMCheckBox.TabIndex = 0;
            this.MoMCheckBox.UseVisualStyleBackColor = true;
            // 
            // MondaySelectButton
            // 
            this.MondaySelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MondaySelectButton.Location = new System.Drawing.Point(84, 3);
            this.MondaySelectButton.Name = "MondaySelectButton";
            this.MondaySelectButton.Size = new System.Drawing.Size(36, 23);
            this.MondaySelectButton.TabIndex = 32;
            this.MondaySelectButton.Text = "M";
            this.MondaySelectButton.UseVisualStyleBackColor = true;
            this.MondaySelectButton.Click += new System.EventHandler(this.MondaySelectButton_Click);
            // 
            // TuesdaySelectButton
            // 
            this.TuesdaySelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TuesdaySelectButton.Location = new System.Drawing.Point(126, 3);
            this.TuesdaySelectButton.Name = "TuesdaySelectButton";
            this.TuesdaySelectButton.Size = new System.Drawing.Size(34, 23);
            this.TuesdaySelectButton.TabIndex = 33;
            this.TuesdaySelectButton.Text = "Tu";
            this.TuesdaySelectButton.UseVisualStyleBackColor = true;
            this.TuesdaySelectButton.Click += new System.EventHandler(this.TuesdaySelectButton_Click);
            // 
            // WednesdaySelectButton
            // 
            this.WednesdaySelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WednesdaySelectButton.Location = new System.Drawing.Point(166, 3);
            this.WednesdaySelectButton.Name = "WednesdaySelectButton";
            this.WednesdaySelectButton.Size = new System.Drawing.Size(34, 23);
            this.WednesdaySelectButton.TabIndex = 34;
            this.WednesdaySelectButton.Text = "W";
            this.WednesdaySelectButton.UseVisualStyleBackColor = true;
            this.WednesdaySelectButton.Click += new System.EventHandler(this.WednesdaySelectButton_Click);
            // 
            // ThursdaySelectButton
            // 
            this.ThursdaySelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThursdaySelectButton.Location = new System.Drawing.Point(206, 3);
            this.ThursdaySelectButton.Name = "ThursdaySelectButton";
            this.ThursdaySelectButton.Size = new System.Drawing.Size(34, 23);
            this.ThursdaySelectButton.TabIndex = 35;
            this.ThursdaySelectButton.Text = "Th";
            this.ThursdaySelectButton.UseVisualStyleBackColor = true;
            this.ThursdaySelectButton.Click += new System.EventHandler(this.ThursdaySelectButton_Click);
            // 
            // FridaySelectButton
            // 
            this.FridaySelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FridaySelectButton.Location = new System.Drawing.Point(246, 3);
            this.FridaySelectButton.Name = "FridaySelectButton";
            this.FridaySelectButton.Size = new System.Drawing.Size(34, 23);
            this.FridaySelectButton.TabIndex = 36;
            this.FridaySelectButton.Text = "F";
            this.FridaySelectButton.UseVisualStyleBackColor = true;
            this.FridaySelectButton.Click += new System.EventHandler(this.FridaySelectButton_Click);
            // 
            // SaturdaySelectButton
            // 
            this.SaturdaySelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaturdaySelectButton.Location = new System.Drawing.Point(286, 3);
            this.SaturdaySelectButton.Name = "SaturdaySelectButton";
            this.SaturdaySelectButton.Size = new System.Drawing.Size(34, 23);
            this.SaturdaySelectButton.TabIndex = 37;
            this.SaturdaySelectButton.Text = "Sa";
            this.SaturdaySelectButton.UseVisualStyleBackColor = true;
            this.SaturdaySelectButton.Click += new System.EventHandler(this.SaturdaySelectButton_Click);
            // 
            // SundaySelectButton
            // 
            this.SundaySelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SundaySelectButton.Location = new System.Drawing.Point(326, 3);
            this.SundaySelectButton.Name = "SundaySelectButton";
            this.SundaySelectButton.Size = new System.Drawing.Size(34, 23);
            this.SundaySelectButton.TabIndex = 38;
            this.SundaySelectButton.Text = "Su";
            this.SundaySelectButton.UseVisualStyleBackColor = true;
            this.SundaySelectButton.Click += new System.EventHandler(this.SundaySelectButton_Click);
            // 
            // MorningSelectButton
            // 
            this.MorningSelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MorningSelectButton.Location = new System.Drawing.Point(3, 32);
            this.MorningSelectButton.Name = "MorningSelectButton";
            this.MorningSelectButton.Size = new System.Drawing.Size(75, 23);
            this.MorningSelectButton.TabIndex = 39;
            this.MorningSelectButton.Text = "Morning";
            this.MorningSelectButton.UseVisualStyleBackColor = true;
            this.MorningSelectButton.Click += new System.EventHandler(this.MorningSelectButton_Click);
            // 
            // AfternoonSelectButton
            // 
            this.AfternoonSelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AfternoonSelectButton.Location = new System.Drawing.Point(3, 61);
            this.AfternoonSelectButton.Name = "AfternoonSelectButton";
            this.AfternoonSelectButton.Size = new System.Drawing.Size(75, 23);
            this.AfternoonSelectButton.TabIndex = 40;
            this.AfternoonSelectButton.Text = "Afternoon";
            this.AfternoonSelectButton.UseVisualStyleBackColor = true;
            this.AfternoonSelectButton.Click += new System.EventHandler(this.AfternoonSelectButton_Click);
            // 
            // NightSelectButton
            // 
            this.NightSelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NightSelectButton.Location = new System.Drawing.Point(3, 90);
            this.NightSelectButton.Name = "NightSelectButton";
            this.NightSelectButton.Size = new System.Drawing.Size(75, 24);
            this.NightSelectButton.TabIndex = 41;
            this.NightSelectButton.Text = "Night";
            this.NightSelectButton.UseVisualStyleBackColor = true;
            this.NightSelectButton.Click += new System.EventHandler(this.NightSelectButton_Click);
            // 
            // AllTimesSelectButton
            // 
            this.AllTimesSelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllTimesSelectButton.Location = new System.Drawing.Point(3, 3);
            this.AllTimesSelectButton.Name = "AllTimesSelectButton";
            this.AllTimesSelectButton.Size = new System.Drawing.Size(75, 23);
            this.AllTimesSelectButton.TabIndex = 42;
            this.AllTimesSelectButton.Text = "All Times";
            this.AllTimesSelectButton.UseVisualStyleBackColor = true;
            this.AllTimesSelectButton.Click += new System.EventHandler(this.AllTimesSelectButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AdTimeTable);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(0, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 136);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Times to show ad (not done yet)";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.ImageSizeCombo);
            this.groupBox4.Location = new System.Drawing.Point(0, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(144, 40);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Image Size";
            // 
            // ImageSizeCombo
            // 
            this.ImageSizeCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageSizeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImageSizeCombo.FormattingEnabled = true;
            this.ImageSizeCombo.Items.AddRange(new object[] {
            "128x256",
            "128x128",
            "512x256",
            "512x128",
            "256x512",
            "256x256",
            "512x64"});
            this.ImageSizeCombo.Location = new System.Drawing.Point(3, 16);
            this.ImageSizeCombo.Name = "ImageSizeCombo";
            this.ImageSizeCombo.Size = new System.Drawing.Size(138, 21);
            this.ImageSizeCombo.TabIndex = 0;
            this.HintTooltip.SetToolTip(this.ImageSizeCombo, "The image you store must be one of the preset sizes.  Note that your cache file s" +
                    "hould have one of each size stored in it, otherwise you may encounter problems r" +
                    "unning the game.");
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.ViewMaxSpinner);
            this.groupBox5.Controls.Add(this.ViewMaxLabel);
            this.groupBox5.Controls.Add(this.MaxViewsCheckBox);
            this.groupBox5.Controls.Add(this.ViewTimesSpinner);
            this.groupBox5.Location = new System.Drawing.Point(144, 232);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(224, 40);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Views";
            // 
            // ViewMaxSpinner
            // 
            this.ViewMaxSpinner.Location = new System.Drawing.Point(120, 16);
            this.ViewMaxSpinner.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ViewMaxSpinner.Name = "ViewMaxSpinner";
            this.ViewMaxSpinner.Size = new System.Drawing.Size(64, 20);
            this.ViewMaxSpinner.TabIndex = 3;
            this.HintTooltip.SetToolTip(this.ViewMaxSpinner, "How many times may this ad be viewed before it expires?  Set to 0 for no limit.");
            this.ViewMaxSpinner.Visible = false;
            // 
            // ViewMaxLabel
            // 
            this.ViewMaxLabel.AutoSize = true;
            this.ViewMaxLabel.Location = new System.Drawing.Point(192, 16);
            this.ViewMaxLabel.Name = "ViewMaxLabel";
            this.ViewMaxLabel.Size = new System.Drawing.Size(34, 13);
            this.ViewMaxLabel.TabIndex = 2;
            this.ViewMaxLabel.Text = "times.";
            this.ViewMaxLabel.Visible = false;
            // 
            // MaxViewsCheckBox
            // 
            this.MaxViewsCheckBox.AutoSize = true;
            this.MaxViewsCheckBox.Location = new System.Drawing.Point(80, 16);
            this.MaxViewsCheckBox.Name = "MaxViewsCheckBox";
            this.MaxViewsCheckBox.Size = new System.Drawing.Size(35, 17);
            this.MaxViewsCheckBox.TabIndex = 1;
            this.MaxViewsCheckBox.Text = "of";
            this.HintTooltip.SetToolTip(this.MaxViewsCheckBox, "Enable this checkbox to set an upper limit to the number of times this ad may be " +
                    "viewed.");
            this.MaxViewsCheckBox.UseVisualStyleBackColor = true;
            this.MaxViewsCheckBox.CheckedChanged += new System.EventHandler(this.MaxViewsCheckBox_CheckedChanged);
            // 
            // ViewTimesSpinner
            // 
            this.ViewTimesSpinner.Location = new System.Drawing.Point(8, 16);
            this.ViewTimesSpinner.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ViewTimesSpinner.Name = "ViewTimesSpinner";
            this.ViewTimesSpinner.Size = new System.Drawing.Size(72, 20);
            this.ViewTimesSpinner.TabIndex = 0;
            this.HintTooltip.SetToolTip(this.ViewTimesSpinner, "This is the number of times you have been recorded \"viewing\" this ad so far.");
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.MinViewTimeUnitLabel);
            this.groupBox6.Controls.Add(this.MinTimeSpinner);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(0, 272);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(368, 40);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Impression Settings";
            // 
            // MinViewTimeUnitLabel
            // 
            this.MinViewTimeUnitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinViewTimeUnitLabel.AutoSize = true;
            this.MinViewTimeUnitLabel.Location = new System.Drawing.Point(336, 20);
            this.MinViewTimeUnitLabel.Name = "MinViewTimeUnitLabel";
            this.MinViewTimeUnitLabel.Size = new System.Drawing.Size(20, 13);
            this.MinViewTimeUnitLabel.TabIndex = 2;
            this.MinViewTimeUnitLabel.Text = "ms";
            // 
            // MinTimeSpinner
            // 
            this.MinTimeSpinner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MinTimeSpinner.Location = new System.Drawing.Point(184, 16);
            this.MinTimeSpinner.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MinTimeSpinner.Name = "MinTimeSpinner";
            this.MinTimeSpinner.Size = new System.Drawing.Size(152, 20);
            this.MinTimeSpinner.TabIndex = 1;
            this.MinTimeSpinner.ThousandsSeparator = true;
            this.HintTooltip.SetToolTip(this.MinTimeSpinner, "1000 ms is equal to 1 second.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum Time To Count As A View";
            // 
            // HintTooltip
            // 
            this.HintTooltip.IsBalloon = true;
            this.HintTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.HintTooltip.ToolTipTitle = "Information";
            // 
            // VideoAdCheckbox
            // 
            this.VideoAdCheckbox.AutoSize = true;
            this.VideoAdCheckbox.Location = new System.Drawing.Point(120, 0);
            this.VideoAdCheckbox.Name = "VideoAdCheckbox";
            this.VideoAdCheckbox.Size = new System.Drawing.Size(95, 17);
            this.VideoAdCheckbox.TabIndex = 12;
            this.VideoAdCheckbox.Text = "Video Ad (BIK)";
            this.HintTooltip.SetToolTip(this.VideoAdCheckbox, resources.GetString("VideoAdCheckbox.ToolTip"));
            this.VideoAdCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.AgeSpinner);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.GenderComboBox);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Location = new System.Drawing.Point(0, 312);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(208, 64);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Target Audience";
            // 
            // AgeSpinner
            // 
            this.AgeSpinner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AgeSpinner.Location = new System.Drawing.Point(64, 40);
            this.AgeSpinner.Name = "AgeSpinner";
            this.AgeSpinner.Size = new System.Drawing.Size(136, 20);
            this.AgeSpinner.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Age";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(64, 16);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(136, 21);
            this.GenderComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gender";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(272, 313);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 24);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelActionButton
            // 
            this.CancelActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelActionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelActionButton.Location = new System.Drawing.Point(272, 345);
            this.CancelActionButton.Name = "CancelActionButton";
            this.CancelActionButton.Size = new System.Drawing.Size(96, 24);
            this.CancelActionButton.TabIndex = 11;
            this.CancelActionButton.Text = "Cancel";
            this.CancelActionButton.UseVisualStyleBackColor = true;
            this.CancelActionButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AdEditorForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelActionButton;
            this.ClientSize = new System.Drawing.Size(371, 377);
            this.ControlBox = false;
            this.Controls.Add(this.VideoAdCheckbox);
            this.Controls.Add(this.CancelActionButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ActiveCheckBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdEditorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Ad Properties";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.AdTimeTable.ResumeLayout(false);
            this.AdTimeTable.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMaxSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewTimesSpinner)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinTimeSpinner)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ActiveCheckBox;
        private System.Windows.Forms.DateTimePicker ActivationDatePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker ExpiryDatePicker;
        private System.Windows.Forms.TableLayoutPanel AdTimeTable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox SuNCheckBox;
        private System.Windows.Forms.CheckBox SaNCheckBox;
        private System.Windows.Forms.CheckBox FrNCheckBox;
        private System.Windows.Forms.CheckBox ThNCheckBox;
        private System.Windows.Forms.CheckBox WeNCheckBox;
        private System.Windows.Forms.CheckBox TuNCheckBox;
        private System.Windows.Forms.CheckBox MoNCheckBox;
        private System.Windows.Forms.CheckBox SuACheckBox;
        private System.Windows.Forms.CheckBox SaACheckBox;
        private System.Windows.Forms.CheckBox FrACheckBox;
        private System.Windows.Forms.CheckBox ThACheckBox;
        private System.Windows.Forms.CheckBox WeACheckBox;
        private System.Windows.Forms.CheckBox TuACheckBox;
        private System.Windows.Forms.CheckBox MoACheckBox;
        private System.Windows.Forms.CheckBox SuMCheckBox;
        private System.Windows.Forms.CheckBox SaMCheckBox;
        private System.Windows.Forms.CheckBox FrMCheckBox;
        private System.Windows.Forms.CheckBox ThMCheckBox;
        private System.Windows.Forms.CheckBox WeMCheckBox;
        private System.Windows.Forms.CheckBox TuMCheckBox;
        private System.Windows.Forms.CheckBox MoMCheckBox;
        private System.Windows.Forms.Button MondaySelectButton;
        private System.Windows.Forms.Button TuesdaySelectButton;
        private System.Windows.Forms.Button WednesdaySelectButton;
        private System.Windows.Forms.Button ThursdaySelectButton;
        private System.Windows.Forms.Button FridaySelectButton;
        private System.Windows.Forms.Button SaturdaySelectButton;
        private System.Windows.Forms.Button SundaySelectButton;
        private System.Windows.Forms.Button MorningSelectButton;
        private System.Windows.Forms.Button AfternoonSelectButton;
        private System.Windows.Forms.Button NightSelectButton;
        private System.Windows.Forms.Button AllTimesSelectButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox ImageSizeCombo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown ViewMaxSpinner;
        private System.Windows.Forms.Label ViewMaxLabel;
        private System.Windows.Forms.CheckBox MaxViewsCheckBox;
        private System.Windows.Forms.NumericUpDown ViewTimesSpinner;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown MinTimeSpinner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MinViewTimeUnitLabel;
        private System.Windows.Forms.ToolTip HintTooltip;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AgeSpinner;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelActionButton;
        private System.Windows.Forms.CheckBox VideoAdCheckbox;
    }
}