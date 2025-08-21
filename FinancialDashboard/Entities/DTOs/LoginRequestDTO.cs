using System.ComponentModel.DataAnnotations;

namespace FinancialDashboard.Entities.DTOs
    
{
    public class LoginRequestDTO
    {
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email  { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 10 characters")]
        public string Password { get; set; }
    }
}
