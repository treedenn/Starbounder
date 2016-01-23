using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.FileTypes.Weapons
{
	class WeaponThrown
	{
		public string itemName { get; set; }
		public string rarity { get; set; }
		public string inventoryIcon { get; set; }
		public string image { get; set; }
		public string shortdescription { get; set; }
		public string description { get; set; }
		public int ammoUsage { get; set; }
		public bool edgeTrigger { get; set; }
		public double windupTime { get; set; }
		public double cooldown { get; set; }
		public string projectileType { get; set; }
		public ProjectileConfig projectileConfig { get; set; }

		public class ProjectileConfig
		{
			public int speed { get; set; }
			public int power { get; set; }
		}
	}
}
