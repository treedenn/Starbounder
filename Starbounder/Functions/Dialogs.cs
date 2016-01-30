using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbounder.Functions
{
	class Dialogs
	{
		public static FolderBrowserDialog FolderBrowserDialog(string title, string startPath = "")
		{
			using (FolderBrowserDialog dialog = new FolderBrowserDialog())
			{
				dialog.Description = title;
				dialog.RootFolder = Environment.SpecialFolder.Desktop;
				dialog.ShowDialog();


				return (dialog.SelectedPath == string.Empty) ? null : dialog;
			}
		}

		public static SaveFileDialog SaveFileDialog(string title, string startPath = "")
		{
			using (SaveFileDialog dialog = new SaveFileDialog())
			{
				dialog.Title = title;
				dialog.InitialDirectory = startPath;
				dialog.ShowDialog();

				return dialog;
			}
		}

		public static DialogResult ShowMessage(string title, string message, MessageBoxButtons button, MessageBoxIcon icon)
		{
			return MessageBox.Show(message, title, button, icon);
		}

		public static string MessageBoxInput(string title, string message)
		{
			using (Forms.FormMessageBoxInput mb = new Forms.FormMessageBoxInput())
			{
				mb.formTitle = title;
				mb.labelMessage = message;
				mb.ShowDialog();

				return mb.inputText;
			}
		}
	}
}
