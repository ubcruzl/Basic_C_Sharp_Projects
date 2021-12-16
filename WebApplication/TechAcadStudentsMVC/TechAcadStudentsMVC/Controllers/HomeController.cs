using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    //class name is called HomeController (same as the file name) and inherits from a class called Controller.
    //The Controller class provides our HomeController class with the method View()
    //and the pseudo-dictionary called ViewBag.
    public class HomeController : Controller
    {
        //that it accepts no parameters and its return type is a data type called ActionResult.
        //ActionResult is a class defined in the System.Web.Mvc library.
        public ActionResult Index()
        {
            //ActionResult as “rendered HTML,”
            //although it could be as varied as a “processed file” or “JSON-formatted data.”
            //an action was performed, which action produced a result.
            //That result (or ActionResult), in turn, is being returned by this method
                            //View() method is a very powerful method
            return View(); //simply looking at the method name it is called from (in our case Index),
                           //Controller Class name (in our case HomeController), it can find and process the appropriate .cshtml file.
                           //In this case it is the Index.cshtml file
        }

        public ActionResult About()
        {
            //ViewBag is an easy way to store values server side and make them available on the View. 
            ViewBag.Message = "Your application description page.";

            return View();  //View() method is a very powerful method
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - The Tech Academy.";

            return View();
            // https://localhost:44343/Home/Contact
            // Controler name -> Home
            //MEthod name -> Index
            //When a user types in this web address, a request goes to the server that is hosting the MVC website.
            //This request then gets routed to the HomeController. 
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;
            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "ub",
                LastName = "cr"
            };

            return View(dayTimeInstructor);
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor{Id=1,FirstName="Br",LastName="Br"},
                new Instructor{Id=2,FirstName="Cr",LastName="Cr"},
                new Instructor{Id=3,FirstName="Dr",LastName="Dr"},
            };

            return View(instructors);
        }


    }
    /*
     *The extension .cshtml stands for C Sharp HTML. It is C# code mixed in with HTML. 
     *That C# code is processed on the server and then sent to the browser as plain HTML.
     * */

}