using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Web_Final_asp_mvc_6.Models.Tables;

namespace Web_Final_asp_mvc_6.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Kisi> kisiler { get; set; }
        public DbSet<Adres> adresler { get; set; }




    }
}