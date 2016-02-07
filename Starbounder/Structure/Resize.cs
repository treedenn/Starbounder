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

		/*
		private const int Border = 10;

		public static bool IsResizing { get; set; }  = false;

		public static Cursor Cursor = Cursors.SizeWE;
		
		public static bool IsLeft(Form fm, Point MousePosition)
		{
			if (MousePosition.X < fm.Left + Border) 
			{
				return true;
			}

			return false;
		}

		public static bool IsRight(Form fm, Point MousePosition)
		{
			if (MousePosition.X > fm.Right - Border)
			{
				return true;
			}

			return false;
		}

		public static void ToLeft(Form fm, Point MousePosition, int startLocationX)
		{
			var screen = Placement.GetLocationWithinScreen(fm);

			if (screen != null)
			{
				var currScreen = Placement.GetCurrentMonitor(fm);

				fm.Left = MousePosition.X;

				int newWidth = (startLocationX - fm.Left) + (currScreen.Width - screen.Value.X);

				fm.Width = newWidth;

				Placement.SetFormToRightEdge(fm);
				
			}
		}

		public static void ToRight(Form fm, Point MousePosition, int startLocationX)
		{
			fm.Width = MousePosition.X - fm.Left;
		}
		*/
		

	}
}
