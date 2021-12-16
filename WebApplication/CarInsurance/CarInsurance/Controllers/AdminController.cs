using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{

    public class AdminController : Controller
    {
        // GET: Admin
        [HttpGet]
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                List<Insuree> quotes = db.Insurees.ToList(); // Creates a List of quotes/customer from the DB.

                var quoteVMs = new List<QuoteVM>(); // Instantiates a View Model List, DB info is mapped into it.
                // Maps pertinent info from the DB to the View Model.
                foreach (var quote in quotes)
                {
                    QuoteVM quoteVM = new QuoteVM();
                    quoteVM.FirstName = quote.FirstName;
                    quoteVM.LastName = quote.LastName;
                    quoteVM.EmailAddress = quote.EmailAddress;
                    quoteVM.Quote = quote.Quote;

                    quoteVMs.Add(quoteVM); // Add the quote into the View Model.
                }

                return View(quoteVMs);
            }
        }
        

    }
}