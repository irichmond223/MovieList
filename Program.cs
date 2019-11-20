using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>()
            {
                {new Movie("Toy Story", "animated") },
                {new Movie("Coco", "animated") },
                {new Movie("Wall-E", "animated") },
                {new Movie("John Q", "drama") },
                {new Movie("Memiors of a Geisha", "drama") },
                {new Movie("Get Out", "horror") },
                {new Movie("Us", "horror") },
                {new Movie("IT", "horror") },
                {new Movie("Interstellar", "scifi") },
                {new Movie("Star Wars", "scifi") }
            };

            movieList.Sort((x, y) => x.Title.CompareTo(y.Title));

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("What category are you interested in? (Animated, Drama, Horror, Scifi)");
            string input = Console.ReadLine();
            string ans = Validate(input);

            foreach (Movie m in movieList)
            {
                //input = m.Category.ToLower();

                if (m.Category == ans)
                {
                    Console.WriteLine($"{m.Title}");
                }
            }

        }

        public static string Validate(string input)
        {
            //bool again = true;
            while (true)
            {
                try
                {
                    if (input.ToLower() == "drama" || input.ToLower() == "animated" || input.ToLower() == "scifi" || input.ToLower() == "horror")
                    {
                        //again = false;
                        return input.ToLower();

                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid category");
                        input = Console.ReadLine();
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter a valid category");
                    input = Console.ReadLine();
                    //again = true;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Please enter a valid category");
                    input = Console.ReadLine();
                    //again = true;
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Please enter a valid category");
                    input = Console.ReadLine();
                }
            }
            //again = true;

        }
    }
}


            

         