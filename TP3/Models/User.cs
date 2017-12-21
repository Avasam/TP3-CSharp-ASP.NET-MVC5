
using System.ComponentModel.DataAnnotations;

namespace TP3.Models
{
    public class User
    {
        [Required(ErrorMessage = "Un username et requis")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Un mot de passe est requis")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Un email est requis")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Un role et requis")]
        public string Role { get; set; }

        public User(string username, string password, string email, string role="user") {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Role = role;
        }
    }
}