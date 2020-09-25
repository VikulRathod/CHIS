using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoopenAPIModals.Admin
{
   public class AddNewAgent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }
        [DataType(DataType.Date)]
        public string Date { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Minimum And Maximum Length Is")]

        public string Mobile { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
    }
}
