using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comp2007_Assignment_2.Models
{
    public class Food
    {

        public Food()
        {

        }

        public Food( string name)
        {

            this.name = name;
        }


        public int FoodID { get; set; }
        public FoodType FoodType { get; set; }
        public string name {get; set;}


    }
}