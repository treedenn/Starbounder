using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.FileTypes.Tools
{
	class ToolHarvesting
	{
		public string itemName { get; set; }
		public int price { get; set; }
		public string inventoryIcon { get; set; }
		public int maxStack { get; set; }
		public string rarity { get; set; }
		public string description { get; set; }
		public string shortdescription { get; set; }
		public string largeImage { get; set; }
		public string image { get; set; }
		public int frames { get; set; }
		public double animationCycle { get; set; }
		public string tooltipKind { get; set; }
		public List<int> handPosition { get; set; }
		public double fireTime { get; set; }
		public int blockRadius { get; set; }
		public int altBlockRadius { get; set; }
		public bool twoHanded { get; set; }
		public string idleSound { get; set; }
		public List<string> strikeSounds { get; set; }

		public ToolHarvesting SetDefault()
		{


			return this;
		}
	}
}
