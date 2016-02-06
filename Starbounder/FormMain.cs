using System;
using System.IO;
using System.Linq;
using System.Data;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using Starbounder.FileTypes;
using Newtonsoft.Json;

namespace Starbounder
{
	public partial class FormMain : Form
	{
		private bool posLeft = true;

		public FormMain()
		{
			InitializeComponent();

			MainMenuStrip.Renderer = new Renderer.ToolStrips();
			contextMenuStripTreeView.Renderer = new Renderer.ToolStrips();
		}

		#region Functions
		private void RecursiveMenuItems(ToolStripDropDownItem item)
		{
			if (item.HasDropDownItems)
			{
				foreach (var cItem in item.DropDownItems)
				{
					if (cItem is ToolStripMenuItem)
					{
						RecursiveMenuItems((ToolStripMenuItem)cItem);
					}
				}
			}

			SetColorsOnMenuItem((ToolStripMenuItem)item);
		}

		private void SetColorsOnMenuItem(ToolStripMenuItem item)
		{
			item.BackColor = SystemColors.Desktop;
			item.ForeColor = SystemColors.Control;
		}

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
			foreach (ToolStripDropDownItem item in menuStripMain.Items)
			{
				RecursiveMenuItems(item);
			}

			foreach (var item in contextMenuStripTreeView.Items)
			{
				if (item is ToolStripMenuItem)
				{
					RecursiveMenuItems((ToolStripMenuItem)item);
				}
			}

			this.Icon = Properties.Resources.StarbounderIcon;
			Project.Settings.ChangeLocationLeft(this);

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
			string nodePath = GetNodePath();

			if (Path.HasExtension(nodePath))
			{
				string fe    = Path.GetExtension(nodePath); // File Extension
				
				if (fe == ".png" || fe == ".PNG")
				{
					Functions.Processes.OpenFileWithImageEditor(nodePath);
				} else
				{
					Functions.Processes.OpenFileWithTextEditor(nodePath);
				}
			}
		}

		#region MenuStripMain
		// File -> Project
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
		private void fileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Functions.Processes.OpenFolder(Project.Settings.LoadWorkingDirectory());
		}
		// File -> Starbound
		private void playToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Functions.Processes.LaunchStarbound(Properties.Settings.Default.OperationSystem64, true);
		}
		private void fileExplorerSBToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Functions.Processes.OpenFolder(Project.Settings.LoadStarboundFolder());
		}
		private void unpackAssetsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var cmd = Functions.Processes.UnpackStarbound(Properties.Settings.Default.OperationSystem64);
			if (cmd) MessageBox.Show("Unpacking Assets might be complete.\nIf the process took less than a second, an error occured.", "Unpacking Assets", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		// File -> Exit
		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		// Settings -> Configurations
		private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			var mf = new FormConfiguration();

			mf.FormClosed += (s, args) => this.Close();
			mf.Show();
		}
		// Settings -> Placement
		private void placementToolStripMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			posLeft = ( posLeft ) ? false : true;

			if (posLeft)
			{
				Project.Settings.ChangeLocationLeft(this);
				placementToolStripMenuItem.Text = "Placement: Left";
			} else
			{
				Project.Settings.ChangeLocationRight(this);
				placementToolStripMenuItem.Text = "Placement: Right";
			}
		}
		// Settings -> Hide
		private void hideToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		// Refresh
		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RefreshTreeView();
		}
		#endregion

		#region ContextMenuStrip

		#region item
		private void itemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Items.ItemItem().SetDefault(), ".item");
			FileTypes.FileTypes.CreatePNG(GetNodePath(), 16, 16);
			RefreshTreeView();
		}
		private void materialItemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Items.ItemMaterial().SetDefault(), ".matitem");
			FileTypes.FileTypes.CreatePNG(GetNodePath(), 16, 16);
			RefreshTreeView();
		}
		private void liquidItemToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Items.ItemLiquid().SetDefault(), ".liqitem");
			FileTypes.FileTypes.CreatePNG(GetNodePath(), 16, 16);
			RefreshTreeView();
		}
		#endregion
		#region weapon
		private void swordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Weapons.WeaponSword().SetDefault(), ".sword");
			FileTypes.FileTypes.CreatePNG(GetNodePath(), 16, 16);
			RefreshTreeView();
		}
		private void staffToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Weapons.WeaponStaff().SetDefault(), ".staff");
			FileTypes.FileTypes.CreatePNG(GetNodePath(), 16, 16);
			RefreshTreeView();
		}
		private void gunToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Weapons.WeaponGun().SetDefault(), ".gun");
			FileTypes.FileTypes.CreatePNG(GetNodePath(), 16, 16);
			RefreshTreeView();
		}
		private void thrownToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Weapons.WeaponThrown(), ".thrown");
			FileTypes.FileTypes.CreatePNG(GetNodePath(), 16, 16);
			RefreshTreeView();
		}
		#endregion
		#region tool
		private void miningToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Tools.ToolMining().SetDefault(), ".miningtool");
			FileTypes.FileTypes.CreatePNG(GetNodePath(), 16, 16);
			RefreshTreeView();
		}
		private void beamaxeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Tools.ToolBeamaxe().SetDefault(), ".beamaxe");
			FileTypes.FileTypes.CreatePNG(GetNodePath(), 16, 16);
			RefreshTreeView();
		}
		private void harvestingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Tools.ToolMining().SetDefault(), ".harvestingtool");
			FileTypes.FileTypes.CreatePNG(GetNodePath(), 16, 16);
			RefreshTreeView();
		}
		#endregion
		#region armor
		private void headToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Armors.ArmorHead().SetDefault(), ".head");
			FileTypes.FileTypes.CreatePNG(GetNodePath(), 16, 16);
			RefreshTreeView();
		}
		private void chestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Armors.ArmorChest().SetDefault(), ".chest");
			FileTypes.FileTypes.CreatePNG(GetNodePath(), 16, 16);
			RefreshTreeView();
		}
		private void legsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Armors.ArmorLegs().SetDefault(), ".legs");
			FileTypes.FileTypes.CreatePNG(GetNodePath(), 16, 16);
			RefreshTreeView();
		}
		private void backToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateJson(GetNodePath(), new FileTypes.Armors.ArmorBack(), ".back");
			FileTypes.FileTypes.CreatePNG(GetNodePath(), 16, 16);
			RefreshTreeView();
		}

		#endregion

		#region others
		private void consumableToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		private void liquidToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
		private void framesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FileTypes.FileTypes.CreateFrames(GetNodePath());
			RefreshTreeView();
		}
		#endregion
		#region actions
		private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string folderName = Path.GetFileNameWithoutExtension(GetNodePath());
			string folderPath = (Path.HasExtension(GetNodePath())) ? Path.GetDirectoryName(GetNodePath()) : Path.GetFullPath(GetNodePath());

			Functions.Actions.CreateFolder(folderPath + "\\" + folderName);

			RefreshTreeView();
		}
		private void renameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Functions.Actions.Rename(GetNodePath());

			RefreshTreeView();
		}
		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Functions.Actions.Delete(GetNodePath());

			RefreshTreeView();
		}
		private void moveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Functions.Actions.Move(GetNodePath());

			RefreshTreeView();
		}











		#endregion

		#endregion
	}
}