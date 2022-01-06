using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Web_Final_asp_mvc_6.Models.Tables
{
    [Table("Kisi")]
    public class Kisi
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [StringLength(60),Required]
        public string name { get; set; }

        public string surname { get; set; }
        public int age { get; set; }

        public virtual ICollection<Adres> adresler { get; set; }
    }
}