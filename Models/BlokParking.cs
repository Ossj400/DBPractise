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
        [Key,Column("Id")]
        public int Id { get; set; }
        
        public int IdBlok { get; set; }

        public int IdParking { get; set; }

        [ForeignKey("IdParking")]
        public virtual Parking Parking { get; set; }

        [ForeignKey("IdBlok")]
        public virtual Blok Blok { get; set; }
    }
}
