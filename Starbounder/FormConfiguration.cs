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

		private void FormConfiguration_Load(object sender, EventArgs e)
		{
			Functions.Steam.SearchForStarboundFolder(textBoxConfigSB);
			radioButtonConfigWin64.Checked = Settings.LoadSystem();

			textBoxConfigWork.Text = Settings.LoadWorkingDirectory();
		}

		private void buttonConfigContinue_Click(object sender, EventArgs e)
		{
			// Save settings
			Settings.SaveSystem(radioButtonConfigWin64.Checked);
			Settings.SaveWorkingDirectory(textBoxConfigWork.Text);

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

		private void buttonConfigBrowseSB_Click(object sender, EventArgs e)
		{
			var folder = Functions.Dialogs.FolderBrowserDialog("Browse Starbound Folder");

			textBoxConfigSB.Text = ( folder.SelectedPath != string.Empty ) ? folder.SelectedPath : textBoxConfigSB.Text;
		}

		private void buttonConfigBrowseWork_Click(object sender, EventArgs e)
		{
			var folder = Functions.Dialogs.FolderBrowserDialog("Browse Starbound Working Folder");

			textBoxConfigWork.Text = ( folder.SelectedPath != string.Empty ) ? folder.SelectedPath : textBoxConfigWork.Text;
		}

		private void buttonConfigExpand_Click(object sender, EventArgs e)
		{
			isExpanded = ( isExpanded ) ? isExpanded = false : isExpanded = true;
			this.Size = ( isExpanded ) ? new Size(500, 220) : new Size(500, 170);
		}
	}
}
