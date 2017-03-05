using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AislabieRhysAWA.Controllers
{
    public class ApplicantAdminController : Controller
    {
        // GET: ApplicantAdmin
        public ActionResult Index()
        {
            return View();
        }

        // GET: ApplicantAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApplicantAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplicantAdmin/Create
        [HttpPost]
        public ActionResult CreateNewApplication()
        {            
                return View();            
        }

        // GET: ApplicantAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApplicantAdmin/Edit/5
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

        // GET: ApplicantAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApplicantAdmin/Delete/5
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
