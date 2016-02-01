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

			textBoxConfigSB.Text           = Settings.LoadStarboundFolder();
			radioButtonConfigWin64.Checked = Settings.LoadSystem();
			textBoxConfigWork.Text         = Settings.LoadWorkingDirectory();
			textBoxConfigAuthor.Text       = Settings.LoadAuthor();
			textBoxConfigSBVersion.Text    = Settings.LoadSBVersion();
			textBoxConfigTextEditor.Text   = Settings.LoadTextEditor();
			textBoxConfigImageEditor.Text  = Settings.LoadImageEditor();

			if (textBoxConfigSB.Text == "")
			{
				Functions.Steam.SearchForStarboundFolder(textBoxConfigSB);
			}
		}

		// Expand
		private void buttonConfigExpand_Click(object sender, EventArgs e)
		{
			isExpanded = ( isExpanded ) ? isExpanded = false : isExpanded = true;
			this.Size = ( isExpanded ) ? new Size(500, 310) : new Size(500, 170);
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

			Properties.Settings.Default.Save();
			Properties.Settings.Default.Upgrade();

			// Open Main form
			this.Hide();
			var mf = new FormMain();

			IProject project = new IProject(textBoxConfigWork.Text);
			Project.IProject.sbPath = textBoxConfigSB.Text;

			mf.FormClosed += (s, args) => this.Close();
			mf.Show();
		}

		#region Buttons : Browse
		// Starbound
		private void buttonConfigBrowseSB_Click(object sender, EventArgs e)
		{
			var folder = Functions.Dialogs.FolderBrowserDialog("Browse Starbound Folder");

			textBoxConfigSB.Text = ( folder != null ) ? folder.SelectedPath : textBoxConfigSB.Text;
		}

		// Work Directory
		private void buttonConfigBrowseWork_Click(object sender, EventArgs e)
		{
			var folder = Functions.Dialogs.FolderBrowserDialog("Select a folder to get the most of out the program.");

			textBoxConfigWork.Text = ( folder != null ) ? folder.SelectedPath : textBoxConfigWork.Text;
		}

		// Text Editor
		private void buttonConfigBrowseText_Click(object sender, EventArgs e)
		{
			var file = Functions.Dialogs.LoadFileDialog("Select the specific text editor's .exe file.", "Executable Files (*.exe)|*.exe");

			textBoxConfigTextEditor.Text = ( file != null ) ? file.FileName : textBoxConfigTextEditor.Text;
		}

		// Image Editor
		private void buttonConfigBrowseImage_Click(object sender, EventArgs e)
		{
			var file = Functions.Dialogs.LoadFileDialog("Select the specific image editor's .exe file.", "Executable Files (*.exe)|*.exe");

			textBoxConfigImageEditor.Text = ( file != null ) ? file.FileName : textBoxConfigImageEditor.Text;
		}
		#endregion

	}
}
