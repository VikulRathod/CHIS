using RegistrationAndLogin.Service_References.Account;
using RegistrationAndLogin.Service_References.Admin;
using ScoopenAPIModals.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace RegistrationAndLogin.Api
{
    public class AdminApiController
    {
        [HttpPost]
        [Route("api/admin")]
        public HttpResponseMessage AddAgent(AddNewAgent addAgent)
        {
            var adminHttpClient = new AdminHttpClient();

            var response = adminHttpClient.AddAgent(addAgent);
            if (response.IsSuccessStatusCode)
            {
                return response;
            }
            return null;
        }
    }
}