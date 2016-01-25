using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
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

		#region Functions
		private string GetNodePath()
		{
			return treeViewFolder.SelectedNode.Tag.ToString();
		}
		private void RefreshTreeView()
		{
			treeViewFolder.Nodes.Clear();
			treeViewFolder.Nodes.AddRange(Project.IProject.TreeViewPopulate());
			treeViewFolder.ExpandAll();
		}
		#endregion

		private void FormMain_Load(object sender, EventArgs e)
		{
			

			RefreshTreeView();
		}
		private void treeViewFolder_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				TreeNode path = treeViewFolder.SelectedNode = treeViewFolder.GetNodeAt(e.X, e.Y);

				if (path != null)
				{
					contextMenuStripTreeView.Show(treeViewFolder, e.X, e.Y);
				}
			}
		}
		private void treeViewFolder_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			MessageBox.Show(treeViewFolder.SelectedNode.Tag.ToString());
		}

		#region MenuStripMain
		// File
		private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Project.IProject.CreateProject();
		}
		private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Project.IProject.LoadProject())
			{
				var nodes = Project.IProject.TreeViewPopulate();

				treeViewFolder.Nodes.Clear();
				treeViewFolder.Nodes.AddRange(nodes);
				treeViewFolder.ExpandAll();
			}
		}
		// File -> Starbound
		private void playToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Functions.Processes.LaunchStarbound(true, true);
		}
		private void fileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Functions.Processes.OpenFolder(Project.IProject.sbPath);
		}
		private void unpackAssetsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var cmd = Functions.Processes.UnpackStarbound(true);
			if (cmd) MessageBox.Show("Unpacking Assets might be complete.\nIf the process took less than a second, an error occured.", "Unpacking Assets", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		// Settings
		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			var mf = new FormConfiguration();

			mf.FormClosed += (s, args) => this.Close();
			mf.Show();
		}
		// Refresh
		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RefreshTreeView();
		}
		#endregion

		#region ContextMenuStrip

		#region Item
		private void itemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateEverything(GetNodePath(), new FileTypes.Items.ItemItem(), ".item", 16, 16);
			RefreshTreeView();
		}
		private void materialItemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Items.ItemMaterial(), ".matitem");
			RefreshTreeView();
		}
		private void liquidItemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Items.ItemMaterial(), ".liqitem");
			RefreshTreeView();
		}
		#endregion
		#region Weapon
		private void swordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Weapons.WeaponSword(), ".sword");
			RefreshTreeView();
		}

		private void staffToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Weapons.WeaponStaff(), ".staff");
			RefreshTreeView();
		}

		private void gunToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Weapons.WeaponGun(), ".gun");
			RefreshTreeView();
		}

		private void thrownToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Weapons.WeaponThrown(), ".thrown");
			RefreshTreeView();
		}
		#endregion
		#region Tool
		private void miningToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Tools.ToolMining(), ".miningtool");
			RefreshTreeView();
		}
		private void beamaxeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Tools.ToolBeamaxe(), ".beamaxe");
			RefreshTreeView();
		}
		private void harvestingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Tools.ToolMining(), ".harvestingtool");
			RefreshTreeView();
		}
		#endregion
		#region Armor
		private void headToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Armors.ArmorHead(), ".head");
			RefreshTreeView();
		}
		private void chestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Armors.ArmorChest(), ".chest");
			RefreshTreeView();
		}
		private void legsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Armors.ArmorLegs(), ".legs");
			RefreshTreeView();
		}
		private void backToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Armors.ArmorBack(), ".back");
			RefreshTreeView();
		}





		#endregion

		#region Others

		#endregion
		#region Actions
		private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string folderName = Path.GetFileNameWithoutExtension(GetNodePath());
			string folderPath = (Path.HasExtension(GetNodePath())) ? Path.GetDirectoryName(GetNodePath()) : Path.GetFullPath(GetNodePath());

			Project.IProject.CreateFolder(folderPath + "\\" + folderName);

			RefreshTreeView();
		}
		#endregion

		#endregion


	}
}