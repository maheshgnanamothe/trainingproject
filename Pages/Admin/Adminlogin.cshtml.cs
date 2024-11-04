using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace dotnet.Pages.Admin
{
    public class AdminloginModel : PageModel
    {

        [BindProperty]

        public string name { get; set; }

        [BindProperty]
        public string password { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {

            if (name == "admin" && password == "admin")
            {
                TempData["message"] = "Admin login successfully....!!!!";
                TempData["link"] = "/Admin/Adminhome";
                return RedirectToPage("../Response");


            }
            return Page();

        }

    }
}
