using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegistrationAndLogin.Api;
using ScoopenAPIModals.Admin;

namespace RegistrationAndLogin.AdminController
{
    public class AdminController : Controller
    {
        // GET: Admin
        AdminApiController adminApiController = new AdminApiController();

        [HttpGet]
        public ActionResult AddAgent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAgent( AddNewAgent addAgent)
        {
            var response = adminApiController.AddAgent(addAgent);

            if (response != null && response.IsSuccessStatusCode)
            {
                Session["RegisteredUserDetails"] = addAgent;
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("FirstName", "Error in registration");
            return View();


        }

    }
}