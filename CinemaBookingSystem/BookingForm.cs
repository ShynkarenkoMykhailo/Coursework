using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace CinemaBookingSystem
{
    public partial class BookingForm : Form
    {
        private string movieTitle;

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

        public BookingForm(string selectedMovie)
        {
            InitializeComponent();

            movieTitle = selectedMovie;

            label1.Text = $"Бронювання: {movieTitle}";

        }


        private void buttonSeat1_Click(object sender, EventArgs e)
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

        private void panelScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panelFree_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}