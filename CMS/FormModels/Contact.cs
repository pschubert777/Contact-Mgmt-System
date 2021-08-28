using System;
using System.ComponentModel.DataAnnotations;

namespace CMS.FormModels
{
    public class ContactModel
    {
            public ContactModel()
            {

            }
            public ContactModel(string FirstName, string LastName,string  PhoneNumber, DateTime BirthDate)
            {
                this.LastName = LastName;
                this.FirstName= FirstName;
                this.PhoneNumber = PhoneNumber;
                this.BirthDate = BirthDate;


            }

            [Required]
            [StringLength(250, ErrorMessage = "Last Name is not valid")]
            [MinLength(1, ErrorMessage = "Last Name is required")]
            public string LastName { get; set; }

            [Required]
            [StringLength(250, ErrorMessage = "First Name is not valid")]
            [MinLength(1, ErrorMessage = "First Name is required")]
            public string FirstName { get; set; }

            [StringLength(15, ErrorMessage = "Phone number is not valid")]
            [Phone]
            public string PhoneNumber { get; set; }

            public DateTime BirthDate { get; set; } = DateTime.Now;
    }


}
