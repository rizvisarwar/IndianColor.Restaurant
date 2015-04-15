using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndianColor.Restaurant.IndianColorEF
{
    public class Category
    {
        //public Category()
        //{
        //    this.FoodMenuItems = new HashSet<FoodMenuItem>();
        //}

        [Key]
        public string Name { get; set; }
        public string Description { get; set; }

        //public virtual ICollection<FoodMenuItem> FoodMenuItems { get; set; }
        //test to git push
    }
}