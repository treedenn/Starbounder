using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbounder.Renderer
{
	class ToolStrips : ToolStripProfessionalRenderer
	{
		protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
		{
			int height = e.Item.Height;
			int width = e.Item.Width;

			e.Graphics.FillRectangle(SystemBrushes.Desktop, 0, 0, width, height);
			e.Graphics.DrawLine(Pens.Gray, 4, height / 2, width - 4, height / 2);
		}

		public ToolStrips() : base(new MyColors()) { }

		private class MyColors : ProfessionalColorTable
		{
			public override Color MenuItemSelected
			{
				get { return Color.DarkSlateGray; }
			}
			public override Color MenuItemSelectedGradientBegin
			{
				get { return Color.Transparent; }
			}
			public override Color MenuItemSelectedGradientEnd
			{
				get { return Color.Transparent; }
			}
			public override Color MenuItemBorder
			{
				get { return Color.LightSlateGray; }
			}
		}
	}
}
