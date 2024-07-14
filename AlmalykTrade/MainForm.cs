using AlmalykTrade.DbConnection;

namespace AlmalykTrade
{
    public partial class MainForm : Form
    {
        private Login _LoginForm;
        public MainForm(Login loginForm)
        {
            InitializeComponent();
            _LoginForm = loginForm;

            if (!loginForm.IsAdmin)
            {
                panel2.Visible = false;
                addUserButton.Visible = false;
                removeUserButton.Visible = false;
            }
            else
            {
                usersGrid.DataSource = DbData.GetUsers();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _LoginForm.Close();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var regForm = new Registration(_LoginForm, this);
            regForm.ShowDialog();
        }
    }
}
