using MamidiPatientProfile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MamidiPatientProfile.Controllers
{
    public class RegisteredUserController : MamidiPatientProfileController
    {
        // GET: RegisteredUser
        public ActionResult RegisteredUser()
        {
            return View("RegisteredUser");
        }

        [HttpPost]
        public ActionResult RegisteredUser(RegisteredUserViewModel model)
        {
            return View("RegisteredUser");
        }
    }
}