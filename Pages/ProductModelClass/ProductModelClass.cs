using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace dotnet.Pages.ProductModelClass
{
    public class ProductClass
    {
        [Required]
        public string PName { get; set; }

        [Required]
        public string PCategory { get; set; }
        [Required]
        
        public decimal PPrice { get; set; }
        [Required]

        public int Quantity { get; set; }
        [Required]

        public string Description { get; set; }
        

        
    }
}
