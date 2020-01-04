using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DBPractise.Models
{
    [Table("Blok_Parking")]
    public class BlokParking
    {
        [ForeignKey("Blok Id")]
        public Blok IdBlok { get; set; }

        [ForeignKey("Parking Id")]
        public Parking IdParking { get; set; }


    }
}
