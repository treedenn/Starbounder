namespace Starbounder
{
    partial class FormConfiguration
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
			this.labelConfigSB = new System.Windows.Forms.Label();
			this.textBoxConfigSB = new System.Windows.Forms.TextBox();
			this.panelSystem = new System.Windows.Forms.Panel();
			this.radioButtonConfigWin32 = new System.Windows.Forms.RadioButton();
			this.radioButtonConfigWin64 = new System.Windows.Forms.RadioButton();
			this.buttonConfigBrowseSB = new System.Windows.Forms.Button();
			this.buttonConfigBrowseWork = new System.Windows.Forms.Button();
			this.textBoxConfigWork = new System.Windows.Forms.TextBox();
			this.labelConfigWork = new System.Windows.Forms.Label();
			this.buttonConfigContinue = new System.Windows.Forms.Button();
			this.labelConfigSBVersion = new System.Windows.Forms.Label();
			this.textBoxConfigSBVersion = new System.Windows.Forms.TextBox();
			this.textBoxConfigAuthor = new System.Windows.Forms.TextBox();
			this.labelConfigAuthor = new System.Windows.Forms.Label();
			this.textBoxConfigTextEditor = new System.Windows.Forms.TextBox();
			this.labelConfigTextEditor = new System.Windows.Forms.Label();
			this.textBoxConfigImageEditor = new System.Windows.Forms.TextBox();
			this.labelConfigImageEditor = new System.Windows.Forms.Label();
			this.buttonConfigBrowseImage = new System.Windows.Forms.Button();
			this.buttonConfigBrowseText = new System.Windows.Forms.Button();
			this.buttonConfigBrowseAssets = new System.Windows.Forms.Button();
			this.textBoxConfigAssets = new System.Windows.Forms.TextBox();
			this.labelConfigAssets = new System.Windows.Forms.Label();
			this.panelConfigDirectories = new System.Windows.Forms.Panel();
			this.panelConfigEditors = new System.Windows.Forms.Panel();
			this.panelConfigDefaultJSON = new System.Windows.Forms.Panel();
			this.buttonConfigClose = new System.Windows.Forms.Button();
			this.treeViewConfigMenu = new System.Windows.Forms.TreeView();
			this.panelSystem.SuspendLayout();
			this.panelConfigDirectories.SuspendLayout();
			this.panelConfigEditors.SuspendLayout();
			this.panelConfigDefaultJSON.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelConfigSB
			// 
			this.labelConfigSB.AutoSize = true;
			this.labelConfigSB.Location = new System.Drawing.Point(3, 3);
			this.labelConfigSB.Margin = new System.Windows.Forms.Padding(3);
			this.labelConfigSB.Name = "labelConfigSB";
			this.labelConfigSB.Size = new System.Drawing.Size(104, 13);
			this.labelConfigSB.TabIndex = 0;
			this.labelConfigSB.Text = "Starbound Directory:";
			// 
			// textBoxConfigSB
			// 
			this.textBoxConfigSB.Location = new System.Drawing.Point(6, 22);
			this.textBoxConfigSB.Name = "textBoxConfigSB";
			this.textBoxConfigSB.Size = new System.Drawing.Size(370, 20);
			this.textBoxConfigSB.TabIndex = 1;
			// 
			// panelSystem
			// 
			this.panelSystem.Controls.Add(this.radioButtonConfigWin32);
			this.panelSystem.Controls.Add(this.radioButtonConfigWin64);
			this.panelSystem.Location = new System.Drawing.Point(12, 157);
			this.panelSystem.Name = "panelSystem";
			this.panelSystem.Size = new System.Drawing.Size(166, 23);
			this.panelSystem.TabIndex = 2;
			// 
			// radioButtonConfigWin32
			// 
			this.radioButtonConfigWin32.AutoSize = true;
			this.radioButtonConfigWin32.Checked = true;
			this.radioButtonConfigWin32.Location = new System.Drawing.Point(3, 3);
			this.radioButtonConfigWin32.Name = "radioButtonConfigWin32";
			this.radioButtonConfigWin32.Size = new System.Drawing.Size(73, 17);
			this.radioButtonConfigWin32.TabIndex = 4;
			this.radioButtonConfigWin32.TabStop = true;
			this.radioButtonConfigWin32.Text = "Win32/86";
			this.radioButtonConfigWin32.UseVisualStyleBackColor = true;
			// 
			// radioButtonConfigWin64
			// 
			this.radioButtonConfigWin64.AutoSize = true;
			this.radioButtonConfigWin64.Location = new System.Drawing.Point(107, 3);
			this.radioButtonConfigWin64.Name = "radioButtonConfigWin64";
			this.radioButtonConfigWin64.Size = new System.Drawing.Size(56, 17);
			this.radioButtonConfigWin64.TabIndex = 3;
			this.radioButtonConfigWin64.Text = "Win64";
			this.radioButtonConfigWin64.UseVisualStyleBackColor = true;
			// 
			// buttonConfigBrowseSB
			// 
			this.buttonConfigBrowseSB.Location = new System.Drawing.Point(382, 22);
			this.buttonConfigBrowseSB.Name = "buttonConfigBrowseSB";
			this.buttonConfigBrowseSB.Size = new System.Drawing.Size(75, 20);
			this.buttonConfigBrowseSB.TabIndex = 3;
			this.buttonConfigBrowseSB.Text = "Browse";
			this.buttonConfigBrowseSB.UseVisualStyleBackColor = true;
			this.buttonConfigBrowseSB.Click += new System.EventHandler(this.buttonConfigBrowseSB_Click);
			// 
			// buttonConfigBrowseWork
			// 
			this.buttonConfigBrowseWork.Location = new System.Drawing.Point(382, 67);
			this.buttonConfigBrowseWork.Name = "buttonConfigBrowseWork";
			this.buttonConfigBrowseWork.Size = new System.Drawing.Size(75, 20);
			this.buttonConfigBrowseWork.TabIndex = 6;
			this.buttonConfigBrowseWork.Text = "Browse";
			this.buttonConfigBrowseWork.UseVisualStyleBackColor = true;
			this.buttonConfigBrowseWork.Click += new System.EventHandler(this.buttonConfigBrowseWork_Click);
			// 
			// textBoxConfigWork
			// 
			this.textBoxConfigWork.Location = new System.Drawing.Point(6, 67);
			this.textBoxConfigWork.Name = "textBoxConfigWork";
			this.textBoxConfigWork.Size = new System.Drawing.Size(370, 20);
			this.textBoxConfigWork.TabIndex = 5;
			// 
			// labelConfigWork
			// 
			this.labelConfigWork.AutoSize = true;
			this.labelConfigWork.Location = new System.Drawing.Point(3, 48);
			this.labelConfigWork.Margin = new System.Windows.Forms.Padding(3);
			this.labelConfigWork.Name = "labelConfigWork";
			this.labelConfigWork.Size = new System.Drawing.Size(95, 13);
			this.labelConfigWork.TabIndex = 4;
			this.labelConfigWork.Text = "Working Directory:";
			// 
			// buttonConfigContinue
			// 
			this.buttonConfigContinue.Location = new System.Drawing.Point(572, 157);
			this.buttonConfigContinue.Name = "buttonConfigContinue";
			this.buttonConfigContinue.Size = new System.Drawing.Size(75, 23);
			this.buttonConfigContinue.TabIndex = 7;
			this.buttonConfigContinue.Text = "Apply";
			this.buttonConfigContinue.UseVisualStyleBackColor = true;
			this.buttonConfigContinue.Click += new System.EventHandler(this.buttonConfigContinue_Click);
			// 
			// labelConfigSBVersion
			// 
			this.labelConfigSBVersion.AutoSize = true;
			this.labelConfigSBVersion.Location = new System.Drawing.Point(230, 3);
			this.labelConfigSBVersion.Margin = new System.Windows.Forms.Padding(3);
			this.labelConfigSBVersion.Name = "labelConfigSBVersion";
			this.labelConfigSBVersion.Size = new System.Drawing.Size(97, 13);
			this.labelConfigSBVersion.TabIndex = 9;
			this.labelConfigSBVersion.Text = "Starbound Version:";
			// 
			// textBoxConfigSBVersion
			// 
			this.textBoxConfigSBVersion.Location = new System.Drawing.Point(233, 22);
			this.textBoxConfigSBVersion.Name = "textBoxConfigSBVersion";
			this.textBoxConfigSBVersion.Size = new System.Drawing.Size(221, 20);
			this.textBoxConfigSBVersion.TabIndex = 10;
			// 
			// textBoxConfigAuthor
			// 
			this.textBoxConfigAuthor.Location = new System.Drawing.Point(6, 22);
			this.textBoxConfigAuthor.Name = "textBoxConfigAuthor";
			this.textBoxConfigAuthor.Size = new System.Drawing.Size(221, 20);
			this.textBoxConfigAuthor.TabIndex = 12;
			// 
			// labelConfigAuthor
			// 
			this.labelConfigAuthor.AutoSize = true;
			this.labelConfigAuthor.Location = new System.Drawing.Point(3, 3);
			this.labelConfigAuthor.Margin = new System.Windows.Forms.Padding(3);
			this.labelConfigAuthor.Name = "labelConfigAuthor";
			this.labelConfigAuthor.Size = new System.Drawing.Size(41, 13);
			this.labelConfigAuthor.TabIndex = 11;
			this.labelConfigAuthor.Text = "Author:";
			// 
			// textBoxConfigTextEditor
			// 
			this.textBoxConfigTextEditor.Location = new System.Drawing.Point(6, 22);
			this.textBoxConfigTextEditor.Name = "textBoxConfigTextEditor";
			this.textBoxConfigTextEditor.Size = new System.Drawing.Size(370, 20);
			this.textBoxConfigTextEditor.TabIndex = 14;
			// 
			// labelConfigTextEditor
			// 
			this.labelConfigTextEditor.AutoSize = true;
			this.labelConfigTextEditor.Location = new System.Drawing.Point(3, 3);
			this.labelConfigTextEditor.Margin = new System.Windows.Forms.Padding(3);
			this.labelConfigTextEditor.Name = "labelConfigTextEditor";
			this.labelConfigTextEditor.Size = new System.Drawing.Size(61, 13);
			this.labelConfigTextEditor.TabIndex = 13;
			this.labelConfigTextEditor.Text = "Text Editor:";
			// 
			// textBoxConfigImageEditor
			// 
			this.textBoxConfigImageEditor.Location = new System.Drawing.Point(6, 67);
			this.textBoxConfigImageEditor.Name = "textBoxConfigImageEditor";
			this.textBoxConfigImageEditor.Size = new System.Drawing.Size(370, 20);
			this.textBoxConfigImageEditor.TabIndex = 16;
			// 
			// labelConfigImageEditor
			// 
			this.labelConfigImageEditor.AutoSize = true;
			this.labelConfigImageEditor.Location = new System.Drawing.Point(3, 51);
			this.labelConfigImageEditor.Name = "labelConfigImageEditor";
			this.labelConfigImageEditor.Size = new System.Drawing.Size(69, 13);
			this.labelConfigImageEditor.TabIndex = 15;
			this.labelConfigImageEditor.Text = "Image Editor:";
			// 
			// buttonConfigBrowseImage
			// 
			this.buttonConfigBrowseImage.Location = new System.Drawing.Point(382, 67);
			this.buttonConfigBrowseImage.Name = "buttonConfigBrowseImage";
			this.buttonConfigBrowseImage.Size = new System.Drawing.Size(75, 20);
			this.buttonConfigBrowseImage.TabIndex = 18;
			this.buttonConfigBrowseImage.Text = "Browse";
			this.buttonConfigBrowseImage.UseVisualStyleBackColor = true;
			this.buttonConfigBrowseImage.Click += new System.EventHandler(this.buttonConfigBrowseImage_Click);
			// 
			// buttonConfigBrowseText
			// 
			this.buttonConfigBrowseText.Location = new System.Drawing.Point(382, 22);
			this.buttonConfigBrowseText.Name = "buttonConfigBrowseText";
			this.buttonConfigBrowseText.Size = new System.Drawing.Size(75, 20);
			this.buttonConfigBrowseText.TabIndex = 17;
			this.buttonConfigBrowseText.Text = "Browse";
			this.buttonConfigBrowseText.UseVisualStyleBackColor = true;
			this.buttonConfigBrowseText.Click += new System.EventHandler(this.buttonConfigBrowseText_Click);
			// 
			// buttonConfigBrowseAssets
			// 
			this.buttonConfigBrowseAssets.Location = new System.Drawing.Point(382, 112);
			this.buttonConfigBrowseAssets.Name = "buttonConfigBrowseAssets";
			this.buttonConfigBrowseAssets.Size = new System.Drawing.Size(75, 20);
			this.buttonConfigBrowseAssets.TabIndex = 21;
			this.buttonConfigBrowseAssets.Text = "Browse";
			this.buttonConfigBrowseAssets.UseVisualStyleBackColor = true;
			this.buttonConfigBrowseAssets.Click += new System.EventHandler(this.buttonConfigBrowseAssets_Click);
			// 
			// textBoxConfigAssets
			// 
			this.textBoxConfigAssets.Location = new System.Drawing.Point(6, 112);
			this.textBoxConfigAssets.Name = "textBoxConfigAssets";
			this.textBoxConfigAssets.Size = new System.Drawing.Size(370, 20);
			this.textBoxConfigAssets.TabIndex = 20;
			// 
			// labelConfigAssets
			// 
			this.labelConfigAssets.AutoSize = true;
			this.labelConfigAssets.Location = new System.Drawing.Point(3, 93);
			this.labelConfigAssets.Margin = new System.Windows.Forms.Padding(3);
			this.labelConfigAssets.Name = "labelConfigAssets";
			this.labelConfigAssets.Size = new System.Drawing.Size(86, 13);
			this.labelConfigAssets.TabIndex = 19;
			this.labelConfigAssets.Text = "Assets Directory:";
			// 
			// panelConfigDirectories
			// 
			this.panelConfigDirectories.Controls.Add(this.labelConfigSB);
			this.panelConfigDirectories.Controls.Add(this.textBoxConfigSB);
			this.panelConfigDirectories.Controls.Add(this.buttonConfigBrowseAssets);
			this.panelConfigDirectories.Controls.Add(this.buttonConfigBrowseSB);
			this.panelConfigDirectories.Controls.Add(this.labelConfigWork);
			this.panelConfigDirectories.Controls.Add(this.labelConfigAssets);
			this.panelConfigDirectories.Controls.Add(this.textBoxConfigAssets);
			this.panelConfigDirectories.Controls.Add(this.textBoxConfigWork);
			this.panelConfigDirectories.Controls.Add(this.buttonConfigBrowseWork);
			this.panelConfigDirectories.Location = new System.Drawing.Point(187, 12);
			this.panelConfigDirectories.Name = "panelConfigDirectories";
			this.panelConfigDirectories.Size = new System.Drawing.Size(460, 139);
			this.panelConfigDirectories.TabIndex = 23;
			// 
			// panelConfigEditors
			// 
			this.panelConfigEditors.Controls.Add(this.labelConfigTextEditor);
			this.panelConfigEditors.Controls.Add(this.textBoxConfigTextEditor);
			this.panelConfigEditors.Controls.Add(this.buttonConfigBrowseImage);
			this.panelConfigEditors.Controls.Add(this.labelConfigImageEditor);
			this.panelConfigEditors.Controls.Add(this.buttonConfigBrowseText);
			this.panelConfigEditors.Controls.Add(this.textBoxConfigImageEditor);
			this.panelConfigEditors.Location = new System.Drawing.Point(187, 12);
			this.panelConfigEditors.Name = "panelConfigEditors";
			this.panelConfigEditors.Size = new System.Drawing.Size(460, 122);
			this.panelConfigEditors.TabIndex = 24;
			// 
			// panelConfigDefaultJSON
			// 
			this.panelConfigDefaultJSON.Controls.Add(this.labelConfigAuthor);
			this.panelConfigDefaultJSON.Controls.Add(this.textBoxConfigAuthor);
			this.panelConfigDefaultJSON.Controls.Add(this.labelConfigSBVersion);
			this.panelConfigDefaultJSON.Controls.Add(this.textBoxConfigSBVersion);
			this.panelConfigDefaultJSON.Location = new System.Drawing.Point(187, 12);
			this.panelConfigDefaultJSON.Name = "panelConfigDefaultJSON";
			this.panelConfigDefaultJSON.Size = new System.Drawing.Size(460, 139);
			this.panelConfigDefaultJSON.TabIndex = 25;
			// 
			// buttonConfigClose
			// 
			this.buttonConfigClose.Location = new System.Drawing.Point(491, 157);
			this.buttonConfigClose.Name = "buttonConfigClose";
			this.buttonConfigClose.Size = new System.Drawing.Size(75, 23);
			this.buttonConfigClose.TabIndex = 26;
			this.buttonConfigClose.Text = "Close";
			this.buttonConfigClose.UseVisualStyleBackColor = true;
			this.buttonConfigClose.Click += new System.EventHandler(this.buttonConfigClose_Click);
			// 
			// treeViewConfigMenu
			// 
			this.treeViewConfigMenu.BackColor = System.Drawing.SystemColors.Control;
			this.treeViewConfigMenu.Location = new System.Drawing.Point(12, 12);
			this.treeViewConfigMenu.Name = "treeViewConfigMenu";
			this.treeViewConfigMenu.Size = new System.Drawing.Size(166, 139);
			this.treeViewConfigMenu.TabIndex = 27;
			this.treeViewConfigMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewConfigMenu_NodeMouseClick);
			// 
			// FormConfiguration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 188);
			this.Controls.Add(this.treeViewConfigMenu);
			this.Controls.Add(this.panelSystem);
			this.Controls.Add(this.panelConfigDirectories);
			this.Controls.Add(this.panelConfigDefaultJSON);
			this.Controls.Add(this.buttonConfigClose);
			this.Controls.Add(this.buttonConfigContinue);
			this.Controls.Add(this.panelConfigEditors);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormConfiguration";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Starbounder - Configuration";
			this.Load += new System.EventHandler(this.FormConfiguration_Load);
			this.panelSystem.ResumeLayout(false);
			this.panelSystem.PerformLayout();
			this.panelConfigDirectories.ResumeLayout(false);
			this.panelConfigDirectories.PerformLayout();
			this.panelConfigEditors.ResumeLayout(false);
			this.panelConfigEditors.PerformLayout();
			this.panelConfigDefaultJSON.ResumeLayout(false);
			this.panelConfigDefaultJSON.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelConfigSB;
        private System.Windows.Forms.TextBox textBoxConfigSB;
        private System.Windows.Forms.Panel panelSystem;
        private System.Windows.Forms.RadioButton radioButtonConfigWin32;
        private System.Windows.Forms.RadioButton radioButtonConfigWin64;
        private System.Windows.Forms.Button buttonConfigBrowseSB;
        private System.Windows.Forms.Button buttonConfigBrowseWork;
        private System.Windows.Forms.TextBox textBoxConfigWork;
        private System.Windows.Forms.Label labelConfigWork;
		private System.Windows.Forms.Button buttonConfigContinue;
		private System.Windows.Forms.Label labelConfigSBVersion;
		private System.Windows.Forms.TextBox textBoxConfigSBVersion;
		private System.Windows.Forms.TextBox textBoxConfigAuthor;
		private System.Windows.Forms.Label labelConfigAuthor;
		private System.Windows.Forms.TextBox textBoxConfigTextEditor;
		private System.Windows.Forms.Label labelConfigTextEditor;
		private System.Windows.Forms.TextBox textBoxConfigImageEditor;
		private System.Windows.Forms.Label labelConfigImageEditor;
		private System.Windows.Forms.Button buttonConfigBrowseImage;
		private System.Windows.Forms.Button buttonConfigBrowseText;
		private System.Windows.Forms.Button buttonConfigBrowseAssets;
		private System.Windows.Forms.TextBox textBoxConfigAssets;
		private System.Windows.Forms.Label labelConfigAssets;
		private System.Windows.Forms.Panel panelConfigDirectories;
		private System.Windows.Forms.Panel panelConfigEditors;
		private System.Windows.Forms.Panel panelConfigDefaultJSON;
		private System.Windows.Forms.Button buttonConfigClose;
		private System.Windows.Forms.TreeView treeViewConfigMenu;
	}
}

