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
			this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
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
			this.buttonConfigExpand = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panelSystem.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelConfigSB
			// 
			this.labelConfigSB.AutoSize = true;
			this.labelConfigSB.Location = new System.Drawing.Point(12, 9);
			this.labelConfigSB.Name = "labelConfigSB";
			this.labelConfigSB.Size = new System.Drawing.Size(91, 13);
			this.labelConfigSB.TabIndex = 0;
			this.labelConfigSB.Text = "Starbound Folder:";
			// 
			// textBoxConfigSB
			// 
			this.textBoxConfigSB.Location = new System.Drawing.Point(15, 25);
			this.textBoxConfigSB.Name = "textBoxConfigSB";
			this.textBoxConfigSB.Size = new System.Drawing.Size(376, 20);
			this.textBoxConfigSB.TabIndex = 1;
			// 
			// panelSystem
			// 
			this.panelSystem.Controls.Add(this.radioButtonConfigWin32);
			this.panelSystem.Controls.Add(this.radioButtonConfigWin64);
			this.panelSystem.Location = new System.Drawing.Point(209, 96);
			this.panelSystem.Name = "panelSystem";
			this.panelSystem.Size = new System.Drawing.Size(182, 23);
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
			this.radioButtonConfigWin64.Location = new System.Drawing.Point(123, 3);
			this.radioButtonConfigWin64.Name = "radioButtonConfigWin64";
			this.radioButtonConfigWin64.Size = new System.Drawing.Size(56, 17);
			this.radioButtonConfigWin64.TabIndex = 3;
			this.radioButtonConfigWin64.Text = "Win64";
			this.radioButtonConfigWin64.UseVisualStyleBackColor = true;
			// 
			// buttonConfigBrowseSB
			// 
			this.buttonConfigBrowseSB.Location = new System.Drawing.Point(397, 25);
			this.buttonConfigBrowseSB.Name = "buttonConfigBrowseSB";
			this.buttonConfigBrowseSB.Size = new System.Drawing.Size(75, 20);
			this.buttonConfigBrowseSB.TabIndex = 3;
			this.buttonConfigBrowseSB.Text = "Browse";
			this.buttonConfigBrowseSB.UseVisualStyleBackColor = true;
			this.buttonConfigBrowseSB.Click += new System.EventHandler(this.buttonConfigBrowseSB_Click);
			// 
			// buttonConfigBrowseWork
			// 
			this.buttonConfigBrowseWork.Location = new System.Drawing.Point(397, 64);
			this.buttonConfigBrowseWork.Name = "buttonConfigBrowseWork";
			this.buttonConfigBrowseWork.Size = new System.Drawing.Size(75, 20);
			this.buttonConfigBrowseWork.TabIndex = 6;
			this.buttonConfigBrowseWork.Text = "Browse";
			this.buttonConfigBrowseWork.UseVisualStyleBackColor = true;
			this.buttonConfigBrowseWork.Click += new System.EventHandler(this.buttonConfigBrowseWork_Click);
			// 
			// textBoxConfigWork
			// 
			this.textBoxConfigWork.Location = new System.Drawing.Point(15, 64);
			this.textBoxConfigWork.Name = "textBoxConfigWork";
			this.textBoxConfigWork.Size = new System.Drawing.Size(376, 20);
			this.textBoxConfigWork.TabIndex = 5;
			this.textBoxConfigWork.Text = "C:\\Users\\Denni\\Desktop\\newMod";
			// 
			// labelConfigWork
			// 
			this.labelConfigWork.AutoSize = true;
			this.labelConfigWork.Location = new System.Drawing.Point(12, 48);
			this.labelConfigWork.Name = "labelConfigWork";
			this.labelConfigWork.Size = new System.Drawing.Size(95, 13);
			this.labelConfigWork.TabIndex = 4;
			this.labelConfigWork.Text = "Working Directory:";
			// 
			// buttonConfigContinue
			// 
			this.buttonConfigContinue.Location = new System.Drawing.Point(397, 96);
			this.buttonConfigContinue.Name = "buttonConfigContinue";
			this.buttonConfigContinue.Size = new System.Drawing.Size(75, 23);
			this.buttonConfigContinue.TabIndex = 7;
			this.buttonConfigContinue.Text = "Continue";
			this.buttonConfigContinue.UseVisualStyleBackColor = true;
			this.buttonConfigContinue.Click += new System.EventHandler(this.buttonConfigContinue_Click);
			// 
			// buttonConfigExpand
			// 
			this.buttonConfigExpand.Location = new System.Drawing.Point(15, 96);
			this.buttonConfigExpand.Name = "buttonConfigExpand";
			this.buttonConfigExpand.Size = new System.Drawing.Size(23, 23);
			this.buttonConfigExpand.TabIndex = 8;
			this.buttonConfigExpand.Text = "▼";
			this.buttonConfigExpand.UseVisualStyleBackColor = true;
			this.buttonConfigExpand.Click += new System.EventHandler(this.buttonConfigExpand_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(248, 133);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Starbound Version:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(251, 149);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(221, 20);
			this.textBox1.TabIndex = 10;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(15, 149);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(221, 20);
			this.textBox2.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Author:";
			// 
			// FormConfiguration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 131);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonConfigExpand);
			this.Controls.Add(this.buttonConfigContinue);
			this.Controls.Add(this.buttonConfigBrowseWork);
			this.Controls.Add(this.textBoxConfigWork);
			this.Controls.Add(this.labelConfigWork);
			this.Controls.Add(this.buttonConfigBrowseSB);
			this.Controls.Add(this.panelSystem);
			this.Controls.Add(this.textBoxConfigSB);
			this.Controls.Add(this.labelConfigSB);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormConfiguration";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Starbounder - Configuration";
			this.Load += new System.EventHandler(this.FormConfiguration_Load);
			this.panelSystem.ResumeLayout(false);
			this.panelSystem.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
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
		private System.Windows.Forms.Button buttonConfigExpand;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
	}
}

