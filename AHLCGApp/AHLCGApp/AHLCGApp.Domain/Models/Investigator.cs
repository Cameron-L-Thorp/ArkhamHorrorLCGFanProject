using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AHLCGApp.Domain.Models
{
    public class Investigator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassType { get; set; }
        public int SecondaryClassType { get; set; }
        public string FlavorText { get; set; }
        public int MaxHealth { get; set; }
        public int MaxSanity { get; set; }
        public int Willpower { get; set; }
        public int Intellect { get; set; }
        public int Combat { get; set; }
        public int Agility { get; set; }
        public string TraitOne { get; set; }
        public string? TraitTwo { get; set; }
        public string? TraitThree { get; set; }
        public string AbilityOne { get; set; }
        public string? AbilityTwo { get; set; }
        public string? AbilityThree { get; set; }
        //public List<Trait> Traits { get; set; }
        //public List<Ability> Abilities { get; set; }
        public string ElderSignAbility { get; set; }
        public int DeckSize { get; set; }
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
