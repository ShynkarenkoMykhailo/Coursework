namespace CinemaBookingSystem.Models
{
    public class Movie
    {
        public int id { get; set; }

        public string title { get; set; }

        public string overview { get; set; }

        public string poster_path { get; set; }

        public double vote_average { get; set; }

        public string release_date { get; set; }
    }
}