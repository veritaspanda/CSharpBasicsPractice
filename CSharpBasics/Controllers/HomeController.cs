using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSharpBasics.Models;

namespace CSharpBasics.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            //MakeDaysPlural(daysOfWeek);

            return View();

        }


        public ActionResult About()
        {
            ViewBag.Message = "Welcome to the CSharp Basics About Page!";
            //ViewBag.Message = dataReturn(1);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "If we wanted you to get in touch, this is where we would tell you how.";

            return View();
        }




        public static void Main(string[] 
            args)
        {
            //string[] daysOfWeek = {
            //                        "Monday",
            //                        "Tuesday",
            //                        "Wednesday",
            //                        "Thursday",
            //                        "Friday",
            //                        "Saturday",
            //                        "Sunday"
            //                        };


            //foreach (string dayValue in daysOfWeek)
            //{
            //    System.Diagnostics.Debug.WriteLine(dayValue);
            //}
        }

    }
}