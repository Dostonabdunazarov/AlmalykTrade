using AlmalykTrade.DbConnection;
using System;

namespace AlmalykTrade.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public User() { }
        public User(string login, string password, string role)
        {
            Login = login;
            Password = password;
            Role = role;
        }

        public bool IsAdmin() => Role == "Админ";
    }
}
