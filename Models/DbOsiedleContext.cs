using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DBPractise.Models
{
    class DbOsiedleContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=OSSJ\SQLEXPRESS;Initial Catalog=OsiedleEFCORE;Integrated Security=True;Pooling=False");
        }
    }
}
