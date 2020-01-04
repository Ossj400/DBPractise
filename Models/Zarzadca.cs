using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace DBPractise.Models
{
    [Table("Zarządca")]
    public class Zarzadca
    {
        [Key, Column("Id zarządcy")]
        public int IdZarzadcy { get; set; }

        [Required, Column("Imię")]
        public string Imie { get; set; }

        [Required, Column("Nazwisko")]
        public string Nazwisko { get; set; }

        [ForeignKey("Id osiedla")]
        public Osiedle Osiedle { get; set; }

        [Required, Column("Zarobki")]
        public decimal Zarobki { get; set; }

    }
}
