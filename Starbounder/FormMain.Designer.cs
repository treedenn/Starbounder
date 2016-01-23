﻿namespace Starbounder
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
			this.consumableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.unpackStarboundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitterTreeView = new System.Windows.Forms.Splitter();
			this.contextMenuStripTreeView.SuspendLayout();
			this.menuStripMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeViewFolder
			// 
			this.treeViewFolder.BackColor = System.Drawing.SystemColors.Control;
			this.treeViewFolder.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeViewFolder.Location = new System.Drawing.Point(0, 24);
			this.treeViewFolder.Name = "treeViewFolder";
			this.treeViewFolder.Size = new System.Drawing.Size(200, 572);
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
            this.consumableToolStripMenuItem});
			this.contextMenuStripTreeView.Name = "contextMenuStripTreeView";
			this.contextMenuStripTreeView.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.contextMenuStripTreeView.Size = new System.Drawing.Size(153, 136);
			// 
			// itemsToolStripMenuItem
			// 
			this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem,
            this.materialItemToolStripMenuItem,
            this.liquidItemToolStripMenuItem});
			this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
			this.itemsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
			this.weaponsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// miningToolStripMenuItem
			// 
			this.miningToolStripMenuItem.Name = "miningToolStripMenuItem";
			this.miningToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.miningToolStripMenuItem.Text = "Mining";
			this.miningToolStripMenuItem.Click += new System.EventHandler(this.miningToolStripMenuItem_Click);
			// 
			// beamaxeToolStripMenuItem
			// 
			this.beamaxeToolStripMenuItem.Name = "beamaxeToolStripMenuItem";
			this.beamaxeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.beamaxeToolStripMenuItem.Text = "Beamaxe";
			this.beamaxeToolStripMenuItem.Click += new System.EventHandler(this.beamaxeToolStripMenuItem_Click);
			// 
			// harvestingToolStripMenuItem
			// 
			this.harvestingToolStripMenuItem.Name = "harvestingToolStripMenuItem";
			this.harvestingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
			this.armorsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
			// consumableToolStripMenuItem
			// 
			this.consumableToolStripMenuItem.Name = "consumableToolStripMenuItem";
			this.consumableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.consumableToolStripMenuItem.Text = "Consumable";
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.refreshToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(974, 24);
			this.menuStripMain.TabIndex = 1;
			this.menuStripMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.loadProjectToolStripMenuItem,
            this.unpackStarboundToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newProjectToolStripMenuItem
			// 
			this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
			this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.newProjectToolStripMenuItem.Text = "New Project";
			this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
			// 
			// loadProjectToolStripMenuItem
			// 
			this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
			this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.loadProjectToolStripMenuItem.Text = "Load Project";
			this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.loadProjectToolStripMenuItem_Click);
			// 
			// unpackStarboundToolStripMenuItem
			// 
			this.unpackStarboundToolStripMenuItem.Name = "unpackStarboundToolStripMenuItem";
			this.unpackStarboundToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
			this.unpackStarboundToolStripMenuItem.Text = "Unpack Starbound";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.refreshToolStripMenuItem.Text = "Refresh";
			// 
			// splitterTreeView
			// 
			this.splitterTreeView.Location = new System.Drawing.Point(200, 24);
			this.splitterTreeView.Name = "splitterTreeView";
			this.splitterTreeView.Size = new System.Drawing.Size(3, 572);
			this.splitterTreeView.TabIndex = 2;
			this.splitterTreeView.TabStop = false;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(974, 596);
			this.Controls.Add(this.splitterTreeView);
			this.Controls.Add(this.treeViewFolder);
			this.Controls.Add(this.menuStripMain);
			this.MainMenuStrip = this.menuStripMain;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormMain";
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
		private System.Windows.Forms.Splitter splitterTreeView;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripTreeView;
		private System.Windows.Forms.ToolStripMenuItem unpackStarboundToolStripMenuItem;
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
		private System.Windows.Forms.ToolStripMenuItem consumableToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
	}
}