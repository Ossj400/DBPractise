 using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DBPractise.Models
{
    [Table("Parking")]
    public class Parking
    {
        [Key, Column("Id_parkingu")]
        public int Id { get; set; }

        [Required, Column("Ilosc_Miejsc_Parkingowych")]
        public int Lb_Miejsc_Park { get; set; }

        [Required, Column("Ilosc_Przypisanych_Miejsc")]
        public int Lb_Przypis_Miejsc { get; set; }

        [Column("Ilosc_Miejsc_Dla_Inwalidow")]
        public int Lb_Miejsc_Dla_Inw { get; set; }
        public int Lb_Miejsc_Nie_Przypis {get; private set;}   ////////// COMPUTED IN FlutentAPI

        public ICollection<BlokParking> BlokiParkingi { get; set; }

    }
}
