using System.ComponentModel.DataAnnotations;

namespace TechnicalAssessmentRokov.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username is required to login", AllowEmptyStrings = false)]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required to login", AllowEmptyStrings = false)]
        public string Password { get; set; } = string.Empty;
    }
}
