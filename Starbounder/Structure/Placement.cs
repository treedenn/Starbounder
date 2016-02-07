using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbounder.Structure
{
	class Placement
	{
		public static Rectangle GetCurrentMonitor(Control ct)
		{
			Rectangle bounds = Screen.FromControl(ct).Bounds;
			return bounds;
		}

		public static Point? GetLocationWithinScreen(Form fm)
		{
			foreach (Screen screen in Screen.AllScreens)
			{
				if (screen.Bounds.Contains(fm.Location))
				{
					return new Point(fm.Location.X - screen.Bounds.Left,
						fm.Location.Y - screen.Bounds.Top);
				}
			}

			return null;
		}

		public static void SnapToEdge(Form fm)
		{
			var formLocation = GetLocationWithinScreen(fm);

			if (formLocation == null)
			{
				SetFormToLeftEdge(fm);
			}
			else
			{
				Rectangle monitor = GetCurrentMonitor(fm);

				int monCenterX = monitor.Width / 2;
				int formDeskX = formLocation.Value.X + fm.Width / 2;

				if (formDeskX <= monCenterX)
				{
					SetFormToLeftEdge(fm);
				}
				else
				{
					SetFormToRightEdge(fm);
				}
			}
		}

		public static void SetFormToRightEdge(Form fm)
		{
			Rectangle monitor = GetCurrentMonitor(fm);

			fm.SetDesktopLocation(monitor.Right - fm.Width, 0);
			fm.Size = new Size(fm.Size.Width, monitor.Bottom - fm.Location.Y);
		}

		public static void SetFormToLeftEdge(Form fm)
		{
			Rectangle monitor = GetCurrentMonitor(fm);

			fm.SetDesktopLocation(monitor.Left, 0);
			fm.Size = new Size(fm.Width, monitor.Bottom - fm.Location.Y);
		}
	}
}
