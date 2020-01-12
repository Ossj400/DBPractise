using System;
using System.Collections.Generic;
using System.Text;
using DBPractise.Addons;
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
        RecordGenerator recordGenerator = new RecordGenerator();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=OSSJ\SQLEXPRESS;Initial Catalog=OsiedleEFCORE;Integrated Security=True;Pooling=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for (int i = 1; i < 100; i++)
            { 
                var os = new Osiedle()
                {
                    Id_os = i
                };

                var zarz = new Zarzadca()
                { 
                    IdZarzadcy = i 
                };

                var Blk = new Blok()
                {
                    IdBlk = i
                };


                var Park = new Parking()
                {
                    Id=i
                };

                var BP = new BlokParking()
                {
                    Id = i,
                    IdBlok = Blk.IdBlk,
                    IdParking = Park.Id
                };


                recordGenerator.Init();
                modelBuilder.Entity<Zarzadca>()
                     .HasData(
                     new Zarzadca
                     {
                         IdZarzadcy = i,
                         Imie = recordGenerator.imie,
                         Nazwisko = recordGenerator.nazwisko,
                         Zarobki = recordGenerator.zarobkiZarz,
                     });
                                modelBuilder.Entity<Parking>()
                     .HasData(
                     new Parking
                     {
                         Id = i,
                         Lb_Miejsc_Park = recordGenerator.lbMPark,
                         Lb_Przypis_Miejsc = recordGenerator.lbMPrzyp,
                         Lb_Miejsc_Dla_Inw = recordGenerator.lbMInwalidow,
                     });
                                modelBuilder.Entity<Osiedle>()
                     .HasData(
                     new Osiedle
                     {

                         Id_os = i,
                         Nazwa_os = recordGenerator.osiedle,
                         Lb_Mieszk = recordGenerator.lbMieszkOs,
                         Lb_blk_na_wynajem = recordGenerator.lbBlkNaWyn,
                     });

                               modelBuilder.Entity<BlokParking>()
                     .HasData(
                     new BlokParking
                     {
                         Id = i,
                         IdBlok = Blk.IdBlk,
                         IdParking = Park.Id            
                     });

                               modelBuilder.Entity<Blok>()
                     .HasData(
                     new Blok
                     {
                         IdBlk = i,
                         NrBloku = i,
                         Ulica = recordGenerator.ulica,
                         Zarobki = recordGenerator.zarobkiBlk,
                     });
                }           

            modelBuilder.Entity<Parking>()
                .Property(p => p.Lb_Miejsc_Nie_Przypis)
                .HasComputedColumnSql("[Ilosc_Miejsc_Parkingowych]-[Ilosc_Przypisanych_Miejsc]");
        }
    }
}
