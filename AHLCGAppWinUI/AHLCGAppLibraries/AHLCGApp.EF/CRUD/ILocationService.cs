using AHLCGApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.EF.CRUD
{
    internal interface ILocationService
    {
        public void GetAllLocations();
        public void AddOrUpdateLocation(Location location);
        public void DeleteLocation(Location locaiton);
        public void DeleteLocation(int id);
        public bool LocationExists(int id);
    }
}
