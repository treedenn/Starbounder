using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbounder.FileLayout
{
	class LayoutControls
	{
		public static Button CreateButton(string btnText)
		{
			Button btn = new Button();
			btn.Text = btnText;
			btn.Anchor = AnchorStyles.None;
			return btn;
		}

		public static Label CreateLabel(string labelText)
		{
			Label label = new Label();
			label.Text = labelText;
			label.Anchor = AnchorStyles.None;
			return label;
		}

		public static TextBox CreateTextbox(string tbText)
		{
			TextBox tb = new TextBox();
			tb.Text = tbText;
			tb.Anchor = AnchorStyles.None;
			return tb;
		}
	}
}
