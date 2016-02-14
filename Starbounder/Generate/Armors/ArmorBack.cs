using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.Generate.Armors
{
	class ArmorBack
	{
		public string itemName { get; set; }
		public int price { get; set; }
		public string inventoryIcon { get; set; }
		public int maxStack { get; set; }
		public string rarity { get; set; }
		public string description { get; set; }
		public string shortdescription { get; set; }
		public string tooltipKind { get; set; }
		public string maleFrames { get; set; }
		public string femaleFrames { get; set; }
		public List<object> colorOptions { get; set; }

		public ArmorBack SetDefault()
		{
			this.itemName         = "Untitled Chest";
			this.price            = 0;
			this.inventoryIcon    = "untitled.png";
			this.maxStack         = 0;
			this.rarity           = "common";
			this.description      = "A piece of equipment to protect your legs.";
			this.shortdescription = "Legs Equipment";
			this.tooltipKind      = "armor";
			this.maleFrames       = "male.png";
			this.femaleFrames     = "female.png";
			this.colorOptions     = new List<object>();

			return this;
		}

	}
}
