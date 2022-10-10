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
                    Location loc = context.Locations.Where(i => i.Id == location.Id).SingleOrDefault();
                    context.Update(loc);
                }
                else
                {
                    Location newLocation = location;
                    context.Add(newLocation);
                }
                context.SaveChanges();
            }
        }

        public void DeleteLocation(Location location)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                Location loc = context.Locations.Where(i => i.Id == location.Id).SingleOrDefault();
                int id = loc.Id;
                DeleteLocation(id);
            }
        }

        public void DeleteLocation(int id)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                Location cyaLoc = context.Locations.Where(i => i.Id == id).SingleOrDefault();
                context.Remove(cyaLoc);
                context.SaveChanges();
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
