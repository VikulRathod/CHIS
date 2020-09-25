using ScoopenAPIModals.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoopenAPIDAL.Admin
{
    public interface IAdminControllerDAL
    {
        void AddAgent(string firstName, string lastName, string gender, string dateOfBirth, string date, string email, string mobile,string address, string zipCode);
       
    }
}
