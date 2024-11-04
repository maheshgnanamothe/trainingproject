using System.ComponentModel.DataAnnotations;

namespace dotnet.Data.Entity
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(30)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public int Age { get; set; }

        public int isActive { get; set; } = 1;

        public string ImgPath { get; set; }
    }
}
