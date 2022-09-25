using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.Domain.Models
{
    public class Asset
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Subtype { get; set; }
        public int Cost { get; set; }
        public int Level { get; set; }
        public int ClassType { get; set; }
        public bool IsMultiClass { get; set; }
        public string TraitOne { get; set; }
        public string? TraitTwo { get; set; }
        public string? TraitThree { get; set; }
        public string AbilityOne { get; set; }
        public string? AbilityTwo { get; set; }
        public string? AbilityThree { get; set; }
        //public List<Trait> Traits { get; set; }
        //public List<Ability> Abilities { get; set; }
        public int Health { get; set; }
        public int Sanity { get; set; }
        public string Slot { get; set; }
        public int WillVal { get; set; }
        public int IntVal { get; set; }
        public int CombatVal { get; set; }
        public int AgilityVal { get; set; }
        public int CampaignId { get; set; }
    }
}
