using dotnet.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dotnet.Data.Entity;

namespace dotnet.Pages.Admin
{
    public class AdminhomeModel : PageModel
    {
        private readonly appdbcontext _context;

        public int id { get; set; }

        public List<Customer> CustomerList { get; set; }

        public AdminhomeModel(appdbcontext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            CustomerList = _context.Customers.ToList();
        }
        public IActionResult OnGetStatus(int? id, int? status)
        {
            var user = _context.Customers.Find(id);
            if (user != null)
            {
                if (status == 0)
                {
                    user.isActive = 1;
                }
                else
                {
                    user.isActive = 0;
                }
                _context.SaveChanges();
            }
            return RedirectToPage();
        }

        public IActionResult OnGetDelete(int? id)
        {
            var user = _context.Customers.Find(id);

            if (user != null)
            {
                _context.Customers.Remove(user);
                _context.SaveChanges();
            }
            return RedirectToPage();

        }


    }
}
