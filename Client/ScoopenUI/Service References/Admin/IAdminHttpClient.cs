using ScoopenAPIModals.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationAndLogin.Service_References.Admin
{
   public interface IAdminHttpClient
    {
        HttpResponseMessage AddAgent(AddNewAgent addAgent);
    }
}
