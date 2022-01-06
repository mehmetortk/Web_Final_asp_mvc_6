using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Final_asp_mvc_6.Models.Tables;
using Web_Final_asp_mvc_6.Models;
namespace Web_Final_asp_mvc_6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       
        public ActionResult Index()
        {
            ModelView model = new ModelView();
            DBContext db = new DBContext();
            model.Kisiler=db.kisiler.ToList();
            model.Adresler=db.adresler.ToList();
            return View(model);
        }
    }
}