using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAlayer
{
    public enum Gender { Male, Female, others };
    public class Employee
    {
        [Required(ErrorMessage = "Please Enter First Name")]
        public string First_name { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name")]
        public string Last_name { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required (ErrorMessage = "Contact should not be more or less than 10 digit")]
        public long Contact { get; set; }

        [Required(ErrorMessage = "Please Enter Email Address")]
        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
          ErrorMessage = "Please Enter Correct Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter User Id")]
        [MinLength(6, ErrorMessage = "Please Enter 6 digit user Id")]
        [Key]
        public int UserId { get; set; }


        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Provide User-Category")]
        public string User_category { get; set; }
    }
}
