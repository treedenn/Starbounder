using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.FileTypes.Tools
{
	class ToolBeamaxe
	{
		public string itemName { get; set; }
		public int price { get; set; }
		public string inventoryIcon { get; set; }
		public string rarity { get; set; }
		public int maxStack { get; set; }
		public string description { get; set; }
		public string shortdescription { get; set; }
		public string largeImage { get; set; }
		public string tooltipKind { get; set; }
		public string category { get; set; }
		public double fireTime { get; set; }
		public int blockRadius { get; set; }
		public int altBlockRadius { get; set; }
		public double tileDamage { get; set; }
		public int harvestLevel { get; set; }
		public bool canCollectLiquid { get; set; }
		public bool twoHanded { get; set; }
		public List<string> strikeSounds { get; set; }
		public string image { get; set; }
		public List<string> endImages { get; set; }
		public List<int> handPosition { get; set; }
		public List<int> firePosition { get; set; }
		public int segmentsPerUnit { get; set; }
		public double nearControlPointElasticity { get; set; }
		public double farControlPointElasticity { get; set; }
		public double nearControlPointDistance { get; set; }
		public int targetSegmentRun { get; set; }
		public int innerBrightnessScale { get; set; }
		public double firstStripeThickness { get; set; }
		public double secondStripeThickness { get; set; }
		public int minBeamWidth { get; set; }
		public int maxBeamWidth { get; set; }
		public double minBeamJitter { get; set; }
		public double maxBeamJitter { get; set; }
		public double minBeamTrans { get; set; }
		public double maxBeamTrans { get; set; }
		public int minBeamLines { get; set; }
		public int maxBeamLines { get; set; }
	}
}
