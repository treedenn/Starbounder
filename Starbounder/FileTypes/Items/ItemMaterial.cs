using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.FileTypes.Items
{
	class ItemMaterial
	{
		public string itemName { get; set; }
		public int price { get; set; }
		public string rarity { get; set; }
		public string inventoryIcon { get; set; }
		public string description { get; set; }
		public string shortdescription { get; set; }
		public string glitchdescription { get; set; }
		public string florandescription { get; set; }
		public int materialId { get; set; }

		public ItemMaterial SetDefault()
		{
			this.itemName          = "Unique Name";
			this.price             = 0;
			this.rarity            = "common";
			this.inventoryIcon     = "inventoryIcon.png";
			this.description       = "Description of the item";
			this.shortdescription  = "Name of the item";
			this.glitchdescription = "Explains itself.";
			this.florandescription = "Explains itself.";
			this.materialId        = 0;

			return this;
		}
	}
}
