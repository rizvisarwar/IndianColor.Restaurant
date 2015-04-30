using IndianColor.Restaurant.IndianColorEF;
using IndianColor.Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndianColor.Restaurant.Controllers
{
    [RequireHttps]
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
                using (var context = new IndianColorModel())
                {
                    FoodMenuItem objNewMenuItem = new FoodMenuItem();
                    objNewMenuItem.Name = name;
                    objNewMenuItem.Category = category;
                    objNewMenuItem.Description = description;
                    objNewMenuItem.Price = decimal.Parse(price, CultureInfo.InvariantCulture);

                    context.FoodMenuItems.Add(objNewMenuItem);
                    context.SaveChanges();
                }
                return Content("Food Item added!");

            }
            catch (Exception)
            {
                return Content("Food Item was not added!");
            }
        }

        [HttpPost]
        public ActionResult AddFoodMenuCategory(string category, string description)
        {
            try
            {
                using (var context = new IndianColorModel())
                {
                    Category objCategory = new Category();
                    objCategory.Name = category;
                    objCategory.Description = description;

                    context.Categories.Add(objCategory);
                    context.SaveChanges();
                }
                return Content("Category added!");

            }
            catch (Exception)
            {
                return Content("Category was not added!");
            }
        }

        public ViewResult EditFoodMenuItem()
        {
            List<string> data = new List<string>();

            using (var context = new IndianColorModel())
            {
                var menuQuery = from menu in context.FoodMenuItems
                                select menu;
                foreach (var item in menuQuery.ToList())
                {
                    data.Add(item.Name);
                }
            }

            return View(data);
        }

        [HttpPost]
        public ViewResult SetFoodMenuItemData(string name)
        {
            FoodMenuItemModels.FoodMenuItemModel data = new FoodMenuItemModels.FoodMenuItemModel();

            using (var context = new IndianColorModel())
            {
                var menuQuery = from menu in context.FoodMenuItems
                                where menu.Name == name
                                select menu;
                data.Name = menuQuery.First().Name;
                data.Description = menuQuery.First().Description;
                data.Category = menuQuery.First().Category;
                data.Price = menuQuery.First().Price;
            }

            return View(data);
        }

        [HttpPost]
        public ActionResult RemoveFoodMenuItem(string name, string category, string description, string price)
        {
            try
            {
                using (var context = new IndianColorModel())
                {
                    FoodMenuItem objRemoveMenuItem = new FoodMenuItem()
                    {
                        Name = name,
                        Category = category,
                        Description = description,
                        Price = decimal.Parse(price, CultureInfo.InvariantCulture)
                    };

                    //attach and delete object
                    context.Entry(objRemoveMenuItem).State = EntityState.Deleted;

                    //save changes
                    context.SaveChanges();
                }

                return Content("Food Item removed!");
            }
            catch (Exception)
            {
                return Content("Food Item was not removed!");
            }
        }

        [HttpPost]
        public ActionResult RemoveCategory(string category)
        {
            try
            {
                using (var context = new IndianColorModel())
                {
                    Category objRemoveCategory = new Category()
                    {
                        Name = category,
                    };

                    //attach and delete object
                    context.Entry(objRemoveCategory).State = EntityState.Deleted;

                    //save changes
                    context.SaveChanges();
                }

                return Content("Category removed!");
            }
            catch (Exception)
            {
                return Content("Category was not removed!");
            }
        }

        [HttpPost]
        public ActionResult UpdateFoodMenuItem(string name, string category, string description, string price)
        {
            try
            {
                using (var context = new IndianColorModel())
                {
                    var menuQuery = from menu in context.FoodMenuItems
                                    where menu.Name == name
                                    select menu;
                    FoodMenuItem objMenu = menuQuery.Single();

                    objMenu.Name = name;
                    objMenu.Category = category;
                    objMenu.Description = description;
                    objMenu.Price = decimal.Parse(price, CultureInfo.InvariantCulture);

                    context.SaveChanges();
                }

                return Content("Food Item updated!");
            }
            catch (Exception)
            {
                return Content("Food Item was not updated!");
            }
        }


        public ViewResult GetFoodMenuCategory(string dropDownId, string selectedItem)
        {
            FoodMenuCategory category = new FoodMenuCategory();
            category.DropDownId = dropDownId;
            category.Items = GetCategoryFromDB(); //fetch items from DB
            category.SelectedItem = selectedItem;
            return View("_MenuItemCategory", category);
        }

        private List<string> GetCategoryFromDB()
        {
            List<string> data = new List<string>();

            using (var context = new IndianColorModel())
            {
                var categoryQuery = from category in context.Categories
                                    select category;
                foreach (var item in categoryQuery.ToList())
                {
                    data.Add(item.Name.Trim());
                }
            }
            return data;
        }
    }
}