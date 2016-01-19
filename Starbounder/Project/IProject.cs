using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Starbounder.Project
{
	class IProject
	{
		public string pName { get; set; }
		public static string pPath { get; set; }

		public IProject()
		{

		}

		public static void CreateProject()
		{
			var project = new SaveFileDialog();

			project.Title = "Create a new Starbound Project";
			project.ShowDialog();

			if (project.FileName != string.Empty)
			{
				FreshProject( project.FileName );
			}

			//MessageBox.Show( project.InitialDirectory );
		}

		public static void LoadProject()
		{


			//ModInfo mi = new ModInfo().Load( @"C:\Users\Denni\Desktop\sbmod\sbmod.modinfo" );
		}

		private static void FreshProject(string path)
		{
			Create.Create.Folder( path );
			Project.ModInfo.Create(path, new ModInfo());
		}

		#region TreeView
		/// <summary>
		/// Populates the treeview with the folderpath.
		/// </summary>
		/// <returns></returns>
		public static TreeNode[] TreeViewPopulate()
		{
			DirectoryInfo info = new DirectoryInfo(pPath);

			List<TreeNode> nodes = new List<TreeNode>();

			foreach ( var folder in info.GetDirectories() )
			{
				nodes.Add( CreateDirectoryNodes( folder ) );
			}

			foreach ( var file in info.GetFiles() )
			{
				TreeNode newNode = new TreeNode(file.Name);
				newNode.Tag = file.FullName;
				nodes.Add( newNode );
			}

			return nodes.ToArray();
		}

		/// <summary>
		/// Creates a new node from a DirectoryInfo.
		/// </summary>
		/// <param name="info"></param>
		/// <returns></returns>
		private static TreeNode CreateDirectoryNodes( DirectoryInfo info )
		{
			TreeNode directoryNode = new TreeNode(info.Name);
			directoryNode.Tag = info.FullName;

			foreach ( var folder in info.GetDirectories() )
			{
				directoryNode.Tag = folder.FullName;
				directoryNode.Nodes.Add( CreateDirectoryNodes( folder ) );
			}

			foreach ( var file in info.GetFiles() )
			{
				TreeNode newNode = new TreeNode(file.Name);
				newNode.Tag = file.FullName;
				directoryNode.Nodes.Add( newNode );
			}

			return directoryNode;
		}
		#endregion
	}
}
