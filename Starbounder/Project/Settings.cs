using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbounder.Project
{
	class Settings
	{
		// Display

		public static Rectangle GetCurrentMonitor(Control ct)
		{
			Rectangle bounds = Screen.FromControl(ct).Bounds;
			return bounds;
		}

		public static void ChangeLocationRight(Form fm)
		{
			Rectangle monitor = GetCurrentMonitor(fm);

			fm.Size = new Size(250, monitor.Height);
			fm.DesktopLocation = new Point(monitor.Right - fm.Width, 0);
		}

		public static void ChangeLocationLeft(Form fm)
		{
			Rectangle monitor = GetCurrentMonitor(fm);

			fm.Size = new Size(250, monitor.Height);
			fm.DesktopLocation = new Point(monitor.Left, 0);
		}

		// SAVE

		public static void Save()
		{
			Properties.Settings.Default.Save();
			Properties.Settings.Default.Upgrade();
		}

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
