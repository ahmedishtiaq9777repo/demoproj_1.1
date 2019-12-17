using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using demoproj_1._1.Models;
using Microsoft.AspNetCore.Mvc;

namespace demoproj_1._1.Controllers
{
    public class HomeController : Controller
    {


         moazzandbContext db = new moazzandbContext();

        public JsonResult Index()
        {
            Employe emp = db.Employe.Where(a => a.Id == 1).SingleOrDefault();
            //return Json(emp);
            return Json(emp);
        }
        [HttpPost]
        public JsonResult login(Employe e)
        {
            try
            {
                Employe e2 = db.Employe.Where(a => a.Name == e.Name && a.Pass == e.Pass).SingleOrDefault();
                if (e2!=null)
                    return Json("success");
                    else
                    {
                    return Json("unautherized");
                    }
            }catch(NullReferenceException ex)
            {
                Console.Write(ex.Message);
                return Json("unautherized");
            }

        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
