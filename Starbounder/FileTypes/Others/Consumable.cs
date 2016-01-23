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
	}
}
