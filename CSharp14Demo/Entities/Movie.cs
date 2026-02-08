using System;
using System.Text;

namespace CSharp14Demo.Entities
{
    public class Movie
    {
        public string? Title { get; set; }
        public string? Director { get; set; }
        public int ReleaseYear { get; set; }
        public int Rating { get; private set; }

        // Regular constructor (compatible with current C# compilers)
        public Movie(int rating)
        {
            Rating = rating;
        }

        // If you want an additional constructor with title/director etc:
        public Movie(string? title, string? director, int releaseYear, int rating)
            : this(rating)
        {
            Title = title;
            Director = director;
            ReleaseYear = releaseYear;
        }

        // Implement binary +. The compiler uses this for += as well.
        // This mutates the instance; if you prefer immutable semantics, return a new Movie instead.
        public void operator +=(int increment)
        {           
            Rating += increment;
        }
    }
}