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
            resources.ApplyResources(this.ActiveCheckBox, "ActiveCheckBox");
            this.ActiveCheckBox.Name = "ActiveCheckBox";
            this.HintTooltip.SetToolTip(this.ActiveCheckBox, resources.GetString("ActiveCheckBox.ToolTip"));
            this.ActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ActivationDatePicker
            // 
            resources.ApplyResources(this.ActivationDatePicker, "ActivationDatePicker");
            this.ActivationDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ActivationDatePicker.MaxDate = new System.DateTime(2038, 1, 1, 0, 0, 0, 0);
            this.ActivationDatePicker.MinDate = new System.DateTime(1970, 1, 2, 0, 0, 0, 0);
            this.ActivationDatePicker.Name = "ActivationDatePicker";
            this.HintTooltip.SetToolTip(this.ActivationDatePicker, resources.GetString("ActivationDatePicker.ToolTip"));
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.ActivationDatePicker);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.ExpiryDatePicker);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // ExpiryDatePicker
            // 
            this.ExpiryDatePicker.Checked = false;
            resources.ApplyResources(this.ExpiryDatePicker, "ExpiryDatePicker");
            this.ExpiryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpiryDatePicker.MaxDate = new System.DateTime(2038, 1, 1, 0, 0, 0, 0);
            this.ExpiryDatePicker.MinDate = new System.DateTime(1970, 1, 2, 0, 0, 0, 0);
            this.ExpiryDatePicker.Name = "ExpiryDatePicker";
            this.ExpiryDatePicker.ShowCheckBox = true;
            this.HintTooltip.SetToolTip(this.ExpiryDatePicker, resources.GetString("ExpiryDatePicker.ToolTip"));
            // 
            // AdTimeTable
            // 
            resources.ApplyResources(this.AdTimeTable, "AdTimeTable");
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
            this.AdTimeTable.Name = "AdTimeTable";
            // 
            // SuNCheckBox
            // 
            resources.ApplyResources(this.SuNCheckBox, "SuNCheckBox");
            this.SuNCheckBox.Name = "SuNCheckBox";
            this.SuNCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaNCheckBox
            // 
            resources.ApplyResources(this.SaNCheckBox, "SaNCheckBox");
            this.SaNCheckBox.Name = "SaNCheckBox";
            this.SaNCheckBox.UseVisualStyleBackColor = true;
            // 
            // FrNCheckBox
            // 
            resources.ApplyResources(this.FrNCheckBox, "FrNCheckBox");
            this.FrNCheckBox.Name = "FrNCheckBox";
            this.FrNCheckBox.UseVisualStyleBackColor = true;
            // 
            // ThNCheckBox
            // 
            resources.ApplyResources(this.ThNCheckBox, "ThNCheckBox");
            this.ThNCheckBox.Name = "ThNCheckBox";
            this.ThNCheckBox.UseVisualStyleBackColor = true;
            // 
            // WeNCheckBox
            // 
            resources.ApplyResources(this.WeNCheckBox, "WeNCheckBox");
            this.WeNCheckBox.Name = "WeNCheckBox";
            this.WeNCheckBox.UseVisualStyleBackColor = true;
            // 
            // TuNCheckBox
            // 
            resources.ApplyResources(this.TuNCheckBox, "TuNCheckBox");
            this.TuNCheckBox.Name = "TuNCheckBox";
            this.TuNCheckBox.UseVisualStyleBackColor = true;
            // 
            // MoNCheckBox
            // 
            resources.ApplyResources(this.MoNCheckBox, "MoNCheckBox");
            this.MoNCheckBox.Name = "MoNCheckBox";
            this.MoNCheckBox.UseVisualStyleBackColor = true;
            // 
            // SuACheckBox
            // 
            resources.ApplyResources(this.SuACheckBox, "SuACheckBox");
            this.SuACheckBox.Name = "SuACheckBox";
            this.SuACheckBox.UseVisualStyleBackColor = true;
            // 
            // SaACheckBox
            // 
            resources.ApplyResources(this.SaACheckBox, "SaACheckBox");
            this.SaACheckBox.Name = "SaACheckBox";
            this.SaACheckBox.UseVisualStyleBackColor = true;
            // 
            // FrACheckBox
            // 
            resources.ApplyResources(this.FrACheckBox, "FrACheckBox");
            this.FrACheckBox.Name = "FrACheckBox";
            this.FrACheckBox.UseVisualStyleBackColor = true;
            // 
            // ThACheckBox
            // 
            resources.ApplyResources(this.ThACheckBox, "ThACheckBox");
            this.ThACheckBox.Name = "ThACheckBox";
            this.ThACheckBox.UseVisualStyleBackColor = true;
            // 
            // WeACheckBox
            // 
            resources.ApplyResources(this.WeACheckBox, "WeACheckBox");
            this.WeACheckBox.Name = "WeACheckBox";
            this.WeACheckBox.UseVisualStyleBackColor = true;
            // 
            // TuACheckBox
            // 
            resources.ApplyResources(this.TuACheckBox, "TuACheckBox");
            this.TuACheckBox.Name = "TuACheckBox";
            this.TuACheckBox.UseVisualStyleBackColor = true;
            // 
            // MoACheckBox
            // 
            resources.ApplyResources(this.MoACheckBox, "MoACheckBox");
            this.MoACheckBox.Name = "MoACheckBox";
            this.MoACheckBox.UseVisualStyleBackColor = true;
            // 
            // SuMCheckBox
            // 
            resources.ApplyResources(this.SuMCheckBox, "SuMCheckBox");
            this.SuMCheckBox.Name = "SuMCheckBox";
            this.SuMCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaMCheckBox
            // 
            resources.ApplyResources(this.SaMCheckBox, "SaMCheckBox");
            this.SaMCheckBox.Name = "SaMCheckBox";
            this.SaMCheckBox.UseVisualStyleBackColor = true;
            // 
            // FrMCheckBox
            // 
            resources.ApplyResources(this.FrMCheckBox, "FrMCheckBox");
            this.FrMCheckBox.Name = "FrMCheckBox";
            this.FrMCheckBox.UseVisualStyleBackColor = true;
            // 
            // ThMCheckBox
            // 
            resources.ApplyResources(this.ThMCheckBox, "ThMCheckBox");
            this.ThMCheckBox.Name = "ThMCheckBox";
            this.ThMCheckBox.UseVisualStyleBackColor = true;
            // 
            // WeMCheckBox
            // 
            resources.ApplyResources(this.WeMCheckBox, "WeMCheckBox");
            this.WeMCheckBox.Name = "WeMCheckBox";
            this.WeMCheckBox.UseVisualStyleBackColor = true;
            // 
            // TuMCheckBox
            // 
            resources.ApplyResources(this.TuMCheckBox, "TuMCheckBox");
            this.TuMCheckBox.Name = "TuMCheckBox";
            this.TuMCheckBox.UseVisualStyleBackColor = true;
            // 
            // MoMCheckBox
            // 
            resources.ApplyResources(this.MoMCheckBox, "MoMCheckBox");
            this.MoMCheckBox.Name = "MoMCheckBox";
            this.MoMCheckBox.UseVisualStyleBackColor = true;
            // 
            // MondaySelectButton
            // 
            resources.ApplyResources(this.MondaySelectButton, "MondaySelectButton");
            this.MondaySelectButton.Name = "MondaySelectButton";
            this.MondaySelectButton.UseVisualStyleBackColor = true;
            this.MondaySelectButton.Click += new System.EventHandler(this.MondaySelectButton_Click);
            // 
            // TuesdaySelectButton
            // 
            resources.ApplyResources(this.TuesdaySelectButton, "TuesdaySelectButton");
            this.TuesdaySelectButton.Name = "TuesdaySelectButton";
            this.TuesdaySelectButton.UseVisualStyleBackColor = true;
            this.TuesdaySelectButton.Click += new System.EventHandler(this.TuesdaySelectButton_Click);
            // 
            // WednesdaySelectButton
            // 
            resources.ApplyResources(this.WednesdaySelectButton, "WednesdaySelectButton");
            this.WednesdaySelectButton.Name = "WednesdaySelectButton";
            this.WednesdaySelectButton.UseVisualStyleBackColor = true;
            this.WednesdaySelectButton.Click += new System.EventHandler(this.WednesdaySelectButton_Click);
            // 
            // ThursdaySelectButton
            // 
            resources.ApplyResources(this.ThursdaySelectButton, "ThursdaySelectButton");
            this.ThursdaySelectButton.Name = "ThursdaySelectButton";
            this.ThursdaySelectButton.UseVisualStyleBackColor = true;
            this.ThursdaySelectButton.Click += new System.EventHandler(this.ThursdaySelectButton_Click);
            // 
            // FridaySelectButton
            // 
            resources.ApplyResources(this.FridaySelectButton, "FridaySelectButton");
            this.FridaySelectButton.Name = "FridaySelectButton";
            this.FridaySelectButton.UseVisualStyleBackColor = true;
            this.FridaySelectButton.Click += new System.EventHandler(this.FridaySelectButton_Click);
            // 
            // SaturdaySelectButton
            // 
            resources.ApplyResources(this.SaturdaySelectButton, "SaturdaySelectButton");
            this.SaturdaySelectButton.Name = "SaturdaySelectButton";
            this.SaturdaySelectButton.UseVisualStyleBackColor = true;
            this.SaturdaySelectButton.Click += new System.EventHandler(this.SaturdaySelectButton_Click);
            // 
            // SundaySelectButton
            // 
            resources.ApplyResources(this.SundaySelectButton, "SundaySelectButton");
            this.SundaySelectButton.Name = "SundaySelectButton";
            this.SundaySelectButton.UseVisualStyleBackColor = true;
            this.SundaySelectButton.Click += new System.EventHandler(this.SundaySelectButton_Click);
            // 
            // MorningSelectButton
            // 
            resources.ApplyResources(this.MorningSelectButton, "MorningSelectButton");
            this.MorningSelectButton.Name = "MorningSelectButton";
            this.MorningSelectButton.UseVisualStyleBackColor = true;
            this.MorningSelectButton.Click += new System.EventHandler(this.MorningSelectButton_Click);
            // 
            // AfternoonSelectButton
            // 
            resources.ApplyResources(this.AfternoonSelectButton, "AfternoonSelectButton");
            this.AfternoonSelectButton.Name = "AfternoonSelectButton";
            this.AfternoonSelectButton.UseVisualStyleBackColor = true;
            this.AfternoonSelectButton.Click += new System.EventHandler(this.AfternoonSelectButton_Click);
            // 
            // NightSelectButton
            // 
            resources.ApplyResources(this.NightSelectButton, "NightSelectButton");
            this.NightSelectButton.Name = "NightSelectButton";
            this.NightSelectButton.UseVisualStyleBackColor = true;
            this.NightSelectButton.Click += new System.EventHandler(this.NightSelectButton_Click);
            // 
            // AllTimesSelectButton
            // 
            resources.ApplyResources(this.AllTimesSelectButton, "AllTimesSelectButton");
            this.AllTimesSelectButton.Name = "AllTimesSelectButton";
            this.AllTimesSelectButton.UseVisualStyleBackColor = true;
            this.AllTimesSelectButton.Click += new System.EventHandler(this.AllTimesSelectButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AdTimeTable);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.ImageSizeCombo);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // ImageSizeCombo
            // 
            resources.ApplyResources(this.ImageSizeCombo, "ImageSizeCombo");
            this.ImageSizeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImageSizeCombo.FormattingEnabled = true;
            this.ImageSizeCombo.Items.AddRange(new object[] {
            resources.GetString("ImageSizeCombo.Items"),
            resources.GetString("ImageSizeCombo.Items1"),
            resources.GetString("ImageSizeCombo.Items2"),
            resources.GetString("ImageSizeCombo.Items3"),
            resources.GetString("ImageSizeCombo.Items4"),
            resources.GetString("ImageSizeCombo.Items5"),
            resources.GetString("ImageSizeCombo.Items6")});
            this.ImageSizeCombo.Name = "ImageSizeCombo";
            this.HintTooltip.SetToolTip(this.ImageSizeCombo, resources.GetString("ImageSizeCombo.ToolTip"));
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.ViewMaxSpinner);
            this.groupBox5.Controls.Add(this.ViewMaxLabel);
            this.groupBox5.Controls.Add(this.MaxViewsCheckBox);
            this.groupBox5.Controls.Add(this.ViewTimesSpinner);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // ViewMaxSpinner
            // 
            resources.ApplyResources(this.ViewMaxSpinner, "ViewMaxSpinner");
            this.ViewMaxSpinner.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ViewMaxSpinner.Name = "ViewMaxSpinner";
            this.HintTooltip.SetToolTip(this.ViewMaxSpinner, resources.GetString("ViewMaxSpinner.ToolTip"));
            // 
            // ViewMaxLabel
            // 
            resources.ApplyResources(this.ViewMaxLabel, "ViewMaxLabel");
            this.ViewMaxLabel.Name = "ViewMaxLabel";
            // 
            // MaxViewsCheckBox
            // 
            resources.ApplyResources(this.MaxViewsCheckBox, "MaxViewsCheckBox");
            this.MaxViewsCheckBox.Name = "MaxViewsCheckBox";
            this.HintTooltip.SetToolTip(this.MaxViewsCheckBox, resources.GetString("MaxViewsCheckBox.ToolTip"));
            this.MaxViewsCheckBox.UseVisualStyleBackColor = true;
            this.MaxViewsCheckBox.CheckedChanged += new System.EventHandler(this.MaxViewsCheckBox_CheckedChanged);
            // 
            // ViewTimesSpinner
            // 
            resources.ApplyResources(this.ViewTimesSpinner, "ViewTimesSpinner");
            this.ViewTimesSpinner.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ViewTimesSpinner.Name = "ViewTimesSpinner";
            this.HintTooltip.SetToolTip(this.ViewTimesSpinner, resources.GetString("ViewTimesSpinner.ToolTip"));
            // 
            // groupBox6
            // 
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Controls.Add(this.MinViewTimeUnitLabel);
            this.groupBox6.Controls.Add(this.MinTimeSpinner);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // MinViewTimeUnitLabel
            // 
            resources.ApplyResources(this.MinViewTimeUnitLabel, "MinViewTimeUnitLabel");
            this.MinViewTimeUnitLabel.Name = "MinViewTimeUnitLabel";
            // 
            // MinTimeSpinner
            // 
            resources.ApplyResources(this.MinTimeSpinner, "MinTimeSpinner");
            this.MinTimeSpinner.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MinTimeSpinner.Name = "MinTimeSpinner";
            this.HintTooltip.SetToolTip(this.MinTimeSpinner, resources.GetString("MinTimeSpinner.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // HintTooltip
            // 
            resources.ApplyResources(this.HintTooltip, "HintTooltip");
            // 
            // VideoAdCheckbox
            // 
            resources.ApplyResources(this.VideoAdCheckbox, "VideoAdCheckbox");
            this.VideoAdCheckbox.Name = "VideoAdCheckbox";
            this.HintTooltip.SetToolTip(this.VideoAdCheckbox, resources.GetString("VideoAdCheckbox.ToolTip"));
            this.VideoAdCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Controls.Add(this.AgeSpinner);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.GenderComboBox);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // AgeSpinner
            // 
            resources.ApplyResources(this.AgeSpinner, "AgeSpinner");
            this.AgeSpinner.Name = "AgeSpinner";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // GenderComboBox
            // 
            resources.ApplyResources(this.GenderComboBox, "GenderComboBox");
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            resources.GetString("GenderComboBox.Items"),
            resources.GetString("GenderComboBox.Items1")});
            this.GenderComboBox.Name = "GenderComboBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelActionButton
            // 
            resources.ApplyResources(this.CancelActionButton, "CancelActionButton");
            this.CancelActionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelActionButton.Name = "CancelActionButton";
            this.CancelActionButton.UseVisualStyleBackColor = true;
            this.CancelActionButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AdEditorForm
            // 
            this.AcceptButton = this.SaveButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelActionButton;
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