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
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webResourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTIsCompressonatorDDSConverteradvancedUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nVidiaDDSPhotoshopPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nVidiaDDSWindowsExplorerThumbnailerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rADVideoToolsforCreatingBINKVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.researchForumThreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theGIMPopenSourceImageEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theGIMPDDSPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.subversionSourceCodeRepositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditingGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.WelcomeGroup.SuspendLayout();
            this.ImagePreviewGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenDatabaseDialogue
            // 
            resources.ApplyResources(this.OpenDatabaseDialogue, "OpenDatabaseDialogue");
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
            resources.ApplyResources(this.EditingGroup, "EditingGroup");
            this.EditingGroup.Name = "EditingGroup";
            this.EditingGroup.TabStop = false;
            // 
            // PreviewImageButton
            // 
            resources.ApplyResources(this.PreviewImageButton, "PreviewImageButton");
            this.PreviewImageButton.Name = "PreviewImageButton";
            this.PreviewImageButton.UseVisualStyleBackColor = true;
            this.PreviewImageButton.Click += new System.EventHandler(this.PreviewImageButton_Click);
            // 
            // AddRecordButton
            // 
            resources.ApplyResources(this.AddRecordButton, "AddRecordButton");
            this.AddRecordButton.Name = "AddRecordButton";
            this.HintToolTip.SetToolTip(this.AddRecordButton, resources.GetString("AddRecordButton.ToolTip"));
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // DeleteRecordButton
            // 
            resources.ApplyResources(this.DeleteRecordButton, "DeleteRecordButton");
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.HintToolTip.SetToolTip(this.DeleteRecordButton, resources.GetString("DeleteRecordButton.ToolTip"));
            this.DeleteRecordButton.UseVisualStyleBackColor = true;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // EditRecordButton
            // 
            resources.ApplyResources(this.EditRecordButton, "EditRecordButton");
            this.EditRecordButton.Name = "EditRecordButton";
            this.HintToolTip.SetToolTip(this.EditRecordButton, resources.GetString("EditRecordButton.ToolTip"));
            this.EditRecordButton.UseVisualStyleBackColor = true;
            this.EditRecordButton.Click += new System.EventHandler(this.EditRecordButton_Click);
            // 
            // ImportImageButton
            // 
            resources.ApplyResources(this.ImportImageButton, "ImportImageButton");
            this.ImportImageButton.Name = "ImportImageButton";
            this.HintToolTip.SetToolTip(this.ImportImageButton, resources.GetString("ImportImageButton.ToolTip"));
            this.ImportImageButton.UseVisualStyleBackColor = true;
            this.ImportImageButton.Click += new System.EventHandler(this.ImportImageButton_Click);
            // 
            // SaveAdImageButton
            // 
            resources.ApplyResources(this.SaveAdImageButton, "SaveAdImageButton");
            this.SaveAdImageButton.Name = "SaveAdImageButton";
            this.HintToolTip.SetToolTip(this.SaveAdImageButton, resources.GetString("SaveAdImageButton.ToolTip"));
            this.SaveAdImageButton.UseVisualStyleBackColor = true;
            this.SaveAdImageButton.Click += new System.EventHandler(this.SaveAdImageButton_Click);
            // 
            // CacheEntryList
            // 
            resources.ApplyResources(this.CacheEntryList, "CacheEntryList");
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
            this.CacheEntryList.MultiSelect = false;
            this.CacheEntryList.Name = "CacheEntryList";
            this.CacheEntryList.UseCompatibleStateImageBehavior = false;
            this.CacheEntryList.View = System.Windows.Forms.View.Details;
            this.CacheEntryList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CacheEntryList_MouseClick);
            this.CacheEntryList.DoubleClick += new System.EventHandler(this.EditRecordButton_Click);
            // 
            // contentId
            // 
            resources.ApplyResources(this.contentId, "contentId");
            // 
            // active
            // 
            resources.ApplyResources(this.active, "active");
            // 
            // activate
            // 
            resources.ApplyResources(this.activate, "activate");
            // 
            // expire
            // 
            resources.ApplyResources(this.expire, "expire");
            // 
            // dayparts
            // 
            resources.ApplyResources(this.dayparts, "dayparts");
            // 
            // imageSize
            // 
            resources.ApplyResources(this.imageSize, "imageSize");
            // 
            // isVideo
            // 
            resources.ApplyResources(this.isVideo, "isVideo");
            // 
            // viewCount
            // 
            resources.ApplyResources(this.viewCount, "viewCount");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
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
            resources.ApplyResources(this.databaseToolStripMenuItem, "databaseToolStripMenuItem");
            // 
            // importAdpackFilebfadsToolStripMenuItem
            // 
            resources.ApplyResources(this.importAdpackFilebfadsToolStripMenuItem, "importAdpackFilebfadsToolStripMenuItem");
            this.importAdpackFilebfadsToolStripMenuItem.Name = "importAdpackFilebfadsToolStripMenuItem";
            this.importAdpackFilebfadsToolStripMenuItem.Click += new System.EventHandler(this.importAdpackFilebfadsToolStripMenuItem_Click);
            // 
            // exportAdpackFilebfadsToolStripMenuItem
            // 
            resources.ApplyResources(this.exportAdpackFilebfadsToolStripMenuItem, "exportAdpackFilebfadsToolStripMenuItem");
            this.exportAdpackFilebfadsToolStripMenuItem.Name = "exportAdpackFilebfadsToolStripMenuItem";
            this.exportAdpackFilebfadsToolStripMenuItem.Click += new System.EventHandler(this.exportAdpackFilebfadsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // refreshToolStripMenuItem
            // 
            resources.ApplyResources(this.refreshToolStripMenuItem, "refreshToolStripMenuItem");
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshDatabaseMenuItem_Click);
            // 
            // vacuumDatabaseToolStripMenuItem
            // 
            resources.ApplyResources(this.vacuumDatabaseToolStripMenuItem, "vacuumDatabaseToolStripMenuItem");
            this.vacuumDatabaseToolStripMenuItem.Name = "vacuumDatabaseToolStripMenuItem";
            this.vacuumDatabaseToolStripMenuItem.Click += new System.EventHandler(this.vacuumDatabaseToolStripMenuItem_Click);
            // 
            // closeDatabaseToolStripMenuItem
            // 
            resources.ApplyResources(this.closeDatabaseToolStripMenuItem, "closeDatabaseToolStripMenuItem");
            this.closeDatabaseToolStripMenuItem.Name = "closeDatabaseToolStripMenuItem";
            this.closeDatabaseToolStripMenuItem.Click += new System.EventHandler(this.closeDatabaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wARNINGThisIsForAdvancedUsersAndDevelopersOnlyToolStripMenuItem,
            this.toolStripSeparator3,
            this.changeAppIDOfCacheToolStripMenuItem,
            this.executeSQLToolStripMenuItem});
            resources.ApplyResources(this.debugToolStripMenuItem, "debugToolStripMenuItem");
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            // 
            // wARNINGThisIsForAdvancedUsersAndDevelopersOnlyToolStripMenuItem
            // 
            resources.ApplyResources(this.wARNINGThisIsForAdvancedUsersAndDevelopersOnlyToolStripMenuItem, "wARNINGThisIsForAdvancedUsersAndDevelopersOnlyToolStripMenuItem");
            this.wARNINGThisIsForAdvancedUsersAndDevelopersOnlyToolStripMenuItem.Name = "wARNINGThisIsForAdvancedUsersAndDevelopersOnlyToolStripMenuItem";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // changeAppIDOfCacheToolStripMenuItem
            // 
            this.changeAppIDOfCacheToolStripMenuItem.Name = "changeAppIDOfCacheToolStripMenuItem";
            resources.ApplyResources(this.changeAppIDOfCacheToolStripMenuItem, "changeAppIDOfCacheToolStripMenuItem");
            this.changeAppIDOfCacheToolStripMenuItem.Click += new System.EventHandler(this.changeAppIDOfCacheToolStripMenuItem_Click);
            // 
            // executeSQLToolStripMenuItem
            // 
            this.executeSQLToolStripMenuItem.Name = "executeSQLToolStripMenuItem";
            resources.ApplyResources(this.executeSQLToolStripMenuItem, "executeSQLToolStripMenuItem");
            this.executeSQLToolStripMenuItem.Click += new System.EventHandler(this.executeSQLToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator4,
            this.websiteToolStripMenuItem,
            this.webResourcesToolStripMenuItem,
            this.toolStripSeparator5,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // websiteToolStripMenuItem
            // 
            resources.ApplyResources(this.websiteToolStripMenuItem, "websiteToolStripMenuItem");
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.websiteToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            resources.ApplyResources(this.checkForUpdatesToolStripMenuItem, "checkForUpdatesToolStripMenuItem");
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // webResourcesToolStripMenuItem
            // 
            this.webResourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aTIsCompressonatorDDSConverteradvancedUsersToolStripMenuItem,
            this.nVidiaDDSPhotoshopPluginToolStripMenuItem,
            this.nVidiaDDSWindowsExplorerThumbnailerToolStripMenuItem,
            this.rADVideoToolsforCreatingBINKVideoToolStripMenuItem,
            this.researchForumThreadToolStripMenuItem,
            this.subversionSourceCodeRepositoryToolStripMenuItem,
            this.theGIMPopenSourceImageEditorToolStripMenuItem,
            this.theGIMPDDSPluginToolStripMenuItem});
            this.webResourcesToolStripMenuItem.Name = "webResourcesToolStripMenuItem";
            resources.ApplyResources(this.webResourcesToolStripMenuItem, "webResourcesToolStripMenuItem");
            // 
            // aTIsCompressonatorDDSConverteradvancedUsersToolStripMenuItem
            // 
            this.aTIsCompressonatorDDSConverteradvancedUsersToolStripMenuItem.Name = "aTIsCompressonatorDDSConverteradvancedUsersToolStripMenuItem";
            resources.ApplyResources(this.aTIsCompressonatorDDSConverteradvancedUsersToolStripMenuItem, "aTIsCompressonatorDDSConverteradvancedUsersToolStripMenuItem");
            this.aTIsCompressonatorDDSConverteradvancedUsersToolStripMenuItem.Click += new System.EventHandler(this.aTIsCompressonatorDDSConverteradvancedUsersToolStripMenuItem_Click);
            // 
            // nVidiaDDSPhotoshopPluginToolStripMenuItem
            // 
            this.nVidiaDDSPhotoshopPluginToolStripMenuItem.Name = "nVidiaDDSPhotoshopPluginToolStripMenuItem";
            resources.ApplyResources(this.nVidiaDDSPhotoshopPluginToolStripMenuItem, "nVidiaDDSPhotoshopPluginToolStripMenuItem");
            this.nVidiaDDSPhotoshopPluginToolStripMenuItem.Click += new System.EventHandler(this.nVidiaDDSPhotoshopPluginToolStripMenuItem_Click);
            // 
            // nVidiaDDSWindowsExplorerThumbnailerToolStripMenuItem
            // 
            this.nVidiaDDSWindowsExplorerThumbnailerToolStripMenuItem.Name = "nVidiaDDSWindowsExplorerThumbnailerToolStripMenuItem";
            resources.ApplyResources(this.nVidiaDDSWindowsExplorerThumbnailerToolStripMenuItem, "nVidiaDDSWindowsExplorerThumbnailerToolStripMenuItem");
            this.nVidiaDDSWindowsExplorerThumbnailerToolStripMenuItem.Click += new System.EventHandler(this.nVidiaDDSWindowsExplorerThumbnailerToolStripMenuItem_Click);
            // 
            // rADVideoToolsforCreatingBINKVideoToolStripMenuItem
            // 
            this.rADVideoToolsforCreatingBINKVideoToolStripMenuItem.Name = "rADVideoToolsforCreatingBINKVideoToolStripMenuItem";
            resources.ApplyResources(this.rADVideoToolsforCreatingBINKVideoToolStripMenuItem, "rADVideoToolsforCreatingBINKVideoToolStripMenuItem");
            this.rADVideoToolsforCreatingBINKVideoToolStripMenuItem.Click += new System.EventHandler(this.rADVideoToolsforCreatingBINKVideoToolStripMenuItem_Click);
            // 
            // researchForumThreadToolStripMenuItem
            // 
            resources.ApplyResources(this.researchForumThreadToolStripMenuItem, "researchForumThreadToolStripMenuItem");
            this.researchForumThreadToolStripMenuItem.Name = "researchForumThreadToolStripMenuItem";
            this.researchForumThreadToolStripMenuItem.Click += new System.EventHandler(this.researchForumThreadToolStripMenuItem_Click);
            // 
            // theGIMPopenSourceImageEditorToolStripMenuItem
            // 
            this.theGIMPopenSourceImageEditorToolStripMenuItem.Name = "theGIMPopenSourceImageEditorToolStripMenuItem";
            resources.ApplyResources(this.theGIMPopenSourceImageEditorToolStripMenuItem, "theGIMPopenSourceImageEditorToolStripMenuItem");
            this.theGIMPopenSourceImageEditorToolStripMenuItem.Click += new System.EventHandler(this.theGIMPopenSourceImageEditorToolStripMenuItem_Click);
            // 
            // theGIMPDDSPluginToolStripMenuItem
            // 
            this.theGIMPDDSPluginToolStripMenuItem.Name = "theGIMPDDSPluginToolStripMenuItem";
            resources.ApplyResources(this.theGIMPDDSPluginToolStripMenuItem, "theGIMPDDSPluginToolStripMenuItem");
            this.theGIMPDDSPluginToolStripMenuItem.Click += new System.EventHandler(this.theGIMPDDSPluginToolStripMenuItem_Click);
            // 
            // WelcomeGroup
            // 
            resources.ApplyResources(this.WelcomeGroup, "WelcomeGroup");
            this.WelcomeGroup.Controls.Add(this.BigOpenButton);
            this.WelcomeGroup.Controls.Add(this.label1);
            this.WelcomeGroup.Name = "WelcomeGroup";
            this.WelcomeGroup.TabStop = false;
            // 
            // BigOpenButton
            // 
            resources.ApplyResources(this.BigOpenButton, "BigOpenButton");
            this.BigOpenButton.Name = "BigOpenButton";
            this.BigOpenButton.UseVisualStyleBackColor = true;
            this.BigOpenButton.Click += new System.EventHandler(this.BigOpenButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // SaveDDSDialogue
            // 
            this.SaveDDSDialogue.DefaultExt = "dds";
            resources.ApplyResources(this.SaveDDSDialogue, "SaveDDSDialogue");
            // 
            // LoadDDSDialogue
            // 
            resources.ApplyResources(this.LoadDDSDialogue, "LoadDDSDialogue");
            // 
            // OpenAdpackDialogue
            // 
            resources.ApplyResources(this.OpenAdpackDialogue, "OpenAdpackDialogue");
            // 
            // HintToolTip
            // 
            resources.ApplyResources(this.HintToolTip, "HintToolTip");
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
            resources.ApplyResources(this.editItemContext, "editItemContext");
            this.editItemContext.Click += new System.EventHandler(this.EditRecordButton_Click);
            // 
            // deleteItemContext
            // 
            this.deleteItemContext.Index = 1;
            resources.ApplyResources(this.deleteItemContext, "deleteItemContext");
            this.deleteItemContext.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            resources.ApplyResources(this.menuItem3, "menuItem3");
            // 
            // previewImageContext
            // 
            this.previewImageContext.Index = 3;
            resources.ApplyResources(this.previewImageContext, "previewImageContext");
            this.previewImageContext.Click += new System.EventHandler(this.PreviewImageButton_Click);
            // 
            // importImageContext
            // 
            this.importImageContext.Index = 4;
            resources.ApplyResources(this.importImageContext, "importImageContext");
            this.importImageContext.Click += new System.EventHandler(this.ImportImageButton_Click);
            // 
            // exportImageContext
            // 
            this.exportImageContext.Index = 5;
            resources.ApplyResources(this.exportImageContext, "exportImageContext");
            this.exportImageContext.Click += new System.EventHandler(this.SaveAdImageButton_Click);
            // 
            // ImagePreviewGroup
            // 
            this.ImagePreviewGroup.Controls.Add(this.PreviewCloseButton);
            this.ImagePreviewGroup.Controls.Add(this.PreviewBox);
            resources.ApplyResources(this.ImagePreviewGroup, "ImagePreviewGroup");
            this.ImagePreviewGroup.Name = "ImagePreviewGroup";
            this.ImagePreviewGroup.TabStop = false;
            // 
            // PreviewCloseButton
            // 
            resources.ApplyResources(this.PreviewCloseButton, "PreviewCloseButton");
            this.PreviewCloseButton.Name = "PreviewCloseButton";
            this.PreviewCloseButton.UseVisualStyleBackColor = true;
            this.PreviewCloseButton.Click += new System.EventHandler(this.PreviewBox_Click);
            // 
            // PreviewBox
            // 
            resources.ApplyResources(this.PreviewBox, "PreviewBox");
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.TabStop = false;
            this.PreviewBox.Click += new System.EventHandler(this.PreviewBox_Click);
            // 
            // subversionSourceCodeRepositoryToolStripMenuItem
            // 
            this.subversionSourceCodeRepositoryToolStripMenuItem.Name = "subversionSourceCodeRepositoryToolStripMenuItem";
            resources.ApplyResources(this.subversionSourceCodeRepositoryToolStripMenuItem, "subversionSourceCodeRepositoryToolStripMenuItem");
            this.subversionSourceCodeRepositoryToolStripMenuItem.Click += new System.EventHandler(this.subversionSourceCodeRepositoryToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EditingGroup);
            this.Controls.Add(this.ImagePreviewGroup);
            this.Controls.Add(this.WelcomeGroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
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
        private System.Windows.Forms.ToolStripMenuItem webResourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem researchForumThreadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theGIMPopenSourceImageEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nVidiaDDSPhotoshopPluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nVidiaDDSWindowsExplorerThumbnailerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theGIMPDDSPluginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTIsCompressonatorDDSConverteradvancedUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rADVideoToolsforCreatingBINKVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subversionSourceCodeRepositoryToolStripMenuItem;
    }
}

