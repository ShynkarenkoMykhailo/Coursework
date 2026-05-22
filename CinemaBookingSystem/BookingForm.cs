using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace CinemaBookingSystem
{
    public partial class BookingForm : Form
    {
        private string movieTitle;

        public BookingForm(string selectedMovie)
        {
            InitializeComponent();

            movieTitle = selectedMovie;

            label1.Text = $"Бронювання: {movieTitle}";

            foreach (Control control in Controls)
            {
                if (control is Button btn && btn.Name.StartsWith("buttonSeat"))
                {
                    RoundButton(btn);

                    btn.BackColor = Color.Green;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.ForeColor = Color.White;

                    btn.MouseEnter += SeatButton_MouseEnter;
                    btn.MouseLeave += SeatButton_MouseLeave;

                    btn.Click += buttonSeat_Click;
                }
            }
        }

        private void RoundButton(Button btn)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(btn.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(btn.Width - 20, btn.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, btn.Height - 20, 20, 20, 90, 90);

            path.CloseAllFigures();

            btn.Region = new Region(path);
        }

        private void SeatButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Enabled)
            {
                btn.BackColor = Color.LightGreen;
            }
        }

        private void SeatButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Enabled)
            {
                btn.BackColor = Color.Green;
            }
        }

        private void buttonSeat_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;

            seatButton.BackColor = Color.Red;

            seatButton.Enabled = false;

            string ticketInfo =
                $"Фільм: {movieTitle}\n" +
                $"Місце: {seatButton.Text}\n" +
                $"Дата: {DateTime.Now}\n" +
                $"-------------------------\n";

            File.AppendAllText("tickets.txt", ticketInfo);

            MessageBox.Show(
                $"Ви забронювали місце {seatButton.Text}\n" +
                $"на фільм:\n{movieTitle}",
                "Бронювання успішне",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void buttonSeat1_Click(object sender, EventArgs e)
        {

        }
    }
}