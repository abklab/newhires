using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHApp.Controllers
{
    public class ApplicationFormController : Controller
    {
        // GET: ApplicationForm
        public ActionResult Index()
        {
            return View();
        }

        // GET: ApplicationForm/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApplicationForm/Create
        public ActionResult Create()
        {
            return View();
        }

       

        [HttpPost]
        public ActionResult AddDriversLicense()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddPreviousEmployer()
        {
            return PartialView("PreviousEmployer/AddPreviousEmployer");
        }
        // POST: ApplicationForm/Create
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

        // GET: ApplicationForm/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApplicationForm/Edit/5
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

        // GET: ApplicationForm/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApplicationForm/Delete/5
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
