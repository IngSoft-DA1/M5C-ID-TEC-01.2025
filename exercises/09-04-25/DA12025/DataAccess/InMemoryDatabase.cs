using Domain;

namespace DataAccess
{
    public class InMemoryDatabase
    {
        public List<Movie> Movies { get; set; }

        public InMemoryDatabase()
        {
            Movies = new List<Movie>();
            LoadDefaultMovies();
        }

        private void LoadDefaultMovies()
        {
            Movies.Add(new Movie("Cast Away", "Robert Zemeckis", new DateTime(2000, 12, 22)));
        }
    }
}