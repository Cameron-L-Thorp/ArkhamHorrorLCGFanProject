using AHLCGApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.EF.CRUD
{
    internal interface IEnemyService
    {
        public void GetAllEnemies();
        public void AddOrUpdateEnemy(Enemy enemy);
        public void DeleteEnemy(Enemy enemy);
        public void DeleteEnemy(int id);
        public bool EnemyExists(int id);
    }
}
