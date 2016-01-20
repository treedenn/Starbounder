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
		public static string pName { get; set; }
		public static string pPath { get; set; }

		public IProject()
		{

		}

		public IProject(string path)
		{
			pPath = path;
			pName = Path.GetFileName(path);
		}

		public static void CreateProject()
		{
			var folder = Project.Dialogs.SaveFileDialog("Create a new Starbound Project");

			if ( folder.FileName != string.Empty)
			{
				FreshProject( folder.FileName );
			}

			//MessageBox.Show( project.InitialDirectory );
		}

		public static bool LoadProject()
		{
			var folder = Project.Dialogs.FolderBrowserDialog("Load Starbound Mod Folder");

			if (folder.SelectedPath != string.Empty)
			{
				pPath = folder.SelectedPath;
				pName = Path.GetFileName( folder.SelectedPath );

				return true;
			}

			return false;
		}

		private static void FreshProject( string path )
		{
			Create.ICreate.Folder( path );
			Project.ModInfo.Create( path, new ModInfo() );
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
