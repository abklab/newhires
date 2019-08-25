using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHApp.Controllers
{
    public class PreviousEmployerController : Controller
    {
        // GET: PreviousEmployer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddPreviousEmployer()
        {
            return View();
        }
    }
}