using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.Domain.Models
{
    public class Trechery
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        [StringLength(maximumLength: 25)]
        public string? TraitOne { get; set; }

        [StringLength(maximumLength: 25)]
        public string? TraitTwo { get; set; }

        [StringLength(maximumLength: 25)]
        public string? TraitThree { get; set; }

        [StringLength(maximumLength: 25)]
        public string? TraitFour { get; set; }

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
    }
}
