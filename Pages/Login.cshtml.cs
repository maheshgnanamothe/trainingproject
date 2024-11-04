using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dotnet.Pages.LoginModelClass;

namespace dotnet.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginClass user { get; set; }
        public void OnGet()
        {
        } public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            
            TempData["message"] = "Login successfully....!!!!";
            TempData["link"] = "/Index";
            return RedirectToPage("Response");
        }
    }
}
