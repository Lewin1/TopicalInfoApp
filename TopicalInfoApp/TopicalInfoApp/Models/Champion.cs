using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TopicalInfoApp.Models
{
    public class Champion
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "A Name is required.")]
        [Display(Name = "Champion Name")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "A Class is required.")]
        [Display(Name = "Champion Class")]
        [StringLength(25)]
        public string Class { get; set; }

        [Required(ErrorMessage = "A Base health is required.")]
        [Display(Name = "Champion Base Health")]
        [Range(1, 800, ErrorMessage = "Out of range. Must be between 1 and 800.")]
        public double BaseHealth { get; set; }

        [Range(1, 800, ErrorMessage = "Out of range. Must be between 1 and 800.")]
        public double BaseMana { get; set; }

        [Range(1, 50, ErrorMessage = "Out of range. Must be between 1 and 50.")]
        public int BaseArmor { get; set; }

        [Range(1, 50, ErrorMessage = "Out of range. Must be between 1 and 50.")]
        public int BaseMagicResist { get; set; }

        [Range(1, 100, ErrorMessage = "Out of range. Must be between 1 and 100.")]
        public int BaseAttackDamage { get; set; }

        [Display(Name = "Profile Pic")]
        public string ImagePath { get; set; }
    }
}