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
        [Key, Column("Id parkingu")]
        public int Id { get; set; }

        [Required, Column("Ilosc Miejsc Parkingowych")]
        public int Lb_Miejsc_Park { get; set; }

        [Required, Column("Ilosc Przypisanych Miejsc")]
        public int Lb_Przypis_Miejsc { get; set; }

        [Column("Ilosc Miejsc Dla Inwalidow")]
        public int Lb_Miejsc_Dla_Inw { get; set; }

        [Column("Ilosc_Miejsc_Nie_Przypisanych")]
        public int Lb_Miejsc_Nie_Przypis;   ////////// COMPUTED IN FlutentAPI

        public ICollection<BlokParking> BlokiParkingi { get; set; }

    }
}
