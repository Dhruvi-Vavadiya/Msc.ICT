using System.ComponentModel.DataAnnotations;

namespace MVCWebApp.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        [MaxLength(50, ErrorMessage = "The {0} can not have more than {1} characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Your {0} is required")]
        [StringLength(60, MinimumLength = 4, ErrorMessage = "{0} should be between 4 to 60 Char")]
        public string LastName { get; set; }
        [Required]
        public string Designtion { get; set; }

        [Range(18, 30)]
        public int age { get; set; }

        //[RegularExpression(@ "\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Invalid Email Id")]
        public string Email { get; set; }

        //[Compare("Email")]
        //public string ConfirmEmail { get; set; }

        [DataType(DataType.Password)]
        public string Password
        {
            get;
            set;
        }

        public string Passwordd { get; set; }
        [Compare("Customer.Passwordd", ErrorMessage = "The fields Password and PasswordConfirmation should be equals")]
        public string PasswordConfirmation { get; set; }

        [Range(typeof(DateTime), "01/01/1900", "01/01/2014",
    ErrorMessage = "Valid dates for the Property {0} between {1} and {2}")]
        public DateTime EntryDate { get; set; }
    }
}
