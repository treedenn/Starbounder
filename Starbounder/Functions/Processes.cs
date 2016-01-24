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

			string fileName = "", filePath = Project.IProject.sbPath;

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
			string unpackerPath = ( Win64 ) ? "win64\\asset_unpacker.exe" : "win32\\asset_unpacker.exe";
			string appPath      = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
			string folderName   = "\\assets unpacked";
			string command      = " \"assets\\packed.pak\" " + $"\"{appPath}" + folderName +"\"";

			if (Directory.Exists(appPath + folderName))
			{
				var result = Functions.Dialogs.ShowMessage("Folder already exist.", "Do you wanna replace folder?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

				if (result == DialogResult.No)
				{
					return false;
				}
			}

			Process cmd = new Process();

			cmd.StartInfo.FileName         = "cmd.exe";
			cmd.StartInfo.Arguments        = "/c " + unpackerPath + command;
			cmd.StartInfo.WorkingDirectory = Project.IProject.sbPath;
			cmd.StartInfo.WindowStyle      = ProcessWindowStyle.Hidden;

			cmd.Start();
			cmd.WaitForExit();

			return true;
		}
	}
}
