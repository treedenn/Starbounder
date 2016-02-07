using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Starbounder.Project;

namespace Starbounder
{
	public partial class FormConfiguration : Form
	{
		private bool isExpanded = false;

		public FormConfiguration()
		{
			InitializeComponent();
		}

		// Form load
		private void FormConfiguration_Load(object sender, EventArgs e)
		{
			this.Icon = Properties.Resources.StarbounderIcon;

			textBoxConfigSB.Text           = Settings.LoadStarboundFolder();
			radioButtonConfigWin64.Checked = Settings.LoadSystem();
			textBoxConfigWork.Text         = Settings.LoadWorkingDirectory();
			textBoxConfigAuthor.Text       = Settings.LoadAuthor();
			textBoxConfigSBVersion.Text    = Settings.LoadSBVersion();
			textBoxConfigTextEditor.Text   = Settings.LoadTextEditor();
			textBoxConfigImageEditor.Text  = Settings.LoadImageEditor();
			textBoxConfigAssets.Text       = Settings.LoadAssetsFolder();

			if (textBoxConfigSB.Text == "")
			{
				Functions.Steam.SearchForStarboundFolder(textBoxConfigSB);
			}
		}

		// Expand
		private void buttonConfigExpand_Click(object sender, EventArgs e)
		{
			isExpanded = ( isExpanded ) ? isExpanded = false : isExpanded = true;
			this.Size = ( isExpanded ) ? new Size(500, 350) : new Size(500, 200);
		}
		
		// Continue
		private void buttonConfigContinue_Click(object sender, EventArgs e)
		{
			// Save settings
			Settings.SaveSystem(radioButtonConfigWin64.Checked);
			Settings.SaveWorkingDirectory(textBoxConfigWork.Text);
			Settings.SaveStarboundFolder(textBoxConfigSB.Text);
			Settings.SaveAuthor(textBoxConfigAuthor.Text);
			Settings.SaveSBVersion(textBoxConfigSBVersion.Text);
			Settings.SaveTextEditor(textBoxConfigTextEditor.Text);
			Settings.SaveImageEditor(textBoxConfigImageEditor.Text);
			Settings.SaveAssetsFolder(textBoxConfigAssets.Text);

			Settings.Save();

			// Open Main form
			this.Hide();
			var mf = new FormMain();

			mf.FormClosed += (s, args) => this.Close();
			mf.Show();
		}

		#region Buttons : Browse
		private void buttonConfigBrowseSB_Click(object sender, EventArgs e)
		{
			var folder = Functions.Dialogs.FolderBrowserDialog("Browse Starbound Folder");

			textBoxConfigSB.Text = ( folder != null ) ? folder.SelectedPath : textBoxConfigSB.Text;
		}

		private void buttonConfigBrowseWork_Click(object sender, EventArgs e)
		{
			var folder = Functions.Dialogs.FolderBrowserDialog("Select your mod folder.");

			textBoxConfigWork.Text = ( folder != null ) ? folder.SelectedPath : textBoxConfigWork.Text;
		}

		private void buttonConfigBrowseText_Click(object sender, EventArgs e)
		{
			var file = Functions.Dialogs.LoadFileDialog("Select the specific text editor's .exe file.", "Executable Files (*.exe)|*.exe");

			textBoxConfigTextEditor.Text = ( file != null ) ? file.FileName : textBoxConfigTextEditor.Text;
		}

		private void buttonConfigBrowseImage_Click(object sender, EventArgs e)
		{
			var file = Functions.Dialogs.LoadFileDialog("Select the specific image editor's .exe file.", "Executable Files (*.exe)|*.exe");

			textBoxConfigImageEditor.Text = ( file != null ) ? file.FileName : textBoxConfigImageEditor.Text;
		}

		private void buttonConfigBrowseAssets_Click(object sender, EventArgs e)
		{
			var folder = Functions.Dialogs.FolderBrowserDialog("Select where all the assets are.");

			textBoxConfigAssets.Text = ( folder != null ) ? folder.SelectedPath : textBoxConfigAssets.Text;
		}
		#endregion


	}
}
