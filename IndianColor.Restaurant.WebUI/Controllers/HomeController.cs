using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndianColor.Restaurant.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About us";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact";

            return View();
        }

        public ActionResult Reservations()
        {
            ViewBag.Message = "Reservations";

            return View();
        }

        public ViewResult AdminPage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFoodMenuItem(string name, string category, string description, string price)
        {
            try
            {
                IndianColorEntities db = new IndianColorEntities();

                FoodMenuItem objNewMenuItem = new FoodMenuItem();
                objNewMenuItem.Name = name;
                objNewMenuItem.Category = category;
                objNewMenuItem.Description = description;
                objNewMenuItem.Price = decimal.Parse(price, CultureInfo.InvariantCulture);

                db.FoodMenuItems.Add(objNewMenuItem);
                db.SaveChanges();
                return Content("Food Item added!");

            }
            catch (Exception)
            {
                return Content("Food Item was not added!");
            }
        }
    }
}