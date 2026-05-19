using System;
using System.Windows.Forms;
using System.IO;

namespace CinemaBookingSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(
            object sender,
            EventArgs e)
        {
            string username =
                textBoxUsername.Text;

            string password =
                textBoxPassword.Text;

            bool loginSuccess = false;

            if (File.Exists("users.txt"))
            {
                string[] users =
                    File.ReadAllLines("users.txt");

                foreach (string user in users)
                {
                    string[] parts = user.Split(':');

                    if (parts[0] == username
                        && parts[1] == password)
                    {
                        loginSuccess = true;
                        break;
                    }
                }
            }

            if (loginSuccess)
            {
                if (username == "admin")
                {
                    AdminForm adminForm =
                        new AdminForm();

                    adminForm.Show();
                }
                else
                {
                    Form1 mainForm = new Form1();

                    mainForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Неправильний логін або пароль!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonRegister_Click(
    object sender,
    EventArgs e)
        {
            RegisterForm registerForm =
                new RegisterForm();

            registerForm.ShowDialog();
        }

        private void CinemaName_Click(object sender, EventArgs e)
        {

        }
    }
}