using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Diagnostics;
using CSharpBasics.Models;

namespace CSharpBasics.Controllers
{
    public class ProcessController : Controller
    {

        DataModel newProcess = new DataModel();
        // GET: Process
        public ViewResult List()
        {
            var processList = from p in Process.GetProcesses()
                              select p;

            ViewData.Model = processList.ToList();

            return View();
        }

        // GET: Process/Details/5
        public ActionResult Details(int id)
        {
            var process = (from p in Process.GetProcesses()
                           where p.Id == id
                           select p).ToList();
            var processVal = Process.GetProcessById(id).ProcessName.ToString();
            var processID = Process.GetProcessById(id).Id.ToString();
            var processRespond = Process.GetProcessById(id).Responding.ToString();
            var processSessionID = Process.GetProcessById(id).SessionId.ToString();
            //var processStart =  Process.GetProcessById(id).StartTime;
            //var processThreads = Process.GetProcessById(id).Threads.ToString();
            var workingSet = Process.GetProcessById(id).WorkingSet64.ToString();

            newProcess.ProcessName = processVal.ToString();
            newProcess.ProcessID = processID.ToString();
            newProcess.ProcessResponding = processRespond.ToString();
            newProcess.ProcessSessionID = processSessionID.ToString();
            //newProcess.ProcessStartTime = processStart;
            //newProcess.ProcessTreads = processThreads.ToString();
            newProcess.WorkingSet = workingSet.ToString();
            ViewBag.ProcessName = "Process Name: " + newProcess.ProcessName;
            ViewBag.ProcessID = "Process ID: " + newProcess.ProcessID;
            ViewBag.ProcessResponding = "Process Responding: " + newProcess.ProcessResponding;
            ViewBag.ProcessSessionID = "Process Session ID: " + newProcess.ProcessSessionID;
            //ViewBag.ProcessStart = "Process Start: " + newProcess.ProcessStartTime.ToString();
            //ViewBag.ProcessThreads = "Process Threads: " + newProcess.ProcessTreads;
            ViewBag.ProcessWorkingSet = "Process Working Set: " + newProcess.WorkingSet.ToString();


            return View(process);
        }

        // GET: Process/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Process/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Process/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Process/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Process/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Process/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
