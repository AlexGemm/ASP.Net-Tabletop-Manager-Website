using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWebsite.Models
{
    public class Statblock
    {

        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(0, 100)]
        public int AC { get; set; }
        public Boolean Shield { get; set; }
        [Required]
        [Range(0, 10000)]
        public int Health { get; set; }
        [Required]
        [Range(0, 1000)]
        public int Speed { get; set; }

        [Required]
        [Range(0, 50)]
        public int Strength { get; set; }
        [Required]
        [Range(0, 50)]
        public int Dexterity { get; set; }
        [Required]
        [Range(0, 50)]
        public int Constitution { get; set; }
        [Required]
        [Range(0, 50)]
        public int Intelligence { get; set; }
        [Required]
        [Range(0, 50)]
        public int Wisdom { get; set; }
        [Required]
        [Range(0, 50)]
        public int Charisma { get; set; }

        [StringLength(200)]
        public string SavingThrows { get; set; }
        [StringLength(200)]
        public string Resistances { get; set; }
        [StringLength(200)]
        public string Immunities { get; set; }
        [StringLength(200)]
        public string Vulnerabilities { get; set; }
        [StringLength(200)]
        public string ConditionImmunities { get; set; }
        [StringLength(200)]
        public string Senses { get; set; }

        [StringLength(200)]
        public string Skills { get; set; }
        [StringLength(200)]
        public string Languages { get; set; }

        public string BasicAttacks { get; set; }
        public string NonSpellAbilities { get; set; }
        public string Passives { get; set; }
        public string LegendaryActions { get; set; }
        public string SpellCasting { get; set; }

        public string ExtraNotes { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public Statblock()
        {



        }


    }

}
