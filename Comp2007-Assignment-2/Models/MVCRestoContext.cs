using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Comp2007_Assignment_2.Models
{
    public class MVCRestoContext : DbContext
    {
        public virtual DbSet<Food> Foods { get; set; }
        public virtual  DbSet<FoodType> FoodTypes { get; set; }
 
        public virtual DbSet<FoodItems> FoodItems { get; set; }



    }
}