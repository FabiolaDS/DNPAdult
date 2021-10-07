using System.ComponentModel.DataAnnotations;

namespace Family.Pages
{
    class LoginModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}