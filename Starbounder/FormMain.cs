using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbounder
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

		private void FormMain_Load( object sender, EventArgs e )
		{
			var nodes = Project.IProject.TreeViewPopulate();

			treeViewFolder.Nodes.AddRange(nodes);
			treeViewFolder.ExpandAll();

			
		}

		private void treeViewFolder_NodeMouseDoubleClick( object sender, TreeNodeMouseClickEventArgs e )
		{
			MessageBox.Show(treeViewFolder.SelectedNode.Tag.ToString());
		}

		private void newProjectToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Project.IProject.CreateProject();
		}

		private void loadProjectToolStripMenuItem_Click( object sender, EventArgs e )
		{
			if (Project.IProject.LoadProject())
			{
				var nodes = Project.IProject.TreeViewPopulate();

				treeViewFolder.Nodes.Clear();
				treeViewFolder.Nodes.AddRange( nodes );
				treeViewFolder.ExpandAll();
			}
		}

		
	}
}
