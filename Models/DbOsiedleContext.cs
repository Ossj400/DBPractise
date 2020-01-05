using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DBPractise.Models
{
    class DbOsiedleContext : DbContext
    {
        public DbSet<Zarzadca> Zarzadcy { get; set; }
        public DbSet<Osiedle> Osiedla { get; set; }
        public DbSet<Blok> Bloki { get; set; }
        public DbSet<Parking> Parkingi { get; set; }
        public DbSet<BlokParking> BlokiParkingi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=OSSJ\SQLEXPRESS;Initial Catalog=OsiedleEFCORE;Integrated Security=True;Pooling=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
       //     modelBuilder.Entity<BlokParking>().HasNoKey();
        }
    }
}
