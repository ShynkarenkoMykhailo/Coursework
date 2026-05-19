using CinemaBookingSystem.Models;
using Newtonsoft.Json;
using System.Net;

namespace CinemaBookingSystem
{

    public partial class Form1 : Form
    {
        private List<Movie> movies = new List<Movie>();

        private string apiKey = "d5f9652b1bba3f07c2842ba5843fb965";

        public Form1()
        {
            InitializeComponent();

            LoadMovies();
        }



        private async void LoadMovies()
        {
            string url =
                $"https://api.themoviedb.org/3/movie/now_playing?api_key={apiKey}&language=uk-UA&page=1";

            using (WebClient client = new WebClient())
            {
                string json = await client.DownloadStringTaskAsync(url);

                MovieResponse response =
                    JsonConvert.DeserializeObject<MovieResponse>(json);

                movies = response.results;

                foreach (Movie movie in movies)
                {
                    listBoxMovies.Items.Add(movie.title);
                }
            }
        }

        private async void listBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxMovies.SelectedIndex;

            if (index >= 0)
            {
                Movie selectedMovie = movies[index];

                richTextBoxDescription.Text =
                   $"{selectedMovie.title}\n\n" +
                   $"Рейтинг: {selectedMovie.vote_average}\n\n" +
                   $"{selectedMovie.overview}";

                string imageUrl =
                    $"https://image.tmdb.org/t/p/w500{selectedMovie.poster_path}";

                pictureBoxPoster.Load(imageUrl);
            }
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            if (listBoxMovies.SelectedIndex >= 0)
            {
                string selectedMovie =
                    movies[listBoxMovies.SelectedIndex].title;

                BookingForm bookingForm =
                    new BookingForm(selectedMovie);

                bookingForm.ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "Оберіть фільм!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void buttonBook_MouseEnter(object sender, EventArgs e)
        {
            buttonBook.BackColor = Color.DeepSkyBlue;
        }

        private void buttonBook_MouseLeave(object sender, EventArgs e)
        {
            buttonBook.BackColor = Color.FromArgb(0, 120, 215);
        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}