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
				if (File.Exists(path))
				{
					File.Delete(path);
				}
			}
			else
			{
				if (Directory.Exists(path))
				{
					Directory.Delete(path);
				}
			}
		}

		public static string Rename(string path)
		{
			string input = Dialogs.MessageBoxInput("Rename Message Input", "Enter the new name in the textbox for the file or folder.");

			if (Path.HasExtension(path) && input != string.Empty)
			{
				return RenameFile(path, input);
			}
			else if (input != string.Empty)
			{
				return RenameFolder(path, input);
			}

			return "";
		}

		public static string RenameFolder(string path, string newName)
		{
			if (Directory.Exists(path))
			{
				string newPath = Path.GetDirectoryName(path) + "\\" + newName;

				Directory.Move(path, newPath);

				return newPath;
			}

			return "";
		}

		public static string RenameFile(string path, string newName)
		{
			if (File.Exists(path))
			{
				string extension = Path.GetExtension(path);
				string newPath = Path.GetDirectoryName(path) + "\\" + newName + extension;

				File.Move(path, newPath);

				return newPath;
			}

			return "";
		}
	}
}
