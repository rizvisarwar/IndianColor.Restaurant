using IndianColor.Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndianColor.Restaurant.Controllers
{
    public class FoodMenuItemController : Controller
    {
        public FoodMenuItemController()
        {
        }

        public ViewResult FoodList()
        {
            List<FoodMenuItemModels.FoodMenuItemModel> data = new List<FoodMenuItemModels.FoodMenuItemModel>();

            FoodMenuItemModels.FoodMenuItemModel obj = new FoodMenuItemModels.FoodMenuItemModel();
            obj.ItemID = 1;
            obj.Name = "Biriyani";
            obj.Price = 120;
            data.Add(obj);
            FoodMenuItemModels.FoodMenuItemModel obj1 = new FoodMenuItemModels.FoodMenuItemModel();

            obj1.ItemID = 2;
            obj1.Name = "Curry";
            obj1.Price = 100;
            data.Add(obj1);
            return View(data);
        }
    }
}