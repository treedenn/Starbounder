using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Starbounder.FileTypes
{
	class Frames
	{
		public FrameGrid frameGrid { get; set; }
		public Aliases aliases { get; set; }

		public class FrameGrid
		{
			public List<int> size { get; set; }
			public List<int> dimensions { get; set; }
		}

		public class Aliases
		{
			public string idle { get; set; }
		}

		public Frames setDefault()
		{
			frameGrid            = new FrameGrid();
			aliases              = new Aliases();

			frameGrid.size       = new List<int>() { 20, 20 };
			frameGrid.dimensions = new List<int>() { 20, 20 };
			aliases.idle         = "0";

			return this;
		}
	}
}
