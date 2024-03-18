using System.ComponentModel.DataAnnotations;

namespace VenturaCore.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your surname")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please enter your username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your mail")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}