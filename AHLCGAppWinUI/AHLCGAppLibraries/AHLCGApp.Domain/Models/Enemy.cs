using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.Domain.Models
{
    public class Enemy
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        [Required]
        public int Health { get; set; }

        [Required]
        public int Fight { get; set; }

        [Required]
        public int Evade { get; set; }

        [StringLength(maximumLength: 25)]
        public string? TraitOne { get; set; }

        [StringLength(maximumLength: 25)]
        public string? TraitTwo { get; set; }

        [StringLength(maximumLength: 25)]
        public string? TraitThree { get; set; }

        [StringLength(maximumLength: 25)]
        public string? TraitFour { get; set; }

        [StringLength(maximumLength: 25)]
        public string? SpecialRuleOne { get; set; }

        [StringLength(maximumLength: 25)]
        public string? SpecialRuleTwo { get; set; }

        [StringLength(maximumLength: 25)]
        public string? SpecialRuleThree { get; set; }

        [StringLength(maximumLength: 500)]
        public string? FlavorText { get; set; }

        [Required]
        [StringLength(maximumLength: 500)]
        public string AbilityOne { get; set; }

        [Required]
        [StringLength(maximumLength: 500)]
        public string? AbilityTwo { get; set; }

        [Required]
        [StringLength(maximumLength: 500)]
        public string? AbilityThree { get; set; }

        [Required]
        public int Damage { get; set; }

        [Required]
        public int Horror { get; set; }

        public int? VictoryPts { get; set; }
    }
}
