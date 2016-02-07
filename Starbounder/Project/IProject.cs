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
		public static string GetProjectName()
		{
			string projectName = Path.GetDirectoryName(Settings.LoadWorkingDirectory());
			return projectName;
		}

		public static void CreateProject()
		{
			var folder = Functions.Dialogs.SaveFileDialog("Create a new Starbound Project");

			if (folder.FileName != string.Empty)
			{
				FreshProject(folder.FileName);

				Settings.SaveWorkingDirectory(folder.FileName);

				Settings.Save();
			}
		}

		public static bool LoadProject()
		{
			var folder = Functions.Dialogs.FolderBrowserDialog("Load Starbound Mod Folder");

			if (folder.SelectedPath != string.Empty)
			{
				Project.Settings.SaveWorkingDirectory(folder.SelectedPath);
				Settings.Save();

				return true;
			}

			return false;
		}

		public static bool LoadAssets()
		{
			var folder = Functions.Dialogs.FolderBrowserDialog("Load Assets Folder");

			if (folder.SelectedPath != string.Empty)
			{
				Project.Settings.SaveAssetsFolder(folder.SelectedPath);
				Settings.Save();

				return true;
			}

			return false;
		}

		// Child functions

		private static void FreshProject(string path)
		{
			Starbounder.Functions.Actions.CreateFolder(path);
			Project.ModInfo.Create(path, new Project.ModInfo().setDefault());
		}

		#region TreeView
		/// <summary>
		/// Populates the treeview with the folderpath.
		/// </summary>
		/// <returns></returns>
		public static TreeNode[] TreeViewPopulate(string path)
		{
			List<TreeNode> nodes = new List<TreeNode>();

			if (Directory.Exists(path))
			{
				DirectoryInfo info = new DirectoryInfo(path);

				if (info.Exists)
				{
					foreach (var folder in info.GetDirectories())
					{
						nodes.Add(CreateDirectoryNodes(folder));
					}

					foreach (var file in info.GetFiles())
					{
						TreeNode newNode = new TreeNode(file.Name);
						newNode.Tag = file.FullName;
						nodes.Add(newNode);
					}
				}
			}

			return nodes.ToArray();
		}

		/// <summary>
		/// Creates a new node from a DirectoryInfo.
		/// </summary>
		/// <param name="info"></param>
		/// <returns></returns>
		private static TreeNode CreateDirectoryNodes(DirectoryInfo info)
		{
			TreeNode directoryNode = new TreeNode(info.Name);
			directoryNode.Tag = info.FullName;

			foreach (var folder in info.GetDirectories())
			{
				directoryNode.Nodes.Add(CreateDirectoryNodes(folder));
			}

			foreach (var file in info.GetFiles())
			{
				TreeNode newNode = new TreeNode(file.Name);
				newNode.Tag = file.FullName;
				directoryNode.Nodes.Add(newNode);
			}

			return directoryNode;
		}
		#endregion

	}
}
