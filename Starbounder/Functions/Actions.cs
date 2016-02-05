using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbounder.Functions
{
	class Actions
	{
		
		public static void CreateFolder(string path)
		{
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
		}
		
		public static void Delete(string path)
		{
			if (Path.HasExtension(path))
			{
				// Path is a file.
				if (File.Exists(path))
				{
					File.Delete(path);
				}
			}
			else
			{
				// Path is a folder.
				if (Directory.Exists(path))
				{
					Directory.Delete(path);
				}
			}
		}

		public static void Move(string oldPath)
		{
			FolderBrowserDialog folder = Dialogs.FolderBrowserDialog("Select new location for the folder or file.", Project.Settings.LoadWorkingDirectory());

			string newPath = (folder != null) ? folder.SelectedPath : string.Empty;
			string name = Path.GetFileName(oldPath);

			if (Path.HasExtension(oldPath) && folder != null)
			{
				if (File.Exists(oldPath))
				{
					File.Move(oldPath, newPath + "\\" + name);
				}
			} else if (folder != null)
			{
				if (Directory.Exists(oldPath))
				{
					Directory.Move(oldPath, newPath + "\\" + name);
				}
			}

		}

		public static void Rename(string path)
		{
			string newName = Dialogs.MessageBoxInput("Rename Message Input", "Enter the new name in the textbox for the file or folder.");

			if (Path.HasExtension(path) && newName != string.Empty)
			{ 
				// Path is a file.
				if (File.Exists(path))
				{
					string extension = Path.GetExtension(path);
					string newPath = Path.GetDirectoryName(path) + "\\" + newName + extension;

					File.Move(path, newPath);
				}
			}
			else if (newName != string.Empty)
			{
				// Path is a folder.
				if (Directory.Exists(path))
				{
					string newPath = Path.GetDirectoryName(path) + "\\" + newName;

					Directory.Move(path, newPath);
				}
			}
		}

	}
}
