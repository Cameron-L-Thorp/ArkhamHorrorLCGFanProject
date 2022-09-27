using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AHLCGApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AHLCGApp.EF.CRUD
{
    public class InvestigatorRepository : IInvestigatorService
    {
        public static void GetAllInvestigators()
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                List<Investigator> allInvestigators = context.Investigators.ToList();
            }
        }

        public static void AddOrUpdateInvestigator(Investigator inv)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                if (InvestigatorExists(inv.Id))
                {
                    Investigator investigator = context.Investigators.Where(i => i.Id == inv.Id).SingleOrDefault();
                    context.Update(investigator);
                }
                else
                {
                    Investigator newInvestigator = inv;
                    context.Add(newInvestigator);
                }
                context.SaveChanges();
                
            }
        }

        public static void DeleteInvestigator(Investigator inv)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                Investigator investigator = context.Investigators.Where(i => i.Id == inv.Id).SingleOrDefault();
                int id = investigator.Id;
                DeleteInvestigator(id);
            }
        }

        public static void DeleteInvestigator(int id)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                Investigator cyaInvestigator = context.Investigators.Where(i => i.Id == id).SingleOrDefault();
                context.Remove(cyaInvestigator);
                context.SaveChanges();
            }
        }

        public static bool InvestigatorExists(int id)
        {
            bool exists = false;
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                exists = context.Investigators.Any(i => i.Id == id);
            }
            return exists;
        }
    }
}
