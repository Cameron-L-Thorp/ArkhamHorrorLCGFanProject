using AHLCGApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.EF.CRUD
{
    internal interface IAgendaService
    {
        public void GetAllAgendas();
        public void AddOrUpdateAgenda(Agenda agenda);
        public void DeleteAgenda(Agenda agenda);
        public void DeleteAgenda(int id);
        public bool AgendaExists(int id);
    }
}
