using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AHLCGApp.Domain.Models
{
    public class Investigator
    {
        [Key]
        public int Id { get; set; }
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Subtitle { get; set; }
        [Required]
        [StringLength(maximumLength: 10)]
        public string ClassType { get; set; }
        [Required]
        [StringLength(maximumLength: 10)]
        public string SecondaryClassType { get; set; }
        [AllowNull]
        public string FlavorText { get; set; }
        [Required]
        public int MaxHealth { get; set; }
        [Required]
        public int MaxSanity { get; set; }
        [Required]
        public int Willpower { get; set; }
        [Required]
        public int Intellect { get; set; }
        [Required]
        public int Combat { get; set; }
        [Required]
        public int Agility { get; set; }
        [StringLength(maximumLength: 25)]
        public string TraitOne { get; set; }
        [StringLength(maximumLength: 25)]
        public string? TraitTwo { get; set; }
        [StringLength(maximumLength: 25)]
        public string? TraitThree { get; set; }
        [StringLength(maximumLength: 500)]
        public string AbilityOne { get; set; }
        [StringLength(maximumLength: 500)]
        public string? AbilityTwo { get; set; }
        [StringLength(maximumLength: 500)]
        public string? AbilityThree { get; set; }
        //public List<Trait> Traits { get; set; }
        //public List<Ability> Abilities { get; set; }
        [StringLength(maximumLength: 500)]
        public string ElderSignAbility { get; set; }
        [Required]
        public int DeckSize { get; set; }

        public Investigator()
        {
            Name = "Boingo Boi";
            TraitOne = "Trait One";
            AbilityOne = "Ability One";
            ElderSignAbility = "Elder Sign Ability";
        }
    }

    //public class Trait
    //{
    //    public int Id { get; set; }
    //    public string TraitName { get; set; }
    //}
    //public class Ability
    //{
    //    public int Id { get; set; }
    //    public string AbilityName { get; set; }
    //}
}
