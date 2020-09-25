using ScoopenAPIModals.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.ModelBinding;

namespace ScoopenAPIDAL.Admin
{
    public class AdminControllerDAL : IAdminControllerDAL
    {
        public void AddAgent(string firstName, string lastName, string gender, string dateOfBirth, string date, string email, string mobile, string address, string zipCode)
        {
            using (SqlConnection con = Connection.SqlConnectionObject)
            {
                SqlDataReader reader = ExecuteScoopenDB.ExecuteReader(con, ScoopenDB.spAddNewAgent,
                     new SqlParameter() { ParameterName = "@FirstName", Value = firstName },
                     new SqlParameter() { ParameterName = "@LastName", Value = lastName },
                     new SqlParameter() { ParameterName = "@Gender", Value = gender },
                     new SqlParameter() { ParameterName = "@DateOfBirth", Value = dateOfBirth },
                     new SqlParameter() { ParameterName = "@Date", Value = date },
                     new SqlParameter() { ParameterName = "@Email", Value = email },
                     new SqlParameter() { ParameterName = "@Mobile", Value = mobile },
                     new SqlParameter() { ParameterName = "@Address", Value = address },
                     new SqlParameter() { ParameterName = "@ZipCode", Value = zipCode });

                
              
            }
        }

        
    }
}
