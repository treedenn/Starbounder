using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbounder.Structure
{
	class ReSize
	{
		// Was only an experiment to see, if I could resize the form... Resize is right <-- direction was painful.

		private const int Border = 10;

		private Form fm;

		public bool IsResizing { get; set; }       = false;
		public bool ResizingLeft { get; set; }     = false;

		public Cursor Cursor { get; } = Cursors.SizeWE;

		public ReSize(Form fm)
		{
			this.fm = fm;
		}

		public void EnableResize()
		{
			if (fm.Cursor == Cursor)
			{
				IsResizing = true;
			}
		}

		public void DisableResize()
		{
			IsResizing = false;
		}

		public bool IsLeft(Point MousePosition)
		{
			if (MousePosition.X < fm.Left + Border)
			{
				ResizingLeft = true;
				return true;
			}

			return false;
		}

		public bool IsRight(Point MousePosition)
		{
			if (MousePosition.X > fm.Right - Border)
			{
				ResizingLeft = false;
				return true;
			}

			return false;
		}

		public void ToLeft(Point MousePosition)
		{
			var monitor = Placement.GetCurrentMonitor(fm);

			fm.Width = monitor.Width - MousePosition.X;
			Placement.SetFormToRightEdge(fm);
		}

		public void ToRight(Point MousePosition)
		{
			fm.Width = MousePosition.X;
			Placement.SetFormToLeftEdge(fm);
		}


	}
}
