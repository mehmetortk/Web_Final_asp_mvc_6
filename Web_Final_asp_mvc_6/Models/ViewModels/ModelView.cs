using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Final_asp_mvc_6.Models.Tables;

namespace Web_Final_asp_mvc_6.Models
{
    public class ModelView
    {
      public  List<Kisi> Kisiler { get; set; }
        public List<Adres> Adresler { get; set; }
    }
}