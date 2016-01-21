using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Starbounder.FileTypes;

namespace Starbounder
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e)
		{
			RefreshTreeView();
		}

		private void treeViewFolder_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			MessageBox.Show(treeViewFolder.SelectedNode.Tag.ToString());
		}

		private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Project.IProject.CreateProject();
		}

		private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if ( Project.IProject.LoadProject() )
			{
				var nodes = Project.IProject.TreeViewPopulate();

				treeViewFolder.Nodes.Clear();
				treeViewFolder.Nodes.AddRange(nodes);
				treeViewFolder.ExpandAll();
			}
		}

		#region ContextMenuStrip
		#region Armor
		private void headToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string path = treeViewFolder.SelectedNode.Tag.ToString();

			FileTypes.Armor.Create(path, new FileTypes.Armors.ArmorHead());

			RefreshTreeView();
		}

		private void chestToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void legsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void backToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		#endregion
		#endregion

		private void RefreshTreeView()
		{
			treeViewFolder.Nodes.Clear();
			treeViewFolder.Nodes.AddRange(Project.IProject.TreeViewPopulate());
			treeViewFolder.ExpandAll();
		}

	}
}
