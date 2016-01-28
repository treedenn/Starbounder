using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbounder.FileLayout
{
	class GenerateLayout
	{
		public static void GenerateItem(FlowLayoutPanel flp)
		{
			flp.Controls.Clear();

			flp.Controls.Add(LayoutControls.CreateLabel("Hallo"));
			flp.Controls.Add(LayoutControls.CreateTextbox("Hallo"));

			flp.Show();

		}
	}
}
