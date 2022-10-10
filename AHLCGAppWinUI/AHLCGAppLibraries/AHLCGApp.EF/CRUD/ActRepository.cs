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
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                if (ActExists(act.Id))
                {
                    Act a = context.Acts.Where(i => i.Id == act.Id).SingleOrDefault();
                    context.Update(act);
                }
                else
                {
                    Act newAct = act;
                    context.Add(newAct);
                }
                context.SaveChanges();
            }
        }

        public void DeleteAct(Act act)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                Act delAct = context.Acts.Where(i => i.Id == act.Id).SingleOrDefault();
                int id = delAct.Id;
                DeleteAct(id);
            }
        }

        public void DeleteAct(int id)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                Act cyaAct = context.Acts.Where(i => i.Id == id).SingleOrDefault();
                context.Remove(cyaAct);
                context.SaveChanges();
            }
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
