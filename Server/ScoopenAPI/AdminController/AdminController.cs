using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ScoopenAPIBLL;
using ScoopenAPIDAL.Admin;
using ScoopenAPIModals.Admin;
using ScoopenNotifications;
using ScoopenAPIBLL.Utility;
using ScoopenAPIModals.Notifications;

namespace ScoopenAPI.AdminController
{
    public class AdminController : ApiController
    {
        EmailNotifications emailNotification = new EmailNotifications();

        AdminControllerBLL adminBLL = new AdminControllerBLL(new AdminControllerDAL());
        [HttpPost]
        public HttpResponseMessage AddAgent(AddNewAgent addAgent)
        {
            try
            {
                if (addAgent != null)
                {
                    string otp = new LoginHelper().GenerateRandomOtp();

                    adminBLL.AddAgent(addAgent.FirstName, addAgent.LastName,addAgent.Gender,addAgent.DateOfBirth,addAgent.Date, addAgent.Email,addAgent.Mobile,addAgent.Address,addAgent.ZipCode);

                    OtpRequest request = new OtpRequest() { Mobile = addAgent.Mobile, Email = addAgent.Email, Otp = otp };

                    OtpResponse emailresponse = emailNotification.SendOTP(request);

                    return Request.CreateResponse(HttpStatusCode.OK, adminBLL);
                }

                return Request.CreateResponse(HttpStatusCode.BadRequest, "");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
            }

        }
    }
}
