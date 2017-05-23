using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;
using StepBarCode.Models;

namespace StepBarCode.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.TestD = "Index";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.TestD = "Contact";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.TestD = "About";
            return View();
        }

        public JsonResult GetCompany()
        {
            using (STEPBARCODEContext db = new STEPBARCODEContext())
            {
                var movies = new List<object>();

                movies.Add(new { Title = "Ghostbusters", Genre = "Comedy", Year = 1984 });
                movies.Add(new { Title = "Gone with Wind", Genre = "Drama", Year = 1939 });
                movies.Add(new { Title = "Star Wars", Genre = "Science Fiction", Year = 1977 });
                
                return Json(movies, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
