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
            throw new NotImplementedException();
        }

        public void DeleteLocation(Location locaiton)
        {
            throw new NotImplementedException();
        }

        public void DeleteLocation(int id)
        {
            throw new NotImplementedException();
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
