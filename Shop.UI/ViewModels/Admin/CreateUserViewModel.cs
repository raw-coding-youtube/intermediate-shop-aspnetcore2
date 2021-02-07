using System.ComponentModel.DataAnnotations;

namespace Shop.UI.ViewModels.Admin
{
    public class CreateUserViewModel
    {
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
