using ScoopenAPIModals.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace RegistrationAndLogin.Service_References.Admin
{
    public class AdminHttpClient : BaseHttpClient, IAdminHttpClient
    {
        public HttpResponseMessage AddAgent(AddNewAgent addAgent)
        {
            using (ServiceClient)
            {
                var resource = string.Format("api/admin");

                var response = ServiceClient.PostAsJsonAsync(resource, addAgent).Result;

                if (response.IsSuccessStatusCode)
                    return response;

                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
    }
}
        