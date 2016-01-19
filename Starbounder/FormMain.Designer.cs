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
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitterTreeView = new System.Windows.Forms.Splitter();
			this.contextMenuStripTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStripMain.SuspendLayout();
			this.contextMenuStripTreeView.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeViewFolder
			// 
			this.treeViewFolder.BackColor = System.Drawing.SystemColors.Control;
			this.treeViewFolder.ContextMenuStrip = this.contextMenuStripTreeView;
			this.treeViewFolder.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeViewFolder.Location = new System.Drawing.Point(0, 24);
			this.treeViewFolder.Name = "treeViewFolder";
			this.treeViewFolder.Size = new System.Drawing.Size(200, 572);
			this.treeViewFolder.TabIndex = 0;
			this.treeViewFolder.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewFolder_NodeMouseDoubleClick);
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
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
            this.loadProjectToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newProjectToolStripMenuItem
			// 
			this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
			this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newProjectToolStripMenuItem.Text = "New Project";
			this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
			// 
			// loadProjectToolStripMenuItem
			// 
			this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
			this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.loadProjectToolStripMenuItem.Text = "Load Project";
			this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.loadProjectToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// splitterTreeView
			// 
			this.splitterTreeView.Location = new System.Drawing.Point(200, 24);
			this.splitterTreeView.Name = "splitterTreeView";
			this.splitterTreeView.Size = new System.Drawing.Size(3, 572);
			this.splitterTreeView.TabIndex = 2;
			this.splitterTreeView.TabStop = false;
			// 
			// contextMenuStripTreeView
			// 
			this.contextMenuStripTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem});
			this.contextMenuStripTreeView.Name = "contextMenuStripTreeView";
			this.contextMenuStripTreeView.Size = new System.Drawing.Size(108, 26);
			// 
			// folderToolStripMenuItem
			// 
			this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
			this.folderToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.folderToolStripMenuItem.Text = "Folder";
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
			this.Text = "FormMain";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.contextMenuStripTreeView.ResumeLayout(false);
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
		private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
	}
}