namespace Starbounder
{
    partial class FormMain
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
			this.treeViewFolder = new System.Windows.Forms.TreeView();
			this.contextMenuStripTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.materialItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.liquidItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.weaponsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.swordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thrownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.miningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.beamaxeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.harvestingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.armorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.headToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.legsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consumableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.liquidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.framesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorActions = new System.Windows.Forms.ToolStripSeparator();
			this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.starboundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.unpackAssetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStripTreeView.SuspendLayout();
			this.menuStripMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeViewFolder
			// 
			this.treeViewFolder.BackColor = System.Drawing.SystemColors.Control;
			this.treeViewFolder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewFolder.Location = new System.Drawing.Point(0, 24);
			this.treeViewFolder.Name = "treeViewFolder";
			this.treeViewFolder.Size = new System.Drawing.Size(284, 437);
			this.treeViewFolder.TabIndex = 0;
			this.treeViewFolder.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewFolder_NodeMouseClick);
			this.treeViewFolder.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewFolder_NodeMouseDoubleClick);
			// 
			// contextMenuStripTreeView
			// 
			this.contextMenuStripTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem,
            this.weaponsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.armorsToolStripMenuItem,
            this.otherToolStripMenuItem,
            this.toolStripSeparatorActions,
            this.actionsToolStripMenuItem});
			this.contextMenuStripTreeView.Name = "contextMenuStripTreeView";
			this.contextMenuStripTreeView.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.contextMenuStripTreeView.Size = new System.Drawing.Size(124, 142);
			// 
			// itemsToolStripMenuItem
			// 
			this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem,
            this.materialItemToolStripMenuItem,
            this.liquidItemToolStripMenuItem});
			this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
			this.itemsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.itemsToolStripMenuItem.Text = "Items";
			// 
			// itemToolStripMenuItem
			// 
			this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
			this.itemToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.itemToolStripMenuItem.Text = "Item";
			this.itemToolStripMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
			// 
			// materialItemToolStripMenuItem
			// 
			this.materialItemToolStripMenuItem.Name = "materialItemToolStripMenuItem";
			this.materialItemToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.materialItemToolStripMenuItem.Text = "Material Item";
			this.materialItemToolStripMenuItem.Click += new System.EventHandler(this.materialItemToolStripMenuItem_Click);
			// 
			// liquidItemToolStripMenuItem
			// 
			this.liquidItemToolStripMenuItem.Name = "liquidItemToolStripMenuItem";
			this.liquidItemToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.liquidItemToolStripMenuItem.Text = "Liquid Item";
			this.liquidItemToolStripMenuItem.Click += new System.EventHandler(this.liquidItemToolStripMenuItem_Click);
			// 
			// weaponsToolStripMenuItem
			// 
			this.weaponsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.swordToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.gunToolStripMenuItem,
            this.thrownToolStripMenuItem});
			this.weaponsToolStripMenuItem.Name = "weaponsToolStripMenuItem";
			this.weaponsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.weaponsToolStripMenuItem.Text = "Weapons";
			// 
			// swordToolStripMenuItem
			// 
			this.swordToolStripMenuItem.Name = "swordToolStripMenuItem";
			this.swordToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.swordToolStripMenuItem.Text = "Sword";
			this.swordToolStripMenuItem.Click += new System.EventHandler(this.swordToolStripMenuItem_Click);
			// 
			// staffToolStripMenuItem
			// 
			this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
			this.staffToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.staffToolStripMenuItem.Text = "Staff";
			this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
			// 
			// gunToolStripMenuItem
			// 
			this.gunToolStripMenuItem.Name = "gunToolStripMenuItem";
			this.gunToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.gunToolStripMenuItem.Text = "Gun";
			this.gunToolStripMenuItem.Click += new System.EventHandler(this.gunToolStripMenuItem_Click);
			// 
			// thrownToolStripMenuItem
			// 
			this.thrownToolStripMenuItem.Name = "thrownToolStripMenuItem";
			this.thrownToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.thrownToolStripMenuItem.Text = "Thrown";
			this.thrownToolStripMenuItem.Click += new System.EventHandler(this.thrownToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miningToolStripMenuItem,
            this.beamaxeToolStripMenuItem,
            this.harvestingToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// miningToolStripMenuItem
			// 
			this.miningToolStripMenuItem.Name = "miningToolStripMenuItem";
			this.miningToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.miningToolStripMenuItem.Text = "Mining";
			this.miningToolStripMenuItem.Click += new System.EventHandler(this.miningToolStripMenuItem_Click);
			// 
			// beamaxeToolStripMenuItem
			// 
			this.beamaxeToolStripMenuItem.Name = "beamaxeToolStripMenuItem";
			this.beamaxeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.beamaxeToolStripMenuItem.Text = "Beamaxe";
			this.beamaxeToolStripMenuItem.Click += new System.EventHandler(this.beamaxeToolStripMenuItem_Click);
			// 
			// harvestingToolStripMenuItem
			// 
			this.harvestingToolStripMenuItem.Name = "harvestingToolStripMenuItem";
			this.harvestingToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.harvestingToolStripMenuItem.Text = "Harvesting";
			this.harvestingToolStripMenuItem.Click += new System.EventHandler(this.harvestingToolStripMenuItem_Click);
			// 
			// armorsToolStripMenuItem
			// 
			this.armorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headToolStripMenuItem,
            this.chestToolStripMenuItem,
            this.legsToolStripMenuItem,
            this.backToolStripMenuItem});
			this.armorsToolStripMenuItem.Name = "armorsToolStripMenuItem";
			this.armorsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.armorsToolStripMenuItem.Text = "Armors";
			// 
			// headToolStripMenuItem
			// 
			this.headToolStripMenuItem.Name = "headToolStripMenuItem";
			this.headToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.headToolStripMenuItem.Text = "Head";
			this.headToolStripMenuItem.Click += new System.EventHandler(this.headToolStripMenuItem_Click);
			// 
			// chestToolStripMenuItem
			// 
			this.chestToolStripMenuItem.Name = "chestToolStripMenuItem";
			this.chestToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.chestToolStripMenuItem.Text = "Chest";
			this.chestToolStripMenuItem.Click += new System.EventHandler(this.chestToolStripMenuItem_Click);
			// 
			// legsToolStripMenuItem
			// 
			this.legsToolStripMenuItem.Name = "legsToolStripMenuItem";
			this.legsToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.legsToolStripMenuItem.Text = "Legs";
			this.legsToolStripMenuItem.Click += new System.EventHandler(this.legsToolStripMenuItem_Click);
			// 
			// backToolStripMenuItem
			// 
			this.backToolStripMenuItem.Name = "backToolStripMenuItem";
			this.backToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.backToolStripMenuItem.Text = "Back";
			this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
			// 
			// otherToolStripMenuItem
			// 
			this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consumableToolStripMenuItem,
            this.liquidToolStripMenuItem,
            this.framesToolStripMenuItem});
			this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
			this.otherToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.otherToolStripMenuItem.Text = "Other";
			// 
			// consumableToolStripMenuItem
			// 
			this.consumableToolStripMenuItem.Name = "consumableToolStripMenuItem";
			this.consumableToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.consumableToolStripMenuItem.Text = "Consumable";
			this.consumableToolStripMenuItem.Click += new System.EventHandler(this.consumableToolStripMenuItem_Click);
			// 
			// liquidToolStripMenuItem
			// 
			this.liquidToolStripMenuItem.Name = "liquidToolStripMenuItem";
			this.liquidToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.liquidToolStripMenuItem.Text = "Liquid";
			this.liquidToolStripMenuItem.Click += new System.EventHandler(this.liquidToolStripMenuItem_Click);
			// 
			// framesToolStripMenuItem
			// 
			this.framesToolStripMenuItem.Name = "framesToolStripMenuItem";
			this.framesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.framesToolStripMenuItem.Text = "Frames";
			this.framesToolStripMenuItem.Click += new System.EventHandler(this.framesToolStripMenuItem_Click);
			// 
			// toolStripSeparatorActions
			// 
			this.toolStripSeparatorActions.Name = "toolStripSeparatorActions";
			this.toolStripSeparatorActions.Size = new System.Drawing.Size(120, 6);
			// 
			// actionsToolStripMenuItem
			// 
			this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.moveToolStripMenuItem});
			this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
			this.actionsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.actionsToolStripMenuItem.Text = "Actions";
			// 
			// newFolderToolStripMenuItem
			// 
			this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
			this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.newFolderToolStripMenuItem.Text = "New Folder";
			this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
			// 
			// renameToolStripMenuItem
			// 
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.renameToolStripMenuItem.Text = "Rename";
			this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// moveToolStripMenuItem
			// 
			this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
			this.moveToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.moveToolStripMenuItem.Text = "Move";
			this.moveToolStripMenuItem.Click += new System.EventHandler(this.moveToolStripMenuItem_Click);
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.refreshToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(284, 24);
			this.menuStripMain.TabIndex = 1;
			this.menuStripMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.loadProjectToolStripMenuItem,
            this.starboundToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newProjectToolStripMenuItem
			// 
			this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
			this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.newProjectToolStripMenuItem.Text = "New Project";
			this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
			// 
			// loadProjectToolStripMenuItem
			// 
			this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
			this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.loadProjectToolStripMenuItem.Text = "Load Project";
			this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.loadProjectToolStripMenuItem_Click);
			// 
			// starboundToolStripMenuItem
			// 
			this.starboundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.fileExplorerToolStripMenuItem,
            this.unpackAssetsToolStripMenuItem});
			this.starboundToolStripMenuItem.Name = "starboundToolStripMenuItem";
			this.starboundToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
			this.starboundToolStripMenuItem.Text = "Starbound";
			// 
			// playToolStripMenuItem
			// 
			this.playToolStripMenuItem.Name = "playToolStripMenuItem";
			this.playToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.playToolStripMenuItem.Text = "Play";
			this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
			// 
			// fileExplorerToolStripMenuItem
			// 
			this.fileExplorerToolStripMenuItem.Name = "fileExplorerToolStripMenuItem";
			this.fileExplorerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.fileExplorerToolStripMenuItem.Text = "File Explorer";
			this.fileExplorerToolStripMenuItem.Click += new System.EventHandler(this.fileExplorerToolStripMenuItem_Click);
			// 
			// unpackAssetsToolStripMenuItem
			// 
			this.unpackAssetsToolStripMenuItem.Name = "unpackAssetsToolStripMenuItem";
			this.unpackAssetsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.unpackAssetsToolStripMenuItem.Text = "Unpack Assets";
			this.unpackAssetsToolStripMenuItem.Click += new System.EventHandler(this.unpackAssetsToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 461);
			this.Controls.Add(this.treeViewFolder);
			this.Controls.Add(this.menuStripMain);
			this.MainMenuStrip = this.menuStripMain;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMain";
			this.Text = "Starbounder - Version 1.0.0";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.contextMenuStripTreeView.ResumeLayout(false);
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewFolder;
		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeView;
		private System.Windows.Forms.ToolStripMenuItem armorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem headToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem chestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem legsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem materialItemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem liquidItemToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem weaponsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem swordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gunToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thrownToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem miningToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem beamaxeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem harvestingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem starboundToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileExplorerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem unpackAssetsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consumableToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem liquidToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorActions;
		private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem framesToolStripMenuItem;
	}
}