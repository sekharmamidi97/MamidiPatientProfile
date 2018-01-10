using MamidiPatientProfile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamidiPatientProfile.Controllers
{
    public class PatientProfileController : Controller
    {
        // GET: PatientProfile
        public ActionResult PatientProfile()
        {
            return View("PatientProfile");
        }

        [HttpPost]
        public ActionResult PatientProfile(PatientProfileViewModel model)
        {
            return View("PatientProfile");
        }
    }
}