using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.Generate.Weapons
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
		public List<double> firePosition { get; set; }
		public double fireTime { get; set; }
		public bool fireAfterWindup { get; set; }
		public SoundEffect soundEffect { get; set; }
		public List<object> colorOptions { get; set; }
		public PrimaryStances primaryStances { get; set; }

		public class FireSound
		{
			public FireSound(string file)
			{
				this.file = file;
			}

			public string file { get; set; }
		}

		public class SoundEffect
		{
			public SoundEffect(List<FireSound> fireSound)
			{
				this.fireSound = fireSound;
			}

			public List<FireSound> fireSound { get; set; }
		}

		public class Projectile
		{
			public Projectile(double speed, double power)
			{
				this.speed = speed;
				this.power = power;
			}

			public double speed { get; set; }
			public double power { get; set; }
		}

		public class Idle
		{
			public Idle(bool twoHanded, int armAngle, int swordAngle, List<double> handPosition, double duration)
			{
				this.twoHanded    = twoHanded;
				this.armAngle     = armAngle;
				this.swordAngle   = swordAngle;
				this.handPosition = handPosition;
				this.duration     = duration;
			}

			public bool twoHanded { get; set; }
			public int armAngle { get; set; }
			public int swordAngle { get; set; }
			public List<double> handPosition { get; set; }
			public double duration { get; set; }
		}

		public class Windup
		{
			public Windup(bool twoHanded, int armAngle, int swordAngle, List<double> handPosition, double duration, List<object> statusEffects)
			{
				this.twoHanded = twoHanded;
				this.armAngle = armAngle;
				this.swordAngle = swordAngle;
				this.handPosition = handPosition;
				this.duration = duration;
				this.statusEffects = statusEffects;
			}

			public bool twoHanded { get; set; }
			public int armAngle { get; set; }
			public int swordAngle { get; set; }
			public List<double> handPosition { get; set; }
			public double duration { get; set; }
			public List<object> statusEffects { get; set; }
		}

		public class Cooldown
		{
			public Cooldown(bool twoHanded, int armAngle, int swordAngle, List<double> handPosition, double duration, List<object> statusEffects)
			{
				this.twoHanded = twoHanded;
				this.armAngle = armAngle;
				this.swordAngle = swordAngle;
				this.handPosition = handPosition;
				this.duration = duration;
				this.statusEffects = statusEffects;
			}

			public bool twoHanded { get; set; }
			public int armAngle { get; set; }
			public int swordAngle { get; set; }
			public List<double> handPosition { get; set; }
			public double duration { get; set; }
			public List<object> statusEffects { get; set; }
		}

		public class PrimaryStances
		{
			public PrimaryStances(bool directional, string projectileType, Projectile projectile, Idle idle, Windup windup, Cooldown cooldown)
			{
				this.directional    = directional;
				this.projectileType = projectileType;
				this.projectile     = projectile;
				this.idle           = idle;
				this.windup         = windup;
				this.cooldown       = cooldown;
			}

			public bool directional { get; set; }
			public string projectileType { get; set; }
			public Projectile projectile { get; set; }
			public Idle idle { get; set; }
			public Windup windup { get; set; }
			public Cooldown cooldown { get; set; }
		}

		public WeaponSword SetDefault()
		{
			itemName         = "Unique Name";
			price            = 0;
			level            = 0;
			maxStack         = 1;
			rarity           = "common";
			description      = "Description of the weapon.";
			shortdescription = "Name of the weapon";
			tooltipKind      = "sword";
			weaponType       = "type";
			itemTags         = new List<string>();
			image            = "image.png";
			firePosition     = new List<double>() { 10.5, -3.5 };
			fireTime         = 1.0;
			fireAfterWindup  = true;
			soundEffect      = new SoundEffect(new List<FireSound>() { new FireSound("/sfx/melee/swing_axe.ogg") } );
			colorOptions     = new List<object>();
			primaryStances   = new PrimaryStances(true, "projectileType", new Projectile(0.5, 5), new Idle(false, -90, -90, new List<double>() { -2.5, 12.5 }, 0.1), new Windup(false, 90, 90, new List<double>() { -2.5, 12.5 }, 0.5, new List<object>() { }), new Cooldown(false, -45, -90, new List<double>() { -2.5, -22.5 }, 0.5, new List<object>()));

			return this;
		}
	}
}
