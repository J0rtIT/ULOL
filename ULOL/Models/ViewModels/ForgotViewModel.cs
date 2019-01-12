using System.ComponentModel.DataAnnotations;

namespace ULOL.Models.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
