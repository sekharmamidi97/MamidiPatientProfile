using MamidiPatientProfile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamidiPatientProfile.Controllers
{
    public class NewUserController : MamidiPatientProfileController
    {
        // GET: NewUser
        public ActionResult NewUser()
        {
            return View("NewUser");
        }

        [HttpPost]
        public ActionResult NewUser(NewUserViewModel model)
        {
            return View("NewUser");
        }
    }
}