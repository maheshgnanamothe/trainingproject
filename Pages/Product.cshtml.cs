using dotnet.Pages.RegisterModelClass;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dotnet.Data.Context;
using dotnet.Data.Entity;

namespace dotnet.Pages.ProductModelClass
{
    public class ProductModel : PageModel
    {
        private readonly appdbcontext _context;

        public ProductModel(appdbcontext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProductClass prod { get; set; }
        
       

        public void OnGet()
        {
          
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var newprod = new Product
            {
                PName = prod.PName,
                PCategory = prod.PCategory,
                PPrice = prod.PPrice,
                Quantity = prod.Quantity,
                Description = prod.Description,
            };
            _context.Products.Add(newprod);
            _context.SaveChanges();
            return RedirectToPage("Producthome");
        }
    }
}
