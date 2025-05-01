using Domain;

namespace DataAccess
{
    public class InMemoryDatabase
    {
        public List<Movie> Movies { get; set; }
        public List<User> Users { get; set; }

        public InMemoryDatabase()
        {
            Movies = new List<Movie>();
            Users = new List<User>();
            LoadDefaultMovies();
            LoadDefaultAdministratorUser();
        }

        private void LoadDefaultMovies()
        {
            Movies.Add(new Movie("Cast Away", "Robert Zemeckis", new DateTime(2000, 12, 22), 25000000));
        }

        private void LoadDefaultAdministratorUser()
        {
            Users.Add(new User("Alumno", "Ort", "alumno@ort.com.uy", "123456", "User"));
        }
    }
}