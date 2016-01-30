using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbounder.Project
{
	class Settings
	{
		// SAVE

		public static void SaveSystem(bool Win64)
		{
			Properties.Settings.Default.OperationSystem64 = Win64;
		}

		public static void SaveWorkingDirectory(string path)
		{
			Properties.Settings.Default.ModDirectory = path;
		}

		// LOAD

		public static bool LoadSystem()
		{
			return Properties.Settings.Default.OperationSystem64;
		}

		public static string LoadWorkingDirectory()
		{
			return Properties.Settings.Default.ModDirectory;
		}
	}
}
