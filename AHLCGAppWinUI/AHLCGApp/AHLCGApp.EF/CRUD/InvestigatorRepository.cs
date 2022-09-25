using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AHLCGApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AHLCGApp.EF.CRUD
{
    internal class InvestigatorRepository : IInvestigatorService
    {
        public void GetAllInvestigators()
        {
            using (AHLCGDBContext context = new AHLCGDBContext(DbContextOptions<Investigator>))
            {

            }
        }

        public void AddOrUpdateInvestigator(Investigator inv)
        {
            throw new NotImplementedException();
        }

        public void DeleteInvestigator(Investigator inv)
        {
            throw new NotImplementedException();
        }

        public void DeleteInvestigator(int id)
        {
            throw new NotImplementedException();
        }

        public void InvestigatorExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
