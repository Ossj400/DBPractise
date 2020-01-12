using System;
using System.Collections.Generic;
using DBPractise.Addons;
using DBPractise.Models;
using Microsoft.EntityFrameworkCore;

namespace DBPractise
{
    class Program
    {
        static void Main(string[] args)
        {
           // DbOsiedleContext db = new DbOsiedleContext();

           //// Procedura składowana

           // int IdZarz = 50;
           // int LbMieszk = 1000;
           // string Nazwa = "NORTH";
           // int Ile = 1;
           // db.Database.ExecuteSqlInterpolated($"EXEC dbo.DodajOsiedle {IdZarz},{LbMieszk},{Nazwa},{Ile}");
           // db.SaveChanges();
           // // Funkcja tabelaryczna 

           // int zarobki = 14000;
           // Console.WriteLine('\n' + $"Zarobki większe niż {zarobki} Posiadają:");

           // foreach (var z in db.Zarzadcy.FromSqlInterpolated($"SELECT * FROM dbo.ZarobkiWiekszeNiz({zarobki})").Include(z => z.Osiedle)) 
           //     Console.WriteLine($"{z.Nazwisko} {z.Imie}   zarabia : {z.Zarobki}");        
        }
    }
}
