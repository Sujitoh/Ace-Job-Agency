using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;

namespace WebApplication3.ViewModels
{
    public class Register : IdentityUser
    {
		[Required]
		[DataType(DataType.Text)]
		public string FirstName { get; set; }

		[Required]
		[DataType(DataType.Text)]
		public string LastName { get; set; }

		[BindProperty, Required]
		public string Gender { get; set; }
        

		[Required]
		[DataType(DataType.Text)]
		public string NRIC { get; set; }

		[Required]
        [DataType(DataType.Text)]
        public string Email { get; set; }

		[NotMapped]
        [Required]
        [DataType(DataType.Text)]
        public string Password { get; set; }

		[NotMapped]
		[Required]
        [DataType(DataType.Text)]
        [Compare(nameof(Password), ErrorMessage = "Password and confirmation password does not match")]
        public string ConfirmPassword { get; set; }

		[DataType(DataType.Date)]
		[Display(Name = "Date Of Birth")]
		public DateTime Dob { get; set; } = new DateTime(DateTime.Now.Year -
		18, 1, 1);

		[Required]
		[DataType(DataType.Upload)]
		public string Upload { get; set; }

		[Required]
		[DataType(DataType.Text)]
		public string WhoamI { get; set; }


	}
}
