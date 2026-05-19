using System;
using System.IO;
using System.Windows.Forms;

namespace CinemaBookingSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            LoadUsers();

            LoadTickets();
        }

        private void LoadUsers()
        {
            if (File.Exists("users.txt"))
            {
                string[] users =
                    File.ReadAllLines("users.txt");

                listBoxUsers.Items.AddRange(users);
            }
        }

        private void LoadTickets()
        {
            if (File.Exists("tickets.txt"))
            {
                string[] tickets =
                    File.ReadAllLines("tickets.txt");

                listBoxTickets.Items.AddRange(tickets);
            }
        }

        private void buttonClearTickets_Click(
            object sender,
            EventArgs e)
        {
            File.WriteAllText("tickets.txt", "");

            listBoxTickets.Items.Clear();

            MessageBox.Show(
                "Бронювання очищені!");
        }

        private void AdminPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
