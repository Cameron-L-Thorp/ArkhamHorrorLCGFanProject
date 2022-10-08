using AHLCGApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.EF.CRUD
{
    public class LocationRepository : ILocationService
    {
        public void AddOrUpdateLocation(Location location)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                if (LocationExists(location.Id))
                {

                }
                else
                {

                }
            }
        }

        public void DeleteLocation(Location locaiton)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {

            }
        }

        public void DeleteLocation(int id)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {

            }
        }

        public void GetAllLocations()
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                List<Location> allLocations = context.Locations.ToList();
            }
        }

        public bool LocationExists(int id)
        {
            bool exists = false;
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                exists = context.Locations.Any(loc => loc.Id == id);
            }
            return exists;
        }
    }
}
