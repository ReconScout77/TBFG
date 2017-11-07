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
        //HP
        //Damage range
        //Damage modifier
        //Hit chance modifier
        //Armor class
        //Exp given on defeat

		public Monster()
		{
		}

        //Need logic for attacking
	}
}
