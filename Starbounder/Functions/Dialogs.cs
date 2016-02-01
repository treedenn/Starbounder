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
				dialog.SelectedPath = startPath;
				dialog.ShowDialog();


				return (dialog.SelectedPath == string.Empty) ? null : dialog;
			}
		}

		public static OpenFileDialog LoadFileDialog(string title, string filter = "All Files (*.*)|*.*")
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.Title = title;
				dialog.Filter = filter;
				dialog.ShowDialog();

				return dialog;
			}
		}

		public static SaveFileDialog SaveFileDialog(string title)
		{
			using (SaveFileDialog dialog = new SaveFileDialog())
			{
				dialog.Title = title;
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
