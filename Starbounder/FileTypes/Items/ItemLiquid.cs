using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.FileTypes.Items
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
	}
}
