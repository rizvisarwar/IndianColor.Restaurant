using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndianColor.Restaurant.Models
{
    public class FoodMenuItemModels
    {
        public class FoodMenuItemModel
        {
            public int ItemID { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
        }
    }
}