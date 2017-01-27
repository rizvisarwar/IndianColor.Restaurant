using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndianColor.Restaurant.IndianColorEF
{
    public class FoodMenuItem
    {
        [Key]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public virtual Category Category1 { get; set; }
    }
}