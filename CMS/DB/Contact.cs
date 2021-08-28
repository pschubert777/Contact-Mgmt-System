using System;
using System.ComponentModel.DataAnnotations;

namespace CMS.DB
{
    public class Contact
    {
      [Key]
      public int Id { get; set; }

      [Required]
      [MaxLength(250)]
      public string LastName { get; set; }

      [Required]
      [MaxLength(250)]
      public string FirstName { get; set; }

      [MaxLength(15)]
      public string PhoneNumber { get; set; }

      public DateTime BirthDate { get; set; }
    }
}
