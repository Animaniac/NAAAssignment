using NAA.Data;
using NAA.Services.IService;
using NAA.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AislabieRhysAWA.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private IApplicantService _applicantService;
        public AdminController()
        {
            _applicantService = new ApplicantService();
        }
        [Authorize()]
        public ActionResult EditProfile(int id)
        {
            return View(_applicantService.GetApplicantDetails(id));
        }
        
        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Admin/Create
        [HttpPost]
        public ActionResult EditProfile(Profile profile)
        {
            try
            {
                _applicantService.EditProfile(profile);
                return RedirectToAction("Details",
                    new {id = profile.ApplicantId, Controller = "Applicant" });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateProfile(Profile NewProfile)
            {
            try
            {
                _applicantService.CreateProfile(NewProfile);
                return RedirectToAction("Profiles",
                    new {id = NewProfile.ApplicantId, Controller = "Applicant" });
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
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


        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_applicantService.GetApplicantDetails(id));
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(Profile CurrentProfile, int id)
        {
            Profile _profile = _applicantService.GetApplicantDetails(id);
                _applicantService.DeleteProfile(_profile);
                return RedirectToAction("Profiles",
                    new { Controller = "Applicant" });
        }        
    }
}
