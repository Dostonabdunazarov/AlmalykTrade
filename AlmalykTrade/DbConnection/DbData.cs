using AlmalykTrade.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmalykTrade.DbConnection
{
    public static class DbData
    {
        static string _strConnection = @"Data Source=DESKTOP-3CO9M8M\MYSQLEXPRESS;Initial Catalog=AlmalykTrade2024;Integrated Security=True; Persist Security Info=True;User ID=admin;Password=Dost0n1994!";
        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (SqlConnection conn = new SqlConnection(_strConnection))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand($"SELECT Login, Password, Role FROM [User]", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                Login = reader.GetString(0),
                                Password = reader.GetString(1),
                                Role = reader.GetString(2),
                            });
                        }
                    }
                }
            }
            return users;
        }

        public static bool AddUser(User user) 
        {
            try
            {
                using (var conn = new SqlConnection(_strConnection))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO [User](Login, Password, Role) Values(@Login, @Password, @Role)";

                        cmd.Parameters.AddWithValue("@Login", user.Login);
                        cmd.Parameters.AddWithValue("@Password", user.Password);
                        cmd.Parameters.AddWithValue("@Role", user.Role);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
