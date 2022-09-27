using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AHLCGApp.Domain.Models;

namespace AHLCGApp.EF.CRUD
{
    public interface IInvestigatorService
    {
        public static void GetAllInvestigators()
        {

        }
        public static void AddOrUpdateInvestigator(Investigator inv)
        {

        }

        public static void DeleteInvestigator(Investigator inv)
        {

        }

        public static void DeleteInvestigator(int id)
        {

        }

        public static bool InvestigatorExists(int id)
        {
            return false;
        }
    }
}
