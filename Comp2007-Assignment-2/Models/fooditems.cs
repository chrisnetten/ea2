using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comp2007_Assignment_2.Models
{
    public class FoodItems
    {
        
        public int FoodItemsID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string thumbnail { get; set; }
        public string image { get; set; }
    }
}