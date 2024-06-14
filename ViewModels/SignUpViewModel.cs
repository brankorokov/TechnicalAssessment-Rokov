using System.ComponentModel.DataAnnotations;

namespace TechnicalAssessmentRokov.ViewModels
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "User Name is required to sign up", AllowEmptyStrings = false)]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required to sign up", AllowEmptyStrings = false)]
        public string Password { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;
    }
}
