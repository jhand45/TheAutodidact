using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TheAutodidact3.Models
{
    public class Contact
    {
        private DateTime _Date = DateTime.Now;
  
        public DateTime Date { get { return _Date;  } set { _Date = value; } }

        [Required]
        [StringLength(50, ErrorMessage = "I doubt that's your real name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "You might need to give us an abbreviated Last Name")]
        [Display(Name = "Second Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
