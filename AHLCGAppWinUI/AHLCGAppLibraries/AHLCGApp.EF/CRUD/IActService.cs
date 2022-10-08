using AHLCGApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.EF.CRUD
{
    public interface IActService
    {
        public void GetAllActs();
        public void AddOrUpdateAct(Act act);
        public void DeleteAct(Act act);
        public void DeleteAct(int id);
        public bool ActExists(int id);
    }
}
