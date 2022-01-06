using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web_Final_asp_mvc_6.Models.Tables
{
    [Table("Adres")]
    public class Adres
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(160), Required]
        public string AdresBilgisi { get; set; }

        public string Sehir { get; set; }
       

        public virtual ICollection<Kisi> kisiler { get; set; }
    }
}