using AHLCGApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.EF.CRUD
{
    internal interface ITrecheryService
    {
        public void GetAllTrecheries();
        public void AddOrUpdateTrechery(Trechery trechery);
        public void DeleteTrechery(Trechery trechery);
        public void DeleteTrechery(int id);
        public bool TrecheryExists(int id);
    }
}
