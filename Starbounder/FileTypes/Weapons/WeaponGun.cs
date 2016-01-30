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
		public string powerProjectileType { get; set; } // Bows
		public List<double> powerProjectileTime { get; set; } // Bows
		public string drawSpeedCurve { get; set; } // Bows
		public string drawPowerCurve { get; set; } // Bows
		public Projectile projectile { get; set; }
		public MuzzleEffect muzzleEffect { get; set; }

		public class Projectile
		{
			public Projectile(int speed, int life, double power, List<int> color)
			{
				this.speed = speed;
				this.life  = life;
				this.power = power;
				this.color = color;
			}

			public int speed { get; set; }
			public int life { get; set; }
			public double power { get; set; }
			public List<int> color { get; set; }
		}

		public class FireSound
		{
			public FireSound(string file)
			{
				this.file = file;
			}

			public string file { get; set; }
		}

		public class MuzzleEffect
		{
			public MuzzleEffect(List<FireSound> fireSound)
			{
				this.fireSound = fireSound;
			}
			public MuzzleEffect(List<FireSound> fireSound, string animation)
			{
				this.fireSound = fireSound;
				this.animation = animation;
			}

			public List<FireSound> fireSound { get; set; }
			public string animation { get; set; }
		}

		public WeaponGun SetDefault()
		{
			itemName            = "Unique Name";
			price               = 0;
			inventoryIcon       = "inventoryIcon.png";
			maxStack            = 1;
			rarity              = "common";
			description         = "Description of the weapon";
			shortdescription    = "Name of the weapon";
			image               = "image.png";
			handPosition        = new List<int>() { 0, 0 };
			firePosition        = new List<int>() { 20, 5 };
			recoilTime          = 1.0;
			level               = 1;
			tooltipKind         = "gun";
			weaponType          = "Custom Gun";
			itemTags            = new List<string>();
			fireTime            = 2.0;
			inaccuracy          = 0.05;
			twoHanded           = false;
			walkWhileFiring     = false;
			projectileType      = "Custom Projectile";
			powerProjectileType = "Charged Custom Projectile";
			powerProjectileTime = new List<double>() { 0.9, 60 };
			drawSpeedCurve      = "drawTimeMultiplier";
			drawPowerCurve      = "drawTimeMultiplier";
			projectile          = new Projectile(80, 0, 5, new List<int>() { 255, 255, 255 });
			muzzleEffect        = new MuzzleEffect(new List<FireSound>() { new FireSound("/sfx/gun/something.ogg") });

			return this;
		}
	}
}
