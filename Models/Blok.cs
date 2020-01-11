using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DBPractise.Models
{
    [Table("Blok")]
    public class Blok
    {
        [Key, Column("Id_bloku")]
        public int IdBlk { get; set; }

        [Required, Column("Numer_bloku")]
        public int NrBloku { get; set; }

        [Required, Column("Ulica")]
        public string Ulica { get; set; }

        [ForeignKey("Id_osiedla")]
        public Osiedle Osiedle { get; set; }

        [Column("Zarobki")]
        public decimal Zarobki { get; set; }

        public ICollection<BlokParking> BlokiParkingi { get; set; }

    }
}
