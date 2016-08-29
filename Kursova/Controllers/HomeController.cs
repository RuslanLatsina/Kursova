using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace Kursova.Controllers
{
    public class HomeController : Controller
    {
        STOEntities db = new STOEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Orders()
        {
            var orders = db.orders.Include(a => a.clients).Include(a => a.cars).Include(a => a.employee);
            return View(orders.ToList());
        }

        public ActionResult Emloyees()
        {
            var employyes = db.employee;
            return View(employyes.ToList());
        }

        public ActionResult Storage()
        {
            return View();
        }

        public ActionResult Cars()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}