using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using MVCZoolandia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCZoolandia.Models
{
    public class ZoolandiaContext : DbContext
    {

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Habitat> Habitat { get; set; }
        public DbSet<Animal> Animal { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>()
                .ToTable("Employee")
                .HasKey(c => c.EmployeeId);

            modelBuilder.Entity<Animal>()
                .ToTable("Animal")
                .HasKey(c => c.AnimalId);

            modelBuilder.Entity<Habitat>()
                .ToTable("Habitat")
                .HasKey(c => c.HabitatId);
        }
    }

    //public class ZoolandiaContextOptions : DbContextOptions
    //{



    //}
}
