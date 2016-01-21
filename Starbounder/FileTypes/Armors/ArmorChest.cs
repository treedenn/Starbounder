using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.FileTypes.Armors
{
	class ArmorChest : Armor
	{
		public string itemName { get; set; }                      = "Untitled Chest";
		public int price { get; set; }                            = 0;
		public string inventoryIcon { get; set; }                 = "untitled.png";
		public int maxStack { get; set; }                         = 1;
		public string rarity { get; set; }                        = FileTypes.Enums.ItemEnums.Rarity.Common.ToString("f").ToLower();
		public string description { get; set; }                   = "A piece of equipment to protect your chest.";
		public string shortdescription { get; set; }              = "Chest Equipment";
		public string tooltipKind { get; set; }                   = "armor";
		public MaleFrames maleFrames { get; set; }                = new MaleFrames();
		public FemaleFrames femaleFrames { get; set; }            = new FemaleFrames();
		public List<StatusEffect> statusEffects { get; set; }     = new List<StatusEffect>();
		public List<object> colorOptions { get; set; }            = new List<object>();
		public List<string> learnBlueprintsOnPickup { get; set; } = new List<string>();

		public class MaleFrames
		{
			public string body { get; set; }
			public string backSleeve { get; set; }
			public string frontSleeve { get; set; }
		}

		public class FemaleFrames
		{
			public string body { get; set; }
			public string backSleeve { get; set; }
			public string frontSleeve { get; set; }
		}

		public class StatusEffect
		{
			public string stat { get; set; }
			public double baseMultiplier { get; set; }
			public int? amount { get; set; }
		}
	}
}
