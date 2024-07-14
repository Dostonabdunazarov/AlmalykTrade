using AlmalykTrade.DbConnection;
using AlmalykTrade.Models;

namespace AlmalykTrade
{
    public partial class Registration : Form
    {
        private Login _LoginForm;
        private MainForm _MainForm;
        public Registration(Login LoginForm, MainForm mainForm)
        {
            InitializeComponent();
            _LoginForm = LoginForm;
            _MainForm = mainForm;
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginTextBox.Text))
            {
                MessageBox.Show("Введите Логин!", "Ошибка");
                return;
            }
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Введите Пароль!", "Ошибка");
                return;
            }
            if (string.IsNullOrEmpty(rolesCombobox.Text))
            {
                MessageBox.Show("Выберите роль!", "Ошибка");
                return;
            }

            var login = loginTextBox.Text.Trim();
            var password = passwordTextBox.Text.Trim();
            var role = rolesCombobox.Text.Trim();

            var UserList = DbData.GetUsers();
            if (UserList.Any(x => x.Login == login))
            {
                MessageBox.Show("Такой Логин существует в базе, выберите другой Логин!", "Ошибка");
                return;
            }

            var hashPass = Crypto.Crypto.HashPassword(password);

            var success = DbData.AddUser(new User(login, hashPass, role));

            if (success)
                MessageBox.Show("Пользователь успешно добавлен!");
            else
                MessageBox.Show("Возникли ошибки при добавлении пользователя!", "Ошибка");

            this.Hide();
            if (_LoginForm.IsAdmin)
            {
                _MainForm.usersGrid.DataSource = DbData.GetUsers();
            }
            _MainForm.Show();
        }

        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckbox.Checked)
                passwordTextBox.UseSystemPasswordChar = false;
            else
                passwordTextBox.UseSystemPasswordChar = true;
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            _LoginForm.Close();
        }
    }
}
