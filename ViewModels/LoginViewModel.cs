using System.ComponentModel.DataAnnotations;

namespace Instagram.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Login or Email")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
