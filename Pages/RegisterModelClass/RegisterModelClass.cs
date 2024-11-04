using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace dotnet.Pages.RegisterModelClass
{
    public class RegisterClass
    {
        
        [Required(ErrorMessage ="Whats your name")]
        
        public string Name { get; set; }

        [Required(ErrorMessage ="whats your email")]
        [EmailAddress]

        public string Email { get; set; }

        [Required(ErrorMessage ="Enter a password broo")]
        public string Password { get; set; }


        [Required(ErrorMessage ="18+")]
        [Range(0,100)]

        public int Age { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        [Required(ErrorMessage = "Please select a gender.")]
        public string SelectedGender { get; set; }  

        public List<SelectListItem> Gender { get; set; } = new List<SelectListItem>();  
    }
}
