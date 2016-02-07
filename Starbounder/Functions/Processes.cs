using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbounder.Functions
{
	class Processes
	{
		/// <summary>
		/// Launches Starbound on either 64/32 bit with opengl or not.
		/// </summary>
		public static void LaunchStarbound(bool Win64, bool OpenGL)
		{
			ProcessStartInfo process = new ProcessStartInfo();

			string fileName = "", filePath = Project.Settings.LoadWorkingDirectory();

			filePath += ( Win64 ) ? "\\win64" : "\\win32";
			fileName = ( OpenGL ) ? "starbound_opengl.exe" : "starbound.exe";

			process.FileName = fileName;
			process.WorkingDirectory = filePath;

			Process.Start(process);
		}

		/// <summary>
		/// Opens a folder at a specific location.
		/// </summary>
		public static void OpenFolder(string folderPath)
		{
			if (Directory.Exists(folderPath))
			{
				ProcessStartInfo process = new ProcessStartInfo("explorer.exe", folderPath);
				Process.Start(process);
			}
		}

		/// <summary>
		/// Unpack assets in Starbound Folder.
		/// </summary>
		public static bool UnpackStarbound(bool Win64)
		{
			string appPath      = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
			string system       = ( Win64 ) ? "win64" : "win32";
			string programEXE   = "asset_unpacker.exe";

			string assetsFolder = "assets unpacked";
			string assetsPath   = appPath + "\\" + assetsFolder;

			string unpackerPath = system + "\\" + programEXE;
			string command      = " \"assets\\packed.pak\" " + "\"" + assetsPath +"\"";

			var result = Functions.Dialogs.ShowMessage("Unpack Starbound Assets", "This process might take a while and uses a lot of space (~500 MB)\nDo you want to continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if (result == DialogResult.No)
			{
				return false;
			}

			if (Directory.Exists(assetsPath))
			{
				result = Functions.Dialogs.ShowMessage("Folder already exist.", "Do you want to continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

				if (result == DialogResult.No)
				{
					return false;
				}
			}

			Process cmd = new Process();
			cmd.StartInfo.FileName         = "cmd.exe";
			cmd.StartInfo.Arguments        = "/c " + unpackerPath + command;
			cmd.StartInfo.WorkingDirectory = Project.Settings.LoadStarboundFolder();
			cmd.StartInfo.WindowStyle      = ProcessWindowStyle.Hidden;

			cmd.Start();
			cmd.WaitForExit();

			Project.Settings.SaveAssetsFolder(assetsPath);

			return true;
		}

		public static void OpenFileWithTextEditor(string filePath)
		{
			string te = Starbounder.Project.Settings.LoadTextEditor(); // Text editor

			if (File.Exists(te) && File.Exists(filePath))
			{
				ProcessStartInfo startInfo = new ProcessStartInfo();

				startInfo.FileName = te;
				startInfo.Arguments = "\"" + filePath + "\"";

				Process.Start(startInfo);
			}
		}

		public static void OpenFileWithImageEditor(string filePath)
		{
			string ie = Starbounder.Project.Settings.LoadImageEditor(); // Text editor

			if (File.Exists(ie) && File.Exists(filePath))
			{
				ProcessStartInfo startInfo = new ProcessStartInfo();

				startInfo.FileName = ie;
				startInfo.Arguments = "\"" + filePath + "\"";

				Process.Start(startInfo);
			}
		}
	}
}
