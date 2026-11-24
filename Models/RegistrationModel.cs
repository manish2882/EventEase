using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [MinLength(3, ErrorMessage = "Name must be at least 3 characters.")]
        [RegularExpression(@"^[a-zA-Z\s]+$",
            ErrorMessage = "Only letters are allowed.")]
        public string Name { get; set; } = string.Empty;
    }
}