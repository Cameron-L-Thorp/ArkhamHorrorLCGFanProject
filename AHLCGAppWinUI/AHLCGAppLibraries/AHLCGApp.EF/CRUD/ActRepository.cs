using AHLCGApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.EF.CRUD
{
    public class ActRepository : IActService
    {
        public bool ActExists(int id)
        {
            bool exists = false;
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                exists = context.Acts.Any(act => act.Id == id);
            }
            return exists;
        }

        public void AddOrUpdateAct(Act act)
        {
            throw new NotImplementedException();
        }

        public void DeleteAct(Act act)
        {
            throw new NotImplementedException();
        }

        public void DeleteAct(int id)
        {
            throw new NotImplementedException();
        }

        public void GetAllActs()
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                List<Act> allActs = context.Acts.ToList();
            }
        }
    }
}
