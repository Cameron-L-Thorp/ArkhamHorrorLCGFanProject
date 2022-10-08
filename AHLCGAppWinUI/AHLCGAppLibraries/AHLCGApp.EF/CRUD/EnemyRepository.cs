using AHLCGApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.EF.CRUD
{
    public class EnemyRepository : IEnemyService
    {
        public void AddOrUpdateEnemy(Enemy enemy)
        {
            throw new NotImplementedException();
        }

        public void DeleteEnemy(Enemy enemy)
        {
            throw new NotImplementedException();
        }

        public void DeleteEnemy(int id)
        {
            throw new NotImplementedException();
        }

        public bool EnemyExists(int id)
        {
            bool exists = false;
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                exists = context.Enemies.Any(enemy => enemy.Id == id);
            }
            return exists;
        }

        public void GetAllEnemies()
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                List<Enemy> allEnemies = context.Enemies.ToList();
            }
        }
    }
}
