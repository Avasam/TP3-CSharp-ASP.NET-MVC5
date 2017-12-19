
namespace TP3.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public User(string username, string password, string email, string role="user") {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Role = role;
        }
    }
}