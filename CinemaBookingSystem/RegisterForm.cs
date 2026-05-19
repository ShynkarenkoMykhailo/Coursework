using System;
using System.IO;
using System.Windows.Forms;

namespace CinemaBookingSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(
            object sender,
            EventArgs e)
        {
            string username =
                textBoxUsername.Text;

            string password =
                textBoxPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show(
                    "Заповніть всі поля!");

                return;
            }

            string userData =
                $"{username}:{password}\n";

            File.AppendAllText(
                "users.txt",
                userData);

            MessageBox.Show(
                "Акаунт створено!");

            this.Close();
        }
    }
}