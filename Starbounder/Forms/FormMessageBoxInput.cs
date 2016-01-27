using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbounder.Forms
{
	public partial class FormMessageBoxInput : Form
	{
		public FormMessageBoxInput()
		{
			InitializeComponent();
		}

		// Form title
		internal string formTitle { get; set; }
		// Form message
		internal string labelMessage { get; set; }
		// Textbox text
		internal string textboxText { get; set; }

		// Input text
		internal string inputText { get; set; }

		private void FormMessageBoxInput_Load(object sender, EventArgs e)
		{
			Text                = formTitle;
			labelMBText.Text    = labelMessage;
			textBoxMBInput.Text = textboxText;
		}

		private void buttonMBOK_Click(object sender, EventArgs e)
		{
			inputText = textBoxMBInput.Text;
			Close();
		}

		private void buttonMBCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
