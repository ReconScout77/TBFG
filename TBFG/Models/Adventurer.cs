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
		//Level
        //Exp stuff
        //HP
		//Damage range
		//Damage modifier
		//Hit chance modifier
		//Armor class
        //Spells/Abilities

		public virtual ApplicationUser User { get; set; }

        public Adventurer()
        {
        }

        //Need logic for attacking/using spells/abilities
    }
}
