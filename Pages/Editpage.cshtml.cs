using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using dotnet.Data.Entity;
using dotnet.Data.Context;


namespace dotnet.Pages
{
    public class EditpageModel : PageModel
    {
        private readonly appdbcontext _context;

        [BindProperty]
        public Customer Customer { get; set; }

        public EditpageModel(appdbcontext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public void OnGetEdit(int? id)
        {
            var user = _context.Customers.Find(id);

            Customer = user;

        }

        public IActionResult OnPostSubmit()
        {
            var user = _context.Customers.Find(Customer.Id);
            if (user != null)
            {
                user.Name = Customer.Name;
                user.Email = Customer.Email;
                user.Password = Customer.Password;
                user.Age = Customer.Age;
                _context.SaveChanges();
            }
            return RedirectToPage("/Admin/Adminhome");
        }
    }
}
