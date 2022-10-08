using AHLCGApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.EF.CRUD
{
    public class TrecheryRepository : ITrecheryService
    {
        public void AddOrUpdateTrechery(Trechery trechery)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                if (TrecheryExists(trechery.Id))
                {

                }
                else
                {

                }
            }
        }

        public void DeleteTrechery(Trechery trechery)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {

            }
        }

        public void DeleteTrechery(int id)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {

            }
        }

        public void GetAllTrecheries()
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                List<Trechery> allTrecheries = context.Trecheries.ToList();
            }
        }

        public bool TrecheryExists(int id)
        {
            bool exists = false;
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                exists = context.Trecheries.Any(trech => trech.Id == id);
            }
            return exists;
        }
    }
}
