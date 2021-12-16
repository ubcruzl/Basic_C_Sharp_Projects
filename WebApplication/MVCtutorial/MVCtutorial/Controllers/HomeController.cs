using MVCtutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCtutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\Ubaldo\Documents\GitHub\VisualStudio\Basic_C_Sharp_Projects\WebApplication\log.text",text);
            Random random = new Random(100);
            int num = random.Next();
            //ViewBag.RandomNumber = num;

            if (num > 20000)
            {
                return View("About");
            }
            */
            //return View();
            //return Content("Hello!");
            //return RedirectToAction("Contact");
            //return RedirectToAction("About");
            //return View();
            //
            //List<string> names = new List<string> { "Jesse", "Adam","Brett" };
            //return View(names);
            //
            //int number = 5;
            //return View(number);
            //
            User user = new User();
            user.Id = 1;
            user.FName = "Ubcruzl";
            user.LName = "Cz";
            user.Age = 12;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //
            throw new Exception("Invalid page");
            return View();
        }

        public ActionResult Contact(int id=0)   //Contact()
        {
            //ViewBag.Message = "Your contact page.";
            ViewBag.Message = id;
            return View();
        }
    }
}