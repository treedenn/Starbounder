using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbounder.FileTypes.Weapons
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
			public double speed { get; set; }
			public int power { get; set; }
			public List<int> color { get; set; }
		}

		public class FireSound
		{
			public string file { get; set; }
		}

		public class MuzzleEffect
		{
			public List<FireSound> fireSound { get; set; }
		}

		public class StaffChargingGlow
		{
			public string file { get; set; }
			public int chargingFrames { get; set; }
			public int sparkFrames { get; set; }
			public int loopFrames { get; set; }
			public int fireFrames { get; set; }
			public double sparkTime { get; set; }
			public double loopTime { get; set; }
			public List<int> offset { get; set; }
		}
	}
}
