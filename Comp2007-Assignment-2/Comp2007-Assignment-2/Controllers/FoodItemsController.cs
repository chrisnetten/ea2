﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Comp2007_Assignment_2.Models;

namespace Comp2007_Assignment_2.Controllers
{
    [AllowAnonymous]

    public class FoodItemsController : Controller
    {

        private MVCRestoContext db = new MVCRestoContext();

        // GET: FoodItems
        public async Task<ActionResult> Index()
        {
            return View(await db.FoodItems.ToListAsync());
        }

        // GET: FoodItems/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodItems foodItems = await db.FoodItems.FindAsync(id);
            if (foodItems == null)
            {
                return HttpNotFound();
            }
            return View(foodItems);
        }

        // GET: FoodItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FoodItemsID,name,description,price,thumbnail,image")] FoodItems foodItems)
        {
            if (ModelState.IsValid)
            {
                db.FoodItems.Add(foodItems);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(foodItems);
        }

        // GET: FoodItems/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodItems foodItems = await db.FoodItems.FindAsync(id);
            if (foodItems == null)
            {
                return HttpNotFound();
            }
            return View(foodItems);
        }

        // POST: FoodItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FoodItemsID,name,description,price,thumbnail,image")] FoodItems foodItems)
        {
            if (ModelState.IsValid)
            {
                db.Entry(foodItems).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(foodItems);
        }

        // GET: FoodItems/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FoodItems foodItems = await db.FoodItems.FindAsync(id);
            if (foodItems == null)
            {
                return HttpNotFound();
            }
            return View(foodItems);
        }

        // POST: FoodItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            FoodItems foodItems = await db.FoodItems.FindAsync(id);
            db.FoodItems.Remove(foodItems);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
