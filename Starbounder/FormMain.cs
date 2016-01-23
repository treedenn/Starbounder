﻿using System;
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

		#region ContextMenuStrip

		#region Item
		private void itemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.Create(GetNodePath(), new FileTypes.Items.ItemItem(), ".item");
			RefreshTreeView();
		}
		private void materialItemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.Create(GetNodePath(), new FileTypes.Items.ItemMaterial(), ".matitem");
			RefreshTreeView();
		}
		private void liquidItemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.Create(GetNodePath(), new FileTypes.Items.ItemMaterial(), ".liqitem");
			RefreshTreeView();
		}
		#endregion
		#region Weapon
		private void swordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.Create(GetNodePath(), new FileTypes.Weapons.WeaponSword(), ".sword");
			RefreshTreeView();
		}

		private void staffToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.Create(GetNodePath(), new FileTypes.Weapons.WeaponStaff(), ".staff");
			RefreshTreeView();
		}

		private void gunToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.Create(GetNodePath(), new FileTypes.Weapons.WeaponGun(), ".gun");
			RefreshTreeView();
		}

		private void thrownToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.Create(GetNodePath(), new FileTypes.Weapons.WeaponThrown(), ".thrown");
			RefreshTreeView();
		}
		#endregion
		#region Tool
		private void miningToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.Create(GetNodePath(), new FileTypes.Tools.ToolMining(), ".miningtool");
			RefreshTreeView();
		}
		private void beamaxeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.Create(GetNodePath(), new FileTypes.Tools.ToolBeamaxe(), ".beamaxe");
			RefreshTreeView();
		}
		private void harvestingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.Create(GetNodePath(), new FileTypes.Tools.ToolMining(), ".harvestingtool");
			RefreshTreeView();
		}
		#endregion
		#region Armor
		private void headToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.Create(GetNodePath(), new FileTypes.Armors.ArmorHead(), ".head");
			RefreshTreeView();
		}
		private void chestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.Create(GetNodePath(), new FileTypes.Armors.ArmorChest(), ".chest");
			RefreshTreeView();
		}
		private void legsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.Create(GetNodePath(), new FileTypes.Armors.ArmorLegs(), ".legs");
			RefreshTreeView();
		}
		private void backToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.Create(GetNodePath(), new FileTypes.Armors.ArmorBack(), ".back");
			RefreshTreeView();
		}
		#endregion
		#region Others
		
		#endregion

		#endregion

	}
}
