using System.ComponentModel.DataAnnotations;

namespace smartCooker.Models.DTOs.Requests
{
    public class UserRegistrationDto
    {
        [Required]
        public string NIC { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}