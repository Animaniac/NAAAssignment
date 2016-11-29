using NAA.Services.IService;
using NAA.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AislabieRhysAWA.Controllers
{
    public class ApplicantController : Controller
    {
        private IApplicantService _ApplicantService;
        public ApplicantController()
        {
            _ApplicantService = new ApplicantService();
        }
        // GET: Applicant
        public ActionResult Details(int id)
        {
            return View(_ApplicantService.GetApplicantDetails(id));
        }
                // GET: Applicant/Details/5
        public ActionResult Profiles()
        {

            return View(_ApplicantService.GetApplicants());
        }

        // GET: Applicant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Applicant/Create
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

        // GET: Applicant/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Applicant/Edit/5
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

        // GET: Applicant/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Applicant/Delete/5
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
