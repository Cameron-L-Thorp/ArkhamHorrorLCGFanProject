using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.Domain.Models
{
    public class Agenda
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        [AllowNull]
        public string FlavorText { get; set; }

        [Required, StringLength(maximumLength: 1000)]
        public string FlipText { get; set; }

        [StringLength(maximumLength: 500)]
        public string AbilityOne { get; set; }

        [StringLength(maximumLength: 500)]
        public string AbilityTwo { get; set; }

        [Required]
        public int DoomThreshold { get; set; }
    }
}
