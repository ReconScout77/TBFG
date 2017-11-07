using System;
namespace TBFG.Models
{
    [Table("Adventurers")]
    public class Adventurer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string HeroClass { get; set; }
        public virtual ApplicationUser User { get; set; }

        public Adventurer()
        {
        }
    }
}
