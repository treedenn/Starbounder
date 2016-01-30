using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.FileTypes.Others
{
	class Consumable
	{
		public string itemName { get; set; }
		public string rarity { get; set; }
		public int price { get; set; }
		public string inventoryIcon { get; set; }
		public string description { get; set; }
		public string shortdescription { get; set; }
		public List<List<string>> effects { get; set; }
		public List<string> blockingEffects { get; set; }
		public List<string> learnBlueprintsOnPickup { get; set; }

		public Consumable SetDefault()
		{
			itemName                = "Unique Name";
			rarity                  = "common";
			price                   = 0;
			inventoryIcon           = "inventoryIcon.png";
			description             = "Description of the item";
			shortdescription        = "Name of the item";
			effects                 = new List<List<string>>();
			blockingEffects         = new List<string>();
			learnBlueprintsOnPickup = new List<string>();

			return this;
		}

	}
}
