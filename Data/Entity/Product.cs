using System.ComponentModel.DataAnnotations;

namespace dotnet.Data.Entity
{
    public class Product
    {
        [Key]
        public int PId { get; set; }
        
        [Required, MaxLength(30)]
        public string PName { get; set; }
        
        [Required, MaxLength(30)]

        public string PCategory { get; set; }
        
        [Required, MaxLength(30)]

        public decimal PPrice { get; set; }

        [Required, MaxLength(30)]

        public int Quantity { get; set; }

        public string Description { get; set; }

        public int isActive { get; set; } = 1;
    }
}
