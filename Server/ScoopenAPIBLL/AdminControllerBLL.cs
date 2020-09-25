using ScoopenAPIDAL.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoopenAPIModals;
namespace ScoopenAPIBLL
{
   public class AdminControllerBLL
    {
        IAdminControllerDAL _iAdminControllerDAL;
        public AdminControllerBLL(IAdminControllerDAL iAdminControllerDAL)
        {
            _iAdminControllerDAL = iAdminControllerDAL;
        }

        public void AddAgent(string firstName, string lastName, string gender, string dateOfBirth, string date, string email, string mobile, string address, string zipCode)
        {
            _iAdminControllerDAL.AddAgent(firstName,lastName,gender,dateOfBirth,date,email,mobile,address,zipCode);
        }
    }
}
