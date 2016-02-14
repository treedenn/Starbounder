using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Starbounder.Generate.Others
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
			this.frameGrid = new FrameGrid() { size = { 20, 20 }, dimensions = { 20, 20 } };
			this.aliases   = new Aliases() { idle = "0" };

			return this;
		}
	}
}
