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
        public string[] daysOfWeek { get; set; }

        //string[] daysOfWeek = {
        //                            "Monday",
        //                            "Tuesday",
        //                            "Wednesday",
        //                            "Thursday",
        //                            "Friday",
        //                            "Saturday",
        //                            "Sunday"
        //                            };

        public ActionResult Index()
        {
            MakeDaysPlural(daysOfWeek);

            return View();

        }

        //private void Main(Action<string[]> makeDaysPlural)
        //{
        //    string[] daysOfWeek = {
        //                            "Monday",
        //                            "Tuesday",
        //                            "Wednesday",
        //                            "Thursday",
        //                            "Friday",
        //                            "Saturday",
        //                            "Sunday"
        //                            };


        //    //foreach (string dayValue in daysOfWeek)
        //    //{
        //    //    System.Diagnostics.Debug.WriteLine(dayValue);
        //    //}
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //ViewBag.Message = dataReturn(1);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public static void Main(string[] 
        //    args)

        //{
        //    //string monday = "Monday";
        //    string[] daysOfWeek = {
        //                            "Monday",
        //                            "Tuesday",
        //                            "Wednesday",
        //                            "Thursday",
        //                            "Friday",
        //                            "Saturday",
        //                            "Sunday"
        //                            };
        //    //Console.WriteLine("Type in index of day to look up> ");
        //    //int day = int.Parse(Console.ReadLine());
        //    //Console.WriteLine(day);
        //    System.Diagnostics.Debug.WriteLine(daysOfWeek[2]);
        //    daysOfWeek[5] = "PartyDay"; //comment - replace value of element 5 with another value.
        //    foreach (string dayValue in daysOfWeek)
        //    {
        //        System.Diagnostics.Debug.WriteLine(dayValue);
        //    }
        //}

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

        public static void MakeDaysPlural(string[]
        daysOfWeek)

        {
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                daysOfWeek[i] = daysOfWeek[i] + "s";
            }

            foreach (string dayValue in daysOfWeek)
            {
                System.Diagnostics.Debug.WriteLine(dayValue);
            }
        }

        public static void MakeDaysPluralAlt(string[]
        daysOfWeek)

        {
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                string dayVal = daysOfWeek[i];
                daysOfWeek[i] = dayVal + "s";
            }
        }
    }
}