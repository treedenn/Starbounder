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
			itemName         = "Unique Name";
			price            = 0;
			inventoryIcon    = "inventoryIcon.png";
			maxStack         = 1;
			rarity           = "common";
			description      = "Description of the tool.";
			shortdescription = "Name of the tool";
			largeImage       = "largeImage.png";
			image            = "image.png";
			frames           = 5;
			animationCycle   = 0.25;
			tooltipKind      = "tool";
			handPosition     = new List<int>() { -6, 3 };
			fireTime         = 0.25;
			blockRadius      = 5;
			altBlockRadius   = 1;
			twoHanded        = true;
			idleSound        = "/sfx/tools/something_idle.ogg";
			strikeSounds     = new List<string>() { "/sfx/tools/something_swing.ogg" };

			return this;
		}
	}
}
