namespace au.id.micolous.apps.igaeditor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OpenDatabaseDialogue = new System.Windows.Forms.OpenFileDialog();
            this.EditingGroup = new System.Windows.Forms.GroupBox();
            this.PreviewImageButton = new System.Windows.Forms.Button();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            this.EditRecordButton = new System.Windows.Forms.Button();
            this.ImportImageButton = new System.Windows.Forms.Button();
            this.SaveAdImageButton = new System.Windows.Forms.Button();
            this.CacheEntryList = new System.Windows.Forms.ListView();
            this.contentId = new System.Windows.Forms.ColumnHeader();
            this.active = new System.Windows.Forms.ColumnHeader();
            this.activate = new System.Windows.Forms.ColumnHeader();
            this.expire = new System.Windows.Forms.ColumnHeader();
            this.dayparts = new System.Windows.Forms.ColumnHeader();
            this.imageSize = new System.Windows.Forms.ColumnHeader();
            this.isVideo = new System.Windows.Forms.ColumnHeader();
            this.viewCount = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importAdpackFilebfadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAdpackFilebfadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacuumDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wARNINGThisIsForAdvancedUsersAndDevelopersOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.changeAppIDOfCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.researchForumThreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WelcomeGroup = new System.Windows.Forms.GroupBox();
            this.BigOpenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveDDSDialogue = new System.Windows.Forms.SaveFileDialog();
            this.LoadDDSDialogue = new System.Windows.Forms.OpenFileDialog();
            this.OpenAdpackDialogue = new System.Windows.Forms.OpenFileDialog();
            this.HintToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AdContextMenu = new System.Windows.Forms.ContextMenu();
            this.editItemContext = new System.Windows.Forms.MenuItem();
            this.deleteItemContext = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.previewImageContext = new System.Windows.Forms.MenuItem();
            this.importImageContext = new System.Windows.Forms.MenuItem();
            this.exportImageContext = new System.Windows.Forms.MenuItem();
            this.ImagePreviewGroup = new System.Windows.Forms.GroupBox();
            this.PreviewCloseButton = new System.Windows.Forms.Button();
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.EditingGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.WelcomeGroup.SuspendLayout();
            this.ImagePreviewGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenDatabaseDialogue
            // 
            this.OpenDatabaseDialogue.Filter = "IContent.cache|icontent.cache|Cache files|*.cache|All files|*.*";
            this.OpenDatabaseDialogue.Title = "Please locate your icontent.cache file, in your My Documents folder.";
            // 
            // EditingGroup
            // 
            this.EditingGroup.Controls.Add(this.PreviewImageButton);
            this.EditingGroup.Controls.Add(this.AddRecordButton);
            this.EditingGroup.Controls.Add(this.DeleteRecordButton);
            this.EditingGroup.Controls.Add(this.EditRecordButton);
            this.EditingGroup.Controls.Add(this.ImportImageButton);
            this.EditingGroup.Controls.Add(this.SaveAdImageButton);
            this.EditingGroup.Controls.Add(this.CacheEntryList);
            this.EditingGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditingGroup.Location = new System.Drawing.Point(0, 24);
            this.EditingGroup.Name = "EditingGroup";
            this.EditingGroup.Size = new System.Drawing.Size(655, 299);
            this.EditingGroup.TabIndex = 0;
            this.EditingGroup.TabStop = false;
            this.EditingGroup.Text = "Ad Cache Entries";
            this.EditingGroup.Visible = false;
            // 
            // PreviewImageButton
            // 
            this.PreviewImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewImageButton.Location = new System.Drawing.Point(368, 274);
            this.PreviewImageButton.Name = "PreviewImageButton";
            this.PreviewImageButton.Size = new System.Drawing.Size(75, 20);
            this.PreviewImageButton.TabIndex = 6;
            this.PreviewImageButton.Text = "Preview Image";
            this.PreviewImageButton.UseVisualStyleBackColor = true;
            this.PreviewImageButton.Click += new System.EventHandler(this.PreviewImageButton_Click);
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddRecordButton.Location = new System.Drawing.Point(7, 274);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(89, 20);
            this.AddRecordButton.TabIndex = 5;
            this.AddRecordButton.Text = "Add Record";
            this.HintToolTip.SetToolTip(this.AddRecordButton, "Creates a new advertisement.");
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteRecordButton.Location = new System.Drawing.Point(103, 274);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(89, 20);
            this.DeleteRecordButton.TabIndex = 4;
            this.DeleteRecordButton.Text = "Delete Record";
            this.HintToolTip.SetToolTip(this.DeleteRecordButton, "Deletes an advertisment.");
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // EditRecordButton
            // 
            this.EditRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditRecordButton.Location = new System.Drawing.Point(199, 274);
            this.EditRecordButton.Name = "EditRecordButton";
            this.EditRecordButton.Size = new System.Drawing.Size(89, 20);
            this.EditRecordButton.TabIndex = 3;
            this.EditRecordButton.Text = "Edit Record";
            this.HintToolTip.SetToolTip(this.EditRecordButton, "Edits an existing advertisement.");
            this.EditRecordButton.UseVisualStyleBackColor = true;
            this.EditRecordButton.Click += new System.EventHandler(this.EditRecordButton_Click);
            // 
            // ImportImageButton
            // 
            this.ImportImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportImageButton.Location = new System.Drawing.Point(448, 274);
            this.ImportImageButton.Name = "ImportImageButton";
            this.ImportImageButton.Size = new System.Drawing.Size(94, 20);
            this.ImportImageButton.TabIndex = 2;
            this.ImportImageButton.Text = "Import Image";
            this.HintToolTip.SetToolTip(this.ImportImageButton, "Imports an image or video into the record.");
            this.ImportImageButton.UseVisualStyleBackColor = true;
            this.ImportImageButton.Click += new System.EventHandler(this.ImportImageButton_Click);
            // 
            // SaveAdImageButton
            // 
            this.SaveAdImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAdImageButton.Location = new System.Drawing.Point(552, 274);
            this.SaveAdImageButton.Name = "SaveAdImageButton";
            this.SaveAdImageButton.Size = new System.Drawing.Size(96, 20);
            this.SaveAdImageButton.TabIndex = 1;
            this.SaveAdImageButton.Text = "Export Image";
            this.HintToolTip.SetToolTip(this.SaveAdImageButton, "Exports an image or video from a record.");
            this.SaveAdImageButton.UseVisualStyleBackColor = true;
            this.SaveAdImageButton.Click += new System.EventHandler(this.SaveAdImageButton_Click);
            // 
            // CacheEntryList
            // 
            this.CacheEntryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CacheEntryList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.contentId,
            this.active,
            this.activate,
            this.expire,
            this.dayparts,
            this.imageSize,
            this.isVideo,
            this.viewCount});
            this.CacheEntryList.HideSelection = false;
            this.CacheEntryList.Location = new System.Drawing.Point(7, 14);
            this.CacheEntryList.MultiSelect = false;
            this.CacheEntryList.Name = "CacheEntryList";
            this.CacheEntryList.Size = new System.Drawing.Size(646, 258);
            this.CacheEntryList.TabIndex = 0;
            this.CacheEntryList.UseCompatibleStateImageBehavior = false;
            this.CacheEntryList.View = System.Windows.Forms.View.Details;
            this.CacheEntryList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CacheEntryList_MouseClick);
            this.CacheEntryList.DoubleClick += new System.EventHandler(this.EditRecordButton_Click);
            // 
            // contentId
            // 
            this.contentId.Text = "ID";
            // 
            // active
            // 
            this.active.Text = "Active?";
            this.active.Width = 59;
            // 
            // activate
            // 
            this.activate.Text = "Active From";
            this.activate.Width = 130;
            // 
            // expire
            // 
            this.expire.Text = "Expiry";
            this.expire.Width = 130;
            // 
            // dayparts
            // 
            this.dayparts.Text = "Shown";
            this.dayparts.Width = 90;
            // 
            // imageSize
            // 
            this.imageSize.Text = "Size";
            // 
            // isVideo
            // 
            this.isVideo.Text = "Type";
            this.isVideo.Width = 50;
            // 
            // viewCount
            // 
            this.viewCount.Text = "Views";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(655, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importAdpackFilebfadsToolStripMenuItem,
            this.exportAdpackFilebfadsToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem,
            this.vacuumDatabaseToolStripMenuItem,
            this.closeDatabaseToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.databaseToolStripMenuItem.Text = "Application";
            // 
            // importAdpackFilebfadsToolStripMenuItem
            // 
            this.importAdpackFilebfadsToolStripMenuItem.Enabled = false;
            this.importAdpackFilebfadsToolStripMenuItem.Name = "importAdpackFilebfadsToolStripMenuItem";
            this.importAdpackFilebfadsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.importAdpackFilebfadsToolStripMenuItem.Text = "Import Adpack File";
            this.importAdpackFilebfadsToolStripMenuItem.ToolTipText = "Imports a group of ads from an adpack file.";
            this.importAdpackFilebfadsToolStripMenuItem.Click += new System.EventHandler(this.importAdpackFilebfadsToolStripMenuItem_Click);
            // 
            // exportAdpackFilebfadsToolStripMenuItem
            // 
            this.exportAdpackFilebfadsToolStripMenuItem.Enabled = false;
            this.exportAdpackFilebfadsToolStripMenuItem.Name = "exportAdpackFilebfadsToolStripMenuItem";
            this.exportAdpackFilebfadsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exportAdpackFilebfadsToolStripMenuItem.Text = "Export Adpack File";
            this.exportAdpackFilebfadsToolStripMenuItem.ToolTipText = "Exports advertisements from your ad cache to an adpack file.";
            this.exportAdpackFilebfadsToolStripMenuItem.Click += new System.EventHandler(this.exportAdpackFilebfadsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Enabled = false;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.ToolTipText = "Reload all data from the database, updating the export cache.";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshDatabaseMenuItem_Click);
            // 
            // vacuumDatabaseToolStripMenuItem
            // 
            this.vacuumDatabaseToolStripMenuItem.Enabled = false;
            this.vacuumDatabaseToolStripMenuItem.Name = "vacuumDatabaseToolStripMenuItem";
            this.vacuumDatabaseToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.vacuumDatabaseToolStripMenuItem.Text = "Vacuum/Shrink Database";
            this.vacuumDatabaseToolStripMenuItem.ToolTipText = "\"Vacuum\" the database so that it uses less room.";
            this.vacuumDatabaseToolStripMenuItem.Click += new System.EventHandler(this.vacuumDatabaseToolStripMenuItem_Click);
            // 
            // closeDatabaseToolStripMenuItem
            // 
            this.closeDatabaseToolStripMenuItem.Enabled = false;
            this.closeDatabaseToolStripMenuItem.Name = "closeDatabaseToolStripMenuItem";
            this.closeDatabaseToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.closeDatabaseToolStripMenuItem.Text = "Close Database";
            this.closeDatabaseToolStripMenuItem.ToolTipText = "Close the database so that you can open another.";
            this.closeDatabaseToolStripMenuItem.Click += new System.EventHandler(this.closeDatabaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exits this program, closing the database.";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wARNINGThisIsForAdvancedUsersAndDevelopersOnlyToolStripMenuItem,
            this.toolStripSeparator3,
            this.changeAppIDOfCacheToolStripMenuItem,
            this.executeSQLToolStripMenuItem});
            this.debugToolStripMenuItem.Enabled = false;
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // wARNINGThisIsForAdvancedUsersAndDevelopersOnlyToolStripMenuItem
            // 
            this.wARNINGThisIsForAdvancedUsersAndDevelopersOnlyToolStripMenuItem.Enabled = false;
            this.wARNINGThisIsForAdvancedUsersAndDevelopersOnlyToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wARNINGThisIsForAdvancedUsersAndDevelopersOnlyToolStripMenuItem.Name = "wARNINGThisIsForAdvancedUsersAndDevelopersOnlyToolStripMenuItem";
            this.wARNINGThisIsForAdvancedUsersAndDevelopersOnlyToolStripMenuItem.Size = new System.Drawing.Size(400, 22);
            this.wARNINGThisIsForAdvancedUsersAndDevelopersOnlyToolStripMenuItem.Text = "WARNING: This is for advanced users and developers only.";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(397, 6);
            // 
            // changeAppIDOfCacheToolStripMenuItem
            // 
            this.changeAppIDOfCacheToolStripMenuItem.Name = "changeAppIDOfCacheToolStripMenuItem";
            this.changeAppIDOfCacheToolStripMenuItem.Size = new System.Drawing.Size(400, 22);
            this.changeAppIDOfCacheToolStripMenuItem.Text = "Change AppID of cache";
            this.changeAppIDOfCacheToolStripMenuItem.Click += new System.EventHandler(this.changeAppIDOfCacheToolStripMenuItem_Click);
            // 
            // executeSQLToolStripMenuItem
            // 
            this.executeSQLToolStripMenuItem.Name = "executeSQLToolStripMenuItem";
            this.executeSQLToolStripMenuItem.Size = new System.Drawing.Size(400, 22);
            this.executeSQLToolStripMenuItem.Text = "Execute SQL";
            this.executeSQLToolStripMenuItem.Click += new System.EventHandler(this.executeSQLToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator4,
            this.websiteToolStripMenuItem,
            this.researchForumThreadToolStripMenuItem,
            this.toolStripSeparator5,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(186, 6);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.websiteToolStripMenuItem.Text = "Official Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // researchForumThreadToolStripMenuItem
            // 
            this.researchForumThreadToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.researchForumThreadToolStripMenuItem.Name = "researchForumThreadToolStripMenuItem";
            this.researchForumThreadToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.researchForumThreadToolStripMenuItem.Text = "Research Forum Thread";
            this.researchForumThreadToolStripMenuItem.Click += new System.EventHandler(this.researchForumThreadToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(186, 6);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // WelcomeGroup
            // 
            this.WelcomeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeGroup.Controls.Add(this.BigOpenButton);
            this.WelcomeGroup.Controls.Add(this.label1);
            this.WelcomeGroup.Location = new System.Drawing.Point(71, 44);
            this.WelcomeGroup.Name = "WelcomeGroup";
            this.WelcomeGroup.Size = new System.Drawing.Size(512, 232);
            this.WelcomeGroup.TabIndex = 2;
            this.WelcomeGroup.TabStop = false;
            this.WelcomeGroup.Text = "Welcome";
            // 
            // BigOpenButton
            // 
            this.BigOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BigOpenButton.Location = new System.Drawing.Point(184, 160);
            this.BigOpenButton.Name = "BigOpenButton";
            this.BigOpenButton.Size = new System.Drawing.Size(144, 40);
            this.BigOpenButton.TabIndex = 1;
            this.BigOpenButton.Text = "Open Database";
            this.BigOpenButton.UseVisualStyleBackColor = true;
            this.BigOpenButton.Click += new System.EventHandler(this.BigOpenButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SaveDDSDialogue
            // 
            this.SaveDDSDialogue.DefaultExt = "dds";
            this.SaveDDSDialogue.Filter = "DDS Image|*.dds|BIK Video|*.bik";
            this.SaveDDSDialogue.Title = "Where do you want to save the image to?";
            // 
            // LoadDDSDialogue
            // 
            this.LoadDDSDialogue.Filter = "DDS Images|*.dds|BIK Video|*.bik";
            this.LoadDDSDialogue.Title = "Select the DDS image to import.  It must be the same size.";
            // 
            // OpenAdpackDialogue
            // 
            this.OpenAdpackDialogue.Filter = "Battlefield 2142 Adpack Files (*.adpack)|*.adpack";
            this.OpenAdpackDialogue.Title = "Please select an adpack file to import.";
            // 
            // HintToolTip
            // 
            this.HintToolTip.IsBalloon = true;
            this.HintToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.HintToolTip.ToolTipTitle = "Information";
            // 
            // AdContextMenu
            // 
            this.AdContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.editItemContext,
            this.deleteItemContext,
            this.menuItem3,
            this.previewImageContext,
            this.importImageContext,
            this.exportImageContext});
            // 
            // editItemContext
            // 
            this.editItemContext.Index = 0;
            this.editItemContext.Text = "Edit Item";
            this.editItemContext.Click += new System.EventHandler(this.EditRecordButton_Click);
            // 
            // deleteItemContext
            // 
            this.deleteItemContext.Index = 1;
            this.deleteItemContext.Text = "Delete Item";
            this.deleteItemContext.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "-";
            // 
            // previewImageContext
            // 
            this.previewImageContext.Enabled = false;
            this.previewImageContext.Index = 3;
            this.previewImageContext.Text = "Preview Image";
            // 
            // importImageContext
            // 
            this.importImageContext.Index = 4;
            this.importImageContext.Text = "Import Image";
            this.importImageContext.Click += new System.EventHandler(this.ImportImageButton_Click);
            // 
            // exportImageContext
            // 
            this.exportImageContext.Index = 5;
            this.exportImageContext.Text = "Export Image";
            this.exportImageContext.Click += new System.EventHandler(this.SaveAdImageButton_Click);
            // 
            // ImagePreviewGroup
            // 
            this.ImagePreviewGroup.Controls.Add(this.PreviewCloseButton);
            this.ImagePreviewGroup.Controls.Add(this.PreviewBox);
            this.ImagePreviewGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePreviewGroup.Location = new System.Drawing.Point(0, 24);
            this.ImagePreviewGroup.Name = "ImagePreviewGroup";
            this.ImagePreviewGroup.Size = new System.Drawing.Size(655, 299);
            this.ImagePreviewGroup.TabIndex = 3;
            this.ImagePreviewGroup.TabStop = false;
            this.ImagePreviewGroup.Text = "Image Preview (click image to close)";
            this.ImagePreviewGroup.Visible = false;
            // 
            // PreviewCloseButton
            // 
            this.PreviewCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewCloseButton.Location = new System.Drawing.Point(591, 0);
            this.PreviewCloseButton.Name = "PreviewCloseButton";
            this.PreviewCloseButton.Size = new System.Drawing.Size(59, 24);
            this.PreviewCloseButton.TabIndex = 9;
            this.PreviewCloseButton.Text = "&Close";
            this.PreviewCloseButton.UseVisualStyleBackColor = true;
            this.PreviewCloseButton.Click += new System.EventHandler(this.PreviewBox_Click);
            // 
            // PreviewBox
            // 
            this.PreviewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewBox.Location = new System.Drawing.Point(3, 16);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(649, 280);
            this.PreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreviewBox.TabIndex = 8;
            this.PreviewBox.TabStop = false;
            this.PreviewBox.Click += new System.EventHandler(this.PreviewBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(655, 323);
            this.Controls.Add(this.EditingGroup);
            this.Controls.Add(this.ImagePreviewGroup);
            this.Controls.Add(this.WelcomeGroup);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "IGA Ad Cache Editor by micolous";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.EditingGroup.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.WelcomeGroup.ResumeLayout(false);
            this.WelcomeGroup.PerformLayout();
            this.ImagePreviewGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenDatabaseDialogue;
        private System.Windows.Forms.GroupBox EditingGroup;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox WelcomeGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BigOpenButton;
        private System.Windows.Forms.ListView CacheEntryList;
        private System.Windows.Forms.ColumnHeader contentId;
        private System.Windows.Forms.ColumnHeader active;
        private System.Windows.Forms.ColumnHeader activate;
        private System.Windows.Forms.ColumnHeader expire;
        private System.Windows.Forms.ColumnHeader dayparts;
        private System.Windows.Forms.ColumnHeader imageSize;
        private System.Windows.Forms.ColumnHeader viewCount;
        private System.Windows.Forms.Button SaveAdImageButton;
        private System.Windows.Forms.SaveFileDialog SaveDDSDialogue;
        private System.Windows.Forms.Button ImportImageButton;
        private System.Windows.Forms.OpenFileDialog LoadDDSDialogue;
        private System.Windows.Forms.Button EditRecordButton;
        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.Button DeleteRecordButton;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importAdpackFilebfadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAdpackFilebfadsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenAdpackDialogue;
        private System.Windows.Forms.ColumnHeader isVideo;
        private System.Windows.Forms.ToolStripMenuItem closeDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacuumDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolTip HintToolTip;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem researchForumThreadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.Button PreviewImageButton;
        private System.Windows.Forms.ContextMenu AdContextMenu;
        private System.Windows.Forms.MenuItem editItemContext;
        private System.Windows.Forms.MenuItem deleteItemContext;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem previewImageContext;
        private System.Windows.Forms.MenuItem importImageContext;
        private System.Windows.Forms.MenuItem exportImageContext;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeAppIDOfCacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wARNINGThisIsForAdvancedUsersAndDevelopersOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.GroupBox ImagePreviewGroup;
        private System.Windows.Forms.PictureBox PreviewBox;
        private System.Windows.Forms.Button PreviewCloseButton;
    }
}

