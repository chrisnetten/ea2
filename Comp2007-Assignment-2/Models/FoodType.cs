using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Comp2007_Assignment_2.Models
{
    public class FoodType
    {

        public FoodType()
        {

        }

        public FoodType(string name)
        {

            this.name = name;

        }

        public int FoodTypeID { get; set; }
        public string name { get; set; }


    }
}