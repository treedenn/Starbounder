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

namespace Starbounder
{
    public partial class FormConfiguration : Form
    {
        public FormConfiguration()
        {
            InitializeComponent();
        }

        private void FormConfiguration_Load(object sender, EventArgs e)
        {
			string steamLocation = Functions.Steam.GetSteamFolder();

			textBoxConfigSB.Text = Functions.Steam.GetStarboundFolder( steamLocation );

			if ( textBoxConfigSB.Text == string.Empty )
			{
				string[] locations = Functions.Steam.GetSteamLocations();

				foreach ( string location in locations )
				{
					textBoxConfigSB.Text = Functions.Steam.GetStarboundFolder( location );
				}
			}
		}

		private void buttonConfigContinue_Click( object sender, EventArgs e )
		{
			this.Hide();
			var mf = new FormMain();
			Project.IProject.pPath = textBoxConfigWork.Text;
			Project.IProject.pName = Path.GetFileName(textBoxConfigWork.Text);
			mf.FormClosed += ( s, args ) => this.Close();
			mf.Show();
		}

		private void buttonConfigBrowseSB_Click( object sender, EventArgs e )
		{
			var folder = Project.Dialogs.FolderBrowserDialog("Browse Starbound Folder");

			textBoxConfigSB.Text = ( folder.SelectedPath != string.Empty ) ? folder.SelectedPath : textBoxConfigSB.Text;
		}

		private void buttonConfigBrowseWork_Click( object sender, EventArgs e )
		{
			var folder = Project.Dialogs.FolderBrowserDialog("Browse Starbound Working Folder");

			textBoxConfigWork.Text = ( folder.SelectedPath != string.Empty ) ? folder.SelectedPath : textBoxConfigWork.Text;
		}
	}
}
