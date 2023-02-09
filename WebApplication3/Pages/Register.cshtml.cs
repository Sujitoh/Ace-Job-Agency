using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.ViewModels;

namespace WebApplication3.Pages
{
    public class RegisterModel : PageModel
    {

        private UserManager<Register> userManager { get; }
        private SignInManager<Register> signInManager { get; }

        [BindProperty]
        public Register RModel { get; set; }

        public string[] Genders = new[] { "Male", "Female", "Unspecified" };

	public RegisterModel(UserManager<Register> userManager, SignInManager<Register> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }



        public void OnGet()
        {
        }


        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = new Register()
                {
                    UserName = RModel.Email,
                    FirstName = RModel.Email,
                    LastName = RModel.Email,
                    Gender = RModel.Email,
                    NRIC = RModel.Email,
                    Email = RModel.Email,
                    Dob = RModel.Dob,
                    Upload = RModel.Email,
                    WhoamI = RModel.Email
                };
                var result = await userManager.CreateAsync(user, RModel.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToPage("Index");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return Page();
        }







    }
}
