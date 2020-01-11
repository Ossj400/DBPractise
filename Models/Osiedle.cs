using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DBPractise.Models
{
    [Table("Osiedle")]
    public class Osiedle
    {    
        [Key, Column("Id_osiedla")]
        public int Id_os { get; set; }

        [ Required, Column("Nazwa_osiedla")]
        public string Nazwa_os { get; set; }

        [Column("Liczba_mieszkańców")]
        public int Lb_Mieszk { get; set; }

        [ForeignKey("Id_zarządcy")]
        public Zarzadca Zarzadca { get; set; }

        [Column("Liczba_bloków_na_wynajem")]
        public int Lb_blk_na_wynajem;   ////////// COMPUTED IN FlutentAPI
    }
}
