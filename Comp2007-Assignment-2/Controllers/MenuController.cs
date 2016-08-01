using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comp2007_Assignment_2.Models;

namespace Comp2007_Assignment_2.Controllers
{
    [Authorize]

    public class MenuController : Controller
    {
        // GET: Menu

        [AllowAnonymous]

        public ActionResult Index()
        {
            List<FoodType> foodtype = new List<FoodType>
            {
                 new FoodType("Appetizers"),
                 new FoodType("Beverages"),
                 new FoodType("Pastas"),
                  new FoodType("Burgers"),
                   new FoodType("Pizza"),
                    new FoodType("Desserts"),
                     new FoodType("Our Specials")
            };

            return View(foodtype);
        }
        //
        // GET: /Store/Browse?genre=Disco
        [AllowAnonymous]
        public ActionResult Browse(string genre)
        {
            FoodType FoodTypeModel = new FoodType(genre);

            return View(FoodTypeModel);
        }
        //
        // GET: /Store/Details/5
        [AllowAnonymous]
        public ActionResult Details(int id = 1)
        {
            Food food = new Food("Food " + id);

            return View(food);
        }
    }
}