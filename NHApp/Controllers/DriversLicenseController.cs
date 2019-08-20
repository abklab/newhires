using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHApp.Controllers
{
    public class DriversLicenseController : Controller
    {
        // GET: DriversLicense
        public ActionResult Index()
        {
            return View();
        }

        // GET: DriversLicense/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DriversLicense/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DriversLicense/Create
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

        // GET: DriversLicense/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DriversLicense/Edit/5
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

        // GET: DriversLicense/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DriversLicense/Delete/5
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
