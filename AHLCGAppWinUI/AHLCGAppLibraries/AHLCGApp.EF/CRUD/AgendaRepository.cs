﻿using AHLCGApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.EF.CRUD
{
    public class AgendaRepository : IAgendaService
    {
        public void AddOrUpdateAgenda(Agenda agenda)
        {
            throw new NotImplementedException();
        }

        public bool AgendaExists(int id)
        {
            bool exists = false;
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                exists = context.Agendas.Any(agenda => agenda.Id == id);
            }
            return exists;
        }

        public void DeleteAgenda(Agenda agenda)
        {
            throw new NotImplementedException();
        }

        public void DeleteAgenda(int id)
        {
            throw new NotImplementedException();
        }

        public void GetAllAgendas()
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                List<Agenda> allAgendas = context.Agendas.ToList();
            }
        }
    }
}
