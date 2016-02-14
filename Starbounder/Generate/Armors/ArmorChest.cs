using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.Generate.Armors
{
	class ArmorChest
	{
		public string itemName { get; set; }
		public int price { get; set; }
		public string inventoryIcon { get; set; }
		public int maxStack { get; set; }
		public string rarity { get; set; }
		public string description { get; set; }
		public string shortdescription { get; set; }
		public string tooltipKind { get; set; }
		public MaleFrames maleFrames { get; set; }
		public FemaleFrames femaleFrames { get; set; }
		public List<StatusEffect> statusEffects { get; set; }
		public List<object> colorOptions { get; set; }
		public List<string> learnBlueprintsOnPickup { get; set; }

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

		public ArmorChest SetDefault()
		{
			this.itemName                = "Untitled Chest";
			this.price                   = 0;
			this.inventoryIcon           = "untitled.png";
			this.maxStack                = 1;
			this.rarity                  = "common";
			this.description             = "A piece of equipment to protect your chest.";
			this.shortdescription        = "Chest Equipment";
			this.tooltipKind             = "armor";
			this.maleFrames              = new MaleFrames();
			this.femaleFrames            = new FemaleFrames();
			this.statusEffects           = new List<StatusEffect>();
			this.colorOptions            = new List<object>();
			this.learnBlueprintsOnPickup = new List<string>();

			return this;
		}
	}
}
