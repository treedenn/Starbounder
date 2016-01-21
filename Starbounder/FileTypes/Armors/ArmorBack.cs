using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.FileTypes.Armors
{
	class ArmorBack : Armor
	{
		public string itemName { get; set; }           = "Untitled Chest";
		public int price { get; set; }                 = 0;
		public string inventoryIcon { get; set; }      = "untitled.png";
		public int maxStack { get; set; }              = 0;
		public string rarity { get; set; }             = FileTypes.Enums.ItemEnums.Rarity.Common.ToString( "f" ).ToLower();
		public string description { get; set; }        = "A piece of equipment to protect your legs.";
		public string shortdescription { get; set; }   = "Legs Equipment";
		public string tooltipKind { get; set; }        = "armor";
		public string maleFrames { get; set; }         = "male.png";
		public string femaleFrames { get; set; }       = "female.png";
		public List<object> colorOptions { get; set; } = new List<object>();

	}
}
