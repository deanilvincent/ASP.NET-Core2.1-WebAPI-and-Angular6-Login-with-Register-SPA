using System.ComponentModel.DataAnnotations;

namespace MyWebApp.API.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}