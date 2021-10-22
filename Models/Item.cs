using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWebsite.Models
{

    public class ApplicationUser : IdentityUser
    {
        public List<Item> Items { get; set; }
        public List<Statblock> Statblocks { get; set; }

    }
    public class Item
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Power { get; set; }
        [Range(0, 100)]
        public int Charges { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public Item(){

        }

    }
}
