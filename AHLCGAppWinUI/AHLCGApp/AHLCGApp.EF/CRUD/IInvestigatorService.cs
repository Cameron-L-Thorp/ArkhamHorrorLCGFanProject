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
        public void GetAllInvestigators();
        public void AddOrUpdateInvestigator(Investigator inv);
        public void DeleteInvestigator(Investigator inv);
        public void DeleteInvestigator(int id);
        public void InvestigatorExists(int id);
    }
}
