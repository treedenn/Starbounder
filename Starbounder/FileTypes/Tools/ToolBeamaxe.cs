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

		public ToolBeamaxe SetDefault()
		{
			itemName                   = "Unique Name";
			price                      = 0;
			inventoryIcon              = "inventoryIcon.png";
			rarity                     = "common";
			maxStack                   = 1;
			description                = "Description of the tool.";
			shortdescription           = "Name of the tool";
			largeImage                 = "largeImage.png";
			tooltipKind                = "tool";
			category                   = "Tool;[R]";
			fireTime                   = 0.25;
			blockRadius                = 5;
			altBlockRadius             = 1;
			tileDamage                 = 2;
			harvestLevel               = 5;
			canCollectLiquid           = true;
			twoHanded                  = true;
			strikeSounds               = new List<string>() { "/sfx/tools/atom.ogg", "/sfx/tools/atom2.ogg", "/sfx/tools/atom3.ogg", "/sfx/tools/atom4.ogg", "/sfx/tools/atom5.ogg" };
			image                      = "image.png";
			endImages                  = new List<string>() { "humanoid/any/gravgun1.png" };
			handPosition               = new List<int>() { -2, 0 };
			firePosition               = new List<int>() { 5, 0 };
			segmentsPerUnit            = 1;
			nearControlPointElasticity = 0.1;
			farControlPointElasticity  = 0.9;
			nearControlPointDistance   = 0.9;
			targetSegmentRun           = 1;
			innerBrightnessScale       = 20;
			firstStripeThickness       = 0.05;
			secondStripeThickness      = 0.1;
			minBeamWidth               = 2;
			maxBeamWidth               = 4;
			minBeamJitter              = 0.05;
			maxBeamJitter              = 0.1;
			minBeamTrans               = 0.1;
			maxBeamTrans               = 0.4;
			minBeamLines               = 3;
			maxBeamLines               = 5;

			return this;
		}
	}
}
