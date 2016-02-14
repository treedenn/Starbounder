using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.Generate.Items
{
	class ItemLiquid
	{
		public string itemName { get; set; }
		public string rarity { get; set; }
		public string inventoryIcon { get; set; }
		public string shortdescription { get; set; }
		public string description { get; set; }
		public string liquid { get; set; }
		public List<string> learnBlueprintsOnPickup { get; set; }

		public ItemLiquid SetDefault()
		{
			this.itemName                = "Unique Name";
			this.rarity                  = "common";
			this.inventoryIcon           = "inventoryIcon.png";
			this.description             = "Description of the item";
			this.shortdescription        = "Name of the item";
			this.liquid                  = "Name of the liquid";
			this.learnBlueprintsOnPickup = new List<string>();

			return this;
		}
	}
}
