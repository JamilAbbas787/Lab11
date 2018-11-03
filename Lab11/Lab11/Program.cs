using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    { public static string ph = "place holder";     
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application \n" +
                "There are 10 movies in this list.");
            string continueApp = "y";
            while(continueApp.Equals("y", StringComparison.OrdinalIgnoreCase))
             {
                Console.WriteLine("What category are you interested in? (animated, drama, horror, scifi) : ");
                string selectedCategory = ValidateUserAnswer();
                Movies movies = new Movies(selectedCategory, null);
                movies.Category = selectedCategory;
                movies.SelectMovie(movies);

                Console.WriteLine("Continue? (y/n):  ");
                continueApp = Console.ReadLine();
                if (continueApp.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }
            }

            Console.WriteLine("Bye!");
            Console.ReadKey();

        }

        public static string ValidateUserAnswer()
        {
            string selectCategory = Console.ReadLine();
            bool categoryValidation = false;

            while(!categoryValidation)
            {
                
                if (selectCategory.Equals("animated",StringComparison.OrdinalIgnoreCase) 
                    || selectCategory.Equals("drama", StringComparison.OrdinalIgnoreCase)
                    || selectCategory.Equals("horror", StringComparison.OrdinalIgnoreCase)
                    || selectCategory.Equals("scifi", StringComparison.OrdinalIgnoreCase))
                {
                    categoryValidation = true;
                }
                else
                {
                    Console.WriteLine("Category not found. Please enter animate, drama, horror, or scifi:  ");
                    selectCategory = Console.ReadLine();
                    categoryValidation = false;
                }

                
            }
                return selectCategory;
        }
    }

    class Movies
    {
        private string _title;
        private string _category;

        public Movies(string Category, string Title)
        {
            _title = Title;
            _category = Category;

        }

        public string Title
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }

        public void SelectMovie(Movies movieListSelect)
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

            for (int i = 0; i < movieList.Count; i++)
            {
                
                if (movieList[i]._category == Category)
                {
                    string Titles;
                    Titles = movieList[i]._title;
                    Console.WriteLine( Titles );
                }
            }
        }
    }
}
            

            
        
            

    

