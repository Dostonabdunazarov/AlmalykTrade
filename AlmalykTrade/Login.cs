using AlmalykTrade.DbConnection;
using AlmalykTrade.Models;
using System.Data.SqlClient;

namespace AlmalykTrade
{
    public partial class Login : Form
    {
        public User User { get; set; }
        public bool IsAuthorized { get; set; }
        public bool IsAdmin { get; set; }

        public Login()
        {
            InitializeComponent();
            passwordTextbox.UseSystemPasswordChar = true;
        }

        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckbox.Checked)
                passwordTextbox.UseSystemPasswordChar = false;
            else
                passwordTextbox.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordTextbox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) )
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
                return;
            }

            User = AuthorizeUser(login, password);
            if (User != null)
            {
                IsAdmin = User.IsAdmin();
                MainForm mainForm = new MainForm(this);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка");
            }
        }

        private User AuthorizeUser(string login, string password)
        {
            var dbQeury = new DBquery();
            var hashPassword = Crypto.Crypto.HashPassword(password);

            var UserList = DbData.GetUsers();

            
            using (SqlConnection con = new SqlConnection(dbQeury.StringCon()))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand($"SELECT Login, Password, Role FROM [User] WHERE Login = '{login}' and Password = '{hashPassword}'", con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            IsAuthorized = true;
                            return new User(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                        }
                    }
                }
            }

            return null;
        }
    }
}
