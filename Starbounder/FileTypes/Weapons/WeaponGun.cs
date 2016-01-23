using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.FileTypes.Weapons
{
	class WeaponGun
	{
		public string itemName { get; set; }
		public int price { get; set; }
		public string inventoryIcon { get; set; }
		public int maxStack { get; set; }
		public string rarity { get; set; }
		public string description { get; set; }
		public string shortdescription { get; set; }
		public string image { get; set; }
		public List<int> handPosition { get; set; }
		public List<int> firePosition { get; set; }
		public double recoilTime { get; set; }
		public int level { get; set; }
		public string tooltipKind { get; set; }
		public string weaponType { get; set; }
		public List<string> itemTags { get; set; }
		public double fireTime { get; set; }
		public double inaccuracy { get; set; }
		public bool twoHanded { get; set; }
		public bool walkWhileFiring { get; set; }
		public string projectileType { get; set; }
		public Projectile projectile { get; set; }
		public MuzzleEffect muzzleEffect { get; set; }

		public class Projectile
		{
			public int speed { get; set; }
			public int life { get; set; }
			public double power { get; set; }
			public List<int> color { get; set; }
		}

		public class FireSound
		{
			public string file { get; set; }
		}

		public class MuzzleEffect
		{
			public List<FireSound> fireSound { get; set; }
			public string animation { get; set; }
		}
	}
}
