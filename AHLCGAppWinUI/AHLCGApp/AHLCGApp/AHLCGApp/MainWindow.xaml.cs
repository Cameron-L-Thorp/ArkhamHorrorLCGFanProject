using AHLCGApp.Domain.Models;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Claims;
using Windows.Foundation;
using Windows.Foundation.Collections;
using AHLCGApp.EF.CRUD;
using AHLCGApp.Domain.Models;
using AHLCGApp.Domain;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace AHLCGApp
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public List<ClassTypes> ClassTypesList = Enum.GetValues(typeof(ClassTypes)).Cast<ClassTypes>().ToList();
        
        public MainWindow()
        {
            this.InitializeComponent();
        }

        public void AddInv_OnClick(object sender, RoutedEventArgs e)
        {
            string pClass = PClass.Text;
            string sClass = SClass.Text;
            Investigator inv = new Investigator();
            inv.Name = InvName.Text;
            inv.Subtitle = SubtitleName.Text;
            inv.ClassType = pClass;
            inv.SecondaryClassType = sClass;
            inv.MaxHealth = Convert.ToInt32(HealthValue.Text);
            inv.MaxSanity = Convert.ToInt32(SanityValue.Value);
            inv.Willpower = Convert.ToInt32(WillpowerValue.Text);
            inv.Intellect = Convert.ToInt32(IntellectValue.Value);
            inv.Combat = Convert.ToInt32(CombatValue.Value);
            inv.Agility = Convert.ToInt32(AgilityValue.Value);
            inv.TraitOne = FTrait.Text;
            inv.AbilityOne = FAbility.Text;
            inv.ElderSignAbility = ESAbility.Text;
            inv.DeckSize = 30;
            if (Flavor.Text != null)
            {
                inv.FlavorText = Flavor.Text;
            }
            if (STrait.Text != null)
            {
                inv.TraitTwo = STrait.Text;
            }
            if (TdTrait.Text != null)
            {
                inv.TraitThree = TdTrait.Text;
            }
            if (SAbility.Text != null)
            {
                inv.AbilityTwo = SAbility.Text;
            }
            if (TdAbility.Text != null)
            {
                inv.AbilityThree = TdAbility.Text;
            }
            InvestigatorRepository invRepo = new InvestigatorRepository();
            invRepo.AddOrUpdateInvestigator(inv);
            this.InitializeComponent();
        }

        private void DontAddInv_OnClick(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
