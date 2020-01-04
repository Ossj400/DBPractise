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
        [Key, Column("Id osiedla")]
        public int Id_os { get; set; }

        [Required, Column("Nazwa osiedla")]
        public string Nazwa_os { get; set; }

        [Column("Liczba mieszkańców")]
        public int Lb_Mieszk { get; set; }

        [ForeignKey("Id zarządcy")]
        public Zarzadca Zarzadca { get; set; }

        [Column("Liczba bloków na wynajem")]
        public int Lb_blk_na_wynajem;   ////////// COMPUTED IN FlutentAPI
    }
}
