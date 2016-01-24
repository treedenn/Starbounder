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
		public static FolderBrowserDialog FolderBrowserDialog(string title)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();

			dialog.Description = title;
			dialog.ShowDialog();

			return dialog;
		}

		public static SaveFileDialog SaveFileDialog(string title)
		{
			SaveFileDialog dialog = new SaveFileDialog();

			dialog.Title = title;
			dialog.ShowDialog();

			return dialog;
		}

		public static DialogResult ShowMessage(string title, string message, MessageBoxButtons button, MessageBoxIcon icon)
		{
			return MessageBox.Show(message, title, button, icon);
		}
	}
}
