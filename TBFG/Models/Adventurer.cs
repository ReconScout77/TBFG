using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TBFG.Models
{
    [Table("Adventurers")]
    public class Adventurer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string HeroClass { get; set; }
        public int Level { get; set; }
        //Current exp, exp required for next lvl
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Attacks { get; set; }
        public int MaxDamage { get; set; }
        public int DamageModifier { get; set; }
        public int HitChanceModifier { get; set; }
        public int ArmorClass { get; set; }
        //Spells/Abilities

		public virtual ApplicationUser User { get; set; }

        public Adventurer()
        {
        }

        //Need logic for attacking/using spells/abilities
    }
}
