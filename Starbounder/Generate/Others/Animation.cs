using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.Generate.Others
{
	class Animation
	{
		public string frames { get; set; }
		public int variants { get; set; }
		public int frameNumber { get; set; }
		public int animationCycle { get; set; }
		public List<int> offset { get; set; }

		public Animation setDefault()
		{
			this.frames         = "frame_image.png";
			this.variants       = 1;
			this.frameNumber    = 20;
			this.animationCycle = 1;
			this.offset         = new List<int>();

			return this;
		}
	}
}
