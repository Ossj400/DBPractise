using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DBPractise.Models
{
    [Table("Parking")]
    class Parking
    {
        [Key, Column("Id parkingu")]
        public int Id { get; set; }

        [Required, Column("Ilosc Miejsc Parkingowych")]
        public int Ilosc_Miejsc_Parkingowych { get; set; }

        [Required, Column("Ilosc Przypisanych Miejsc")]
        public int Ilosc_Przypisanych_Miejsc { get; set; }

        [Column("Ilosc Miejsc Dla Inwalidow")]
        public int Ilosc_Miejsc_Dla_Inwalidow { get; set; }

        [Column("Ilosc_Miejsc_Nie_Przypisanych")]
        public int Ilosc_Miejsc_Nie_Przypisanych;   ////////// COMPUTED IN FlutentAPI

    }
}
