using System;

namespace CSharp14Demo.Entities
{
    public partial class MovieService
    {
        // Partial constructor implementation — must match the declaration above (accessibility and parameter types).
        public partial MovieService(string movieName)
        {
            this.MovieName = movieName;
            this.MovieStatus = "BlockBuster";
     
            // additional initialization logic can go here
        }
        public string MovieName { get; set; }
        public void MovieDetails()
        {
            Console.WriteLine($"Movie { MovieName } created.");
            Console.WriteLine($"Box Office verdict - {MovieStatus} .");
        }
       
    }
}
