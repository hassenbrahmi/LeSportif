using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
//using Microsoft.EntityFrameworkCore;

namespace LeSportif.Model
{
    class AppDbContext : DbContext
    {

        public DbSet<Sportifs> Sportifs { get; set; }
        public DbSet<NatureSport> natureSports { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Sportifs>(entity =>
        //    {
        //        entity.Property(e => e.date_Naissance).HasColumnType("date");
        //    });
        //}
        public AppDbContext() : base("SuivieSportifs")
        {
        }
        //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    {
        //        string connectionString = AppConfig.GetConnectionString("Suiviesportifs");
        //        optionsBuilder.UseSqlServer(connectionString);
        //    }
        //}
    }
}
