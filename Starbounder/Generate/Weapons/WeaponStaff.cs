using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.Generate.Weapons
{
	class WeaponStaff
	{
		public string itemName { get; set; }
		public string inventoryIcon { get; set; }
		public int maxStack { get; set; }
		public string rarity { get; set; }
		public string description { get; set; }
		public string shortdescription { get; set; }
		public string image { get; set; }
		public List<double> handPosition { get; set; }
		public List<double> firePosition { get; set; }
		public int level { get; set; }
		public double fireTime { get; set; }
		public double windupTime { get; set; }
		public double cooldown { get; set; }
		public bool twoHanded { get; set; }
		public bool fireOnRelease { get; set; }
		public int swingStart { get; set; }
		public int swingFinish { get; set; }
		public int coolingDownAngle { get; set; }
		public string projectileType { get; set; }
		public Projectile projectile { get; set; }
		public MuzzleEffect muzzleEffect { get; set; }
		public double level1ChargeTime { get; set; }
		public double level2ChargeTime { get; set; }
		public StaffChargingGlow staffChargingGlow { get; set; }

		public class Projectile
		{
			public Projectile(double speed, int power, List<int> color)
			{
				this.speed = speed;
				this.power = power;
				this.color = color;
			}

			public double speed { get; set; }
			public int power { get; set; }
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

			public List<FireSound> fireSound { get; set; }
		}

		public class StaffChargingGlow
		{
			public StaffChargingGlow(string file, int chargingFrames, int sparkFrames, int fireFrames, double sparkTime, double loopTime, List<int> offset)
			{
				this.file = file;
				this.chargingFrames = chargingFrames;
				this.sparkFrames = sparkFrames;
				this.loopFrames = loopFrames;
				this.fireFrames = fireFrames;
				this.sparkTime = sparkTime;
				this.loopTime = loopTime;
				this.offset = offset;
			}

			public string file { get; set; }
			public int chargingFrames { get; set; }
			public int sparkFrames { get; set; }
			public int loopFrames { get; set; }
			public int fireFrames { get; set; }
			public double sparkTime { get; set; }
			public double loopTime { get; set; }
			public List<int> offset { get; set; }
		}

		public WeaponStaff SetDefault()
		{
			itemName          = "Unique Name";
			inventoryIcon     = "inventoryIcon.png";
			maxStack          = 0;
			rarity            = "common";
			description       = "Description of the weapon";
			shortdescription  = "Name of the weapon";
			image             = "image.png";
			handPosition      = new List<double>() { 0, 0 };
			firePosition      = new List<double>() { 20, 5 };
			level             = 10;
			fireTime          = 1.0;
			windupTime        = 1.0;
			cooldown          = 1;
			twoHanded         = true;
			fireOnRelease     = true;
			swingStart        = 10;
			swingFinish       = 0;
			coolingDownAngle  = 0;
			projectileType    = "Custom Projectile";
			projectile        = new Projectile(10, 5, new List<int>() { 255, 255, 255 });
			muzzleEffect      = new MuzzleEffect(new List<FireSound>() { new FireSound("/sfx/gun/something.ogg")});
			level1ChargeTime  = 0.5;
			level2ChargeTime  = 1;
			staffChargingGlow = new StaffChargingGlow("staffglow.png", 10, 1, 2, 3, 0.25, new List<int>() { 0, 5 });

			return this;
		}
	}
}
