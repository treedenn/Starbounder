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

		public static void SaveAuthor(string author)
		{
			Properties.Settings.Default.Author = author;
		}

		public static void SaveSBVersion(string sbversion)
		{
			Properties.Settings.Default.SBVersion = sbversion;
		}

		public static void SaveTextEditor(string path)
		{
			Properties.Settings.Default.TextEditor = path;
		}

		public static void SaveImageEditor(string path)
		{
			Properties.Settings.Default.ImageEditor = path;
		}

		public static void SaveStarboundFolder(string path)
		{
			Properties.Settings.Default.StarboundFolder = path;
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

		public static string LoadAuthor()
		{
			return Properties.Settings.Default.Author;
		}

		public static string LoadSBVersion()
		{
			return Properties.Settings.Default.SBVersion;
		}

		public static string LoadTextEditor()
		{
			return Properties.Settings.Default.TextEditor;
		}

		public static string LoadImageEditor()
		{
			return Properties.Settings.Default.ImageEditor;
		}

		public static string LoadStarboundFolder()
		{
			return Properties.Settings.Default.StarboundFolder;
		}
	}
}
