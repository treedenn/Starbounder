using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.FileTypes.Items
{
	class ItemItem
	{
		public string itemName { get; set; }
		public int price { get; set; }
		public string rarity { get; set; }
		public string inventoryIcon { get; set; }
		public string description { get; set; }
		public string shortdescription { get; set; }
		public List<string> learnBlueprintsOnPickup { get; set; }

		public ItemItem SetDefault()
		{
			this.itemName                = "Unique Name";
			this.price                   = 0;
			this.rarity                  = "common";
			this.inventoryIcon           = "inventoryIcon.png";
			this.description             = "Description of the item";
			this.shortdescription        = "Name of the item";
			this.learnBlueprintsOnPickup = new List<string>();

			return this;
		}
	}
}
