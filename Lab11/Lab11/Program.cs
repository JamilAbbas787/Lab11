using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new Movies("Word", "Other Word");

            Console.ReadKey();
        }
    }

    class Movies
    {
        private string title;
        private string category;

        public Movies(string category, string title)
        {
            Title = title;
            
        }

        public string Title { get; set; }
        public string Category { get; set; }

        public void SelectMovie()
        {
            List<Movies> movieList = new List<Movies>();
            movieList.Add(new Movies("drama", "Hell or High Water"));
            movieList.Add(new Movies("animated", "Minions"));
            movieList.Add(new Movies("drama", "The Social Network"));
            movieList.Add(new Movies("horror", "Halloween"));
            movieList.Add(new Movies("drama", "The Shawshank Redemption"));
            movieList.Add(new Movies("horror", "IT"));
            movieList.Add(new Movies("drama", "Forrest Gump"));
            movieList.Add(new Movies("animated", "Toy Story"));
            movieList.Add(new Movies("scifi", "Interstellar"));
            movieList.Add(new Movies("animated", "Frozen"));

        }
            

    }
}
