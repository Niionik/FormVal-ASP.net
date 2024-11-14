using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace FormVal.Models;
{
    public class Registration
    {
        [Required(ErrorMessage = "First name is required")]
        [MinLength(2, ErrorMessage = "Name must have at least 2 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MinLength(2, ErrorMessage = "Last name must have at least 2 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email adress is required")]
        [EmailAddress(ErrorMessage = "Incorrect email address format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, and one digit.")]
        [MinLength(8, ErrorMessage = "Your password must contain 8 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password confirmation is required")]
        [Compare("Password", ErrorMessage = "Passwords provided must be the same")]
        public string PasswordConfirmation { get; set; }

        [Phone(ErrorMessage = "Niepoprawny format numeru telefonu")]
        public string MobileNumber { get; set; }

        [Range(10,80, ErrorMessage = $"Age must be between 10 and 80 years.")]
        public int Age { get; set; }

        [Required]
        public Categories City { get; set; }

        public string Category { get; set; }
        public enum Categories { Village = 1, Town = 2, SmallCity = 3, City = 4, Metropolis = 5 }
    }
}
