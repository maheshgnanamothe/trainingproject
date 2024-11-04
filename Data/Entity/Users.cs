using System.ComponentModel.DataAnnotations;

namespace dotnet.Data.Entity
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required,MaxLength(30)]
        public string Name { get; set; }

        [Required,MaxLength(100)]
        public string Email { get; set; }

    }
}
