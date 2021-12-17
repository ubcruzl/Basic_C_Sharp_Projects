using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {

            if (ModelState.IsValid)
            {
                insuree.Quote = CalculeQuote(insuree);  //
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Quote", new { id = insuree.Id });  //Redirect to view Quote
                //@Html.ActionLink("Delete", "Delete", new { id = item.Id })
            }

            return View(insuree);
        }
        

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
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
        // GET: Insuree/Quote/5
        public ActionResult Quote(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        //Calculate a quote:
        public decimal CalculeQuote(Insuree insuree)
        {
            decimal quote;
            decimal baseQuote = 50m; // Start with a base of $50 / month.

            TimeSpan timespan = DateTime.Now - insuree.DateOfBirth;
            int age = Convert.ToInt32(timespan.Days) / 365;


            if (age <= 18)                   //If the user is 18 and under, add $100 to the monthly total.
            {
                quote = baseQuote + 100;
            }
            else if (age > 18 && age <= 25)  //If the user is between 19 and 25, add $50 to the monthly total.
            {
                quote = baseQuote + 50;
            }
            else
            {
                quote = baseQuote + 25;    //If the user is over 25, add $25 to the monthly total.
            }
            if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
            {
                quote += 25;
            }
            if (insuree.CarMake.ToLower() == "porsche")
            {
                quote += 25;           //If the car's Make is a Porsche, add $25 to the price.
                if (insuree.CarModel.ToLower() == "911 carrera")
                {
                    quote += 25;        //If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
                } // Add another $25 if Porsche is a 911 Carrera.
            }

            for (int i = 0; i < insuree.SpeedingTickets; i++)
            {
                quote += 10;            //Add $10 to the monthly total for every speeding ticket the user has.
            }
            if (insuree.DUI)
            {
                quote = quote + quote * 0.25m;    //If the user has ever had a DUI, add 25% to the total.
            }
            if (insuree.CoverageType)
            {
                quote = quote + quote * 0.5m;           //If it's full coverage, add 50% to the total.
            }

            //total = total / 100; // Ensure total only shows two decimal places.

            return quote;
        }
    }
}
