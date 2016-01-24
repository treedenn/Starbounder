using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.FileTypes.Tools
{
	class ToolMining
	{
		public string itemName { get; set; }
		public int price { get; set; }
		public string inventoryIcon { get; set; }
		public int maxStack { get; set; }
		public string rarity { get; set; }
		public string tooltipKind { get; set; }
		public string description { get; set; }
		public string shortdescription { get; set; }
		public string largeImage { get; set; }
		public string image { get; set; }
		public int frames { get; set; }
		public double animationCycle { get; set; }
		public List<int> handPosition { get; set; }
		public bool pointable { get; set; }
		public int swingStart { get; set; }
		public int swingFinish { get; set; }
		public double fireTime { get; set; }
		public int blockRadius { get; set; }
		public int altBlockRadius { get; set; }
		public bool twoHanded { get; set; }
		public string idleSound { get; set; }
		public List<string> strikeSounds { get; set; }
		public string breakSound { get; set; }
		public int durability { get; set; }
		public int durabilityPerUse { get; set; }
		public double tileDamage { get; set; }
		public int harvestLevel { get; set; }
		public double tileDamageBlunted { get; set; }

		public ToolMining SetDefault()
		{
			this.itemName          = "Unique Name";
			this.price             = 0;
			this.inventoryIcon     = "inventoryIcon.png";
			this.maxStack          = 0;
			this.rarity            = "common";
			this.tooltipKind       = "tool";
			this.description       = "Description of the tool.";
			this.shortdescription  = "Name of the tool";
			this.largeImage        = "largeimage.png";
			this.image             = "image.png";
			this.frames            = 0;
			this.animationCycle    = 1;
			this.handPosition      = new List<int>() { -3, -4 };
			this.pointable         = true;
			this.swingStart        = -40;
			this.swingFinish       = 60;
			this.fireTime          = 0.5;
			this.blockRadius       = 3;
			this.altBlockRadius    = 1;
			this.twoHanded         = false;
			this.idleSound         = "";
			this.strikeSounds      = new List<string>() { "/sfx/tools/pickaxe_hit.ogg" };
			this.breakSound        = "/sfx/tools/pickaxe_break.ogg";
			this.durability        = 1000;
			this.durabilityPerUse  = 1;
			this.tileDamage        = 1;
			this.harvestLevel      = 3;
			this.tileDamageBlunted = 5.0;

			return this;
		}
	}
}
