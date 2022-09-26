using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.Domain.Models
{
    public class Asset
    {
        [Key] public int Id { get; set; }
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
        [StringLength(maximumLength: 50)]
        public string Subtype { get; set; }
        public int Cost { get; set; }
        public int Level { get; set; }
        public int ClassType { get; set; }
        public bool IsMultiClass { get; set; }
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
        [AllowNull]
        public int Health { get; set; }
        [AllowNull]
        public int Sanity { get; set; }
        [AllowNull]
        public string Slot { get; set; }
        [AllowNull]
        public int WillVal { get; set; }
        [AllowNull]
        public int IntVal { get; set; }
        [AllowNull]
        public int CombatVal { get; set; }
        [AllowNull]
        public int AgilityVal { get; set; }
        [AllowNull]
        public int CampaignId { get; set; }

        public Asset()
        {
            Name = "John Doe";
            Subtype = "Weakness";
            TraitOne = "Trait One";
            AbilityOne = "Ability One";
        }
    }
}
