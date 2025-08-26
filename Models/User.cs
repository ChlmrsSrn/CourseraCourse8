using System.ComponentModel.DataAnnotations;

namespace SafeVault.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        public string PasswordHash { get; set; }
        public string Role { get; set; }
    }
}