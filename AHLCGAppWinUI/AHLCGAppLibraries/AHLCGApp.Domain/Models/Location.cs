using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.Domain.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 500)]
        public string UnRevealedText { get; set; }

        [Required]
        [StringLength(maximumLength: 500)]
        public string RevealedText { get; set; }

        [StringLength(maximumLength: 500)]
        public string? AbilityOne { get; set; }

        [StringLength(maximumLength: 500)]
        public string? AbilityTwo { get; set; }

        [StringLength(maximumLength: 10)]
        public string ConnectionOne { get; set; }

        [AllowNull]
        [StringLength(maximumLength: 10)]
        public string ConnectionTwo { get; set; }

        [AllowNull]
        [StringLength(maximumLength: 10)]
        public string ConnectionThree { get; set; }

        [AllowNull]
        [StringLength(maximumLength: 10)]
        public string ConnectionFour { get; set; }

        [AllowNull]
        [StringLength(maximumLength: 10)]
        public string ConnectionFive { get; set; }

        [Required]
        public int ShroudValue { get; set; }

        [Required]
        public int ClueValue { get; set; }

        public int? VictoryPoints { get; set; }
    }
}
