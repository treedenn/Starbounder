using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.Generate.Others
{
	class Liquid
	{
		public string name { get; set; }
		public int liquidId { get; set; }
		public string description { get; set; }
		public int tickDelta { get; set; }
		public List<int> color { get; set; }
		public List<int> radiantLight { get; set; }
		public string itemDrop { get; set; }
		public string texture { get; set; }
		public List<int> bottomLightMix { get; set; }
		public double textureMovementFactor { get; set; }
		public List<object> interactions { get; set; }

		public Liquid SetDefault()
		{
			this.name                  = "Liquid Name";
			this.liquidId              = 20;
			this.description           = "Description of the liquid.";
			this.tickDelta             = 1;
			this.color                 = new List<int>() { 255, 255, 255, 255 };
			this.radiantLight          = new List<int>() { 60, 60, 60 }; ;
			this.itemDrop              = "The unique name of the liquid";
			this.texture               = "/liquids/liquidtex.png";
			this.bottomLightMix        = new List<int>() { 100, 100, 100 };
			this.textureMovementFactor = 3;
			this.interactions          = new List<object>();

			return this;
		}
	}
}
