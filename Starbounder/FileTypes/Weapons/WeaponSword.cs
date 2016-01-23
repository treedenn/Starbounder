using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.FileTypes.Weapons
{
	class WeaponSword
	{
		public string itemName { get; set; }
		public int price { get; set; }
		public int level { get; set; }
		public int maxStack { get; set; }
		public string rarity { get; set; }
		public string description { get; set; }
		public string shortdescription { get; set; }
		public string tooltipKind { get; set; }
		public string weaponType { get; set; }
		public List<string> itemTags { get; set; }
		public string image { get; set; }
		public List<int> firePosition { get; set; }
		public double fireTime { get; set; }
		public bool fireAfterWindup { get; set; }
		public SoundEffect soundEffect { get; set; }
		public List<object> colorOptions { get; set; }
		public PrimaryStances primaryStances { get; set; }

		public class FireSound
		{
			public string file { get; set; }
		}

		public class SoundEffect
		{
			public List<FireSound> fireSound { get; set; }
		}

		public class Projectile
		{
			public double speed { get; set; }
			public double power { get; set; }
		}

		public class Idle
		{
			public bool twoHanded { get; set; }
			public int armAngle { get; set; }
			public int swordAngle { get; set; }
			public List<double> handPosition { get; set; }
			public double duration { get; set; }
		}

		public class Windup
		{
			public bool twoHanded { get; set; }
			public int armAngle { get; set; }
			public int swordAngle { get; set; }
			public List<double> handPosition { get; set; }
			public double duration { get; set; }
			public List<object> statusEffects { get; set; }
		}

		public class Cooldown
		{
			public bool twoHanded { get; set; }
			public int armAngle { get; set; }
			public int swordAngle { get; set; }
			public List<double> handPosition { get; set; }
			public double duration { get; set; }
			public List<object> statusEffects { get; set; }
		}

		public class PrimaryStances
		{
			public bool directional { get; set; }
			public string projectileType { get; set; }
			public Projectile projectile { get; set; }
			public Idle idle { get; set; }
			public Windup windup { get; set; }
			public Cooldown cooldown { get; set; }
		}
	}
}
