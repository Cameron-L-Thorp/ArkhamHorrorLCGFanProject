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
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                if (EnemyExists(enemy.Id))
                {
                    Enemy en = context.Enemies.Where(i => i.Id == enemy.Id).SingleOrDefault();
                    context.Update(en);
                }
                else
                {
                    Enemy newEnemy = enemy;
                    context.Add(newEnemy);
                }
                context.SaveChanges();
            }
        }

        public void DeleteEnemy(Enemy enemy)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                Enemy en = context.Enemies.Where(i => i.Id == enemy.Id).SingleOrDefault();
                int id = en.Id;
                DeleteEnemy(id);
            }
        }

        public void DeleteEnemy(int id)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                Enemy cyaEnemy = context.Enemies.Where(i => i.Id == id).SingleOrDefault();
                context.Remove(cyaEnemy);
                context.SaveChanges();
            }
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
