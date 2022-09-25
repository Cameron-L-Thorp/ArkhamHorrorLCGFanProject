using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AHLCGApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AHLCGApp.EF
{
    public class AHLCGDBContext : DbContext
    {
        public AHLCGDBContext(DbContextOptions<AHLCGDBContext> options) : base(options)
        {

        }
        public virtual DbSet<Investigator> Investigators { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=CAMERONDESKTOP;Database=ArkhamHorrorDB;trusted_connection=true;");
        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AHLCGDBContext>
    {
        public AHLCGDBContext CreateDbContext(string[] args)
        {
            string connectionString = @"Server=CAMERONDESKTOP;Database=ArkhamHorrorDB;trusted_connection=true;";
            var builder = new DbContextOptionsBuilder<AHLCGDBContext>();
            builder.UseSqlServer(connectionString);
            return new AHLCGDBContext(builder.Options);
        } 
    }
}
