using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace dotnet.Pages.LoginModelClass
{
    public class LoginClass
    {

        [Required(ErrorMessage ="Email daldo bhai")]
        [EmailAddress]
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
