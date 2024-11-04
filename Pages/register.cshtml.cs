using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dotnet.Pages.RegisterModelClass;
using Microsoft.AspNetCore.Mvc.Rendering;
using dotnet.Data.Context;
using dotnet.Data.Entity;

namespace dotnet.Pages
{
    public class registerModel : PageModel
    {
        private readonly appdbcontext _context;

        public readonly IWebHostEnvironment _environment;

        public registerModel(appdbcontext context, IWebHostEnvironment _env)
        {
            _context = context;
            _environment = _env;
        }
        
        [BindProperty]
       public RegisterClass reg {  get; set; }
        
        public void OnGet()
        {
            reg = new RegisterClass
            {

                Gender = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Male" },
                new SelectListItem { Value = "2", Text = "Female" }
            }
            };
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var filename=Guid.NewGuid().ToString()+Path.GetExtension(reg.Image.FileName);

            var filepath=Path.Combine(_environment.WebRootPath,"Upload", filename);

            var fileStream = new FileStream(filepath, FileMode.Create);
            reg.Image.CopyToAsync(fileStream);
            var newCus = new Customer
            {
                
                Name = reg.Name,
                Email = reg.Email,
                Password = reg.Password,
                Age = reg.Age,
                ImgPath=filename
            };
            TempData["message"] = "registed successfully....!!!!";
            TempData["link"] = "/Login";
            _context.Customers.Add(newCus);
            _context.SaveChanges();

            
            return RedirectToPage("Response");



        }
    }
}
