using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Doggies.Models
{
    public class LoginModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
    public class RegisterModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        public string UserName { get; set; }
    }

    public class ManageUserViewModel
    {
        [Required]
        public string OldPassword { get; set; }

        [Required]
        public string NewPassword { get; set; }

        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
