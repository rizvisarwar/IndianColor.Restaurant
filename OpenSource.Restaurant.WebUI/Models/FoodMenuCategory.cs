using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace IndianColor.Restaurant.Models
{
    public class FoodMenuCategory
    {
        public string DropDownId { get; set; }
        public List<string> Items { get; set; }
        public string SelectedItem { get; set; }
    }
}