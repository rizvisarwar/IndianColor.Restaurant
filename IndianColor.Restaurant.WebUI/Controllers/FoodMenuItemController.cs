﻿using IndianColor.Restaurant.IndianColorEF;
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

            using (var context = new IndianColorModel())
            {
                var menuQuery = from menu in context.FoodMenuItems
                                select menu;
                foreach (var item in menuQuery.ToList())
                {
                    FoodMenuItemModels.FoodMenuItemModel obj = new FoodMenuItemModels.FoodMenuItemModel();
                    obj.Name = item.Name;
                    obj.Price = item.Price;
                    obj.Description = item.Description;
                    obj.Category = item.Category;
                    data.Add(obj);
                }
            }
            
            return View(data);            
        }
    }
}