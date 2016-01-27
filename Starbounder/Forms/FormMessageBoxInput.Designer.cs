namespace Starbounder.Forms
{
	partial class FormMessageBoxInput
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
			if (disposing && ( components != null ))
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
			this.buttonMBOK = new System.Windows.Forms.Button();
			this.buttonMBCancel = new System.Windows.Forms.Button();
			this.textBoxMBInput = new System.Windows.Forms.TextBox();
			this.labelMBText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonMBOK
			// 
			this.buttonMBOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMBOK.Location = new System.Drawing.Point(297, 12);
			this.buttonMBOK.Name = "buttonMBOK";
			this.buttonMBOK.Size = new System.Drawing.Size(75, 23);
			this.buttonMBOK.TabIndex = 1;
			this.buttonMBOK.Text = "OK";
			this.buttonMBOK.UseVisualStyleBackColor = true;
			this.buttonMBOK.Click += new System.EventHandler(this.buttonMBOK_Click);
			// 
			// buttonMBCancel
			// 
			this.buttonMBCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMBCancel.Location = new System.Drawing.Point(297, 41);
			this.buttonMBCancel.Name = "buttonMBCancel";
			this.buttonMBCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonMBCancel.TabIndex = 2;
			this.buttonMBCancel.Text = "Cancel";
			this.buttonMBCancel.UseVisualStyleBackColor = true;
			this.buttonMBCancel.Click += new System.EventHandler(this.buttonMBCancel_Click);
			// 
			// textBoxMBInput
			// 
			this.textBoxMBInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxMBInput.Location = new System.Drawing.Point(12, 229);
			this.textBoxMBInput.Name = "textBoxMBInput";
			this.textBoxMBInput.Size = new System.Drawing.Size(360, 20);
			this.textBoxMBInput.TabIndex = 0;
			// 
			// labelMBText
			// 
			this.labelMBText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelMBText.Location = new System.Drawing.Point(12, 12);
			this.labelMBText.Name = "labelMBText";
			this.labelMBText.Size = new System.Drawing.Size(279, 214);
			this.labelMBText.TabIndex = 3;
			// 
			// FormMessageBoxInput
			// 
			this.AcceptButton = this.buttonMBOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonMBCancel;
			this.ClientSize = new System.Drawing.Size(384, 261);
			this.Controls.Add(this.labelMBText);
			this.Controls.Add(this.textBoxMBInput);
			this.Controls.Add(this.buttonMBCancel);
			this.Controls.Add(this.buttonMBOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMessageBoxInput";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FormMessageBoxInput";
			this.Load += new System.EventHandler(this.FormMessageBoxInput_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonMBOK;
		private System.Windows.Forms.Button buttonMBCancel;
		private System.Windows.Forms.TextBox textBoxMBInput;
		private System.Windows.Forms.Label labelMBText;
	}
}