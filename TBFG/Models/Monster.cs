using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TBFG.Models
{
	[Table("Monsters")]
	public class Monster
	{
		[Key]
		public int MonId { get; set; }
		public string MonType { get; set; }
        //Level?
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Attacks { get; set; }
        public int MaxDamage { get; set; }
        public int DamageModifier { get; set; }
        public int HitChanceModifier { get; set; }
        public int ArmorClass { get; set; }
        //Exp given on defeat

		public Monster()
		{
		}

        //Need logic for attacking
	}
}
