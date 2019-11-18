using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movie = new List<Movie>()
            {
             new Movie ("Frozen","animated",1),
             new Movie ("Toy Story","animated",1),
             new Movie ("Cars","animated",1),
             new Movie ("Interstellar","drama",2),
             new Movie ("Black Swan","drama",2),
             new Movie ("Fight Club","drama",2),
             new Movie ("Us","horror",3),
             new Movie ("Doctor Sleep","horror",3),
             new Movie ("Saw","horror",3),
             new Movie ("Avengers","scifi",4),
             new Movie ("Black Panther","scifi",4),
             new Movie ("Star Wars","scifi",4),
            };

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 100 movies in this list.");

            bool playAgain = true;
            while (playAgain)
            {
                Console.WriteLine("What category are you interested in? ");
                Console.WriteLine("\n1) Animated\n2) Drama\n3) Horror\n4) Scifi");

                //string input = Validator(movie);
                string input = Console.ReadLine();
                int user = int.Parse(input);

                foreach (var item in movie)
                {
                    if (user == item.categoryCodes && user == 1)
                    {
                        Console.WriteLine(item.Title);
                    }
                    else if (user == item.categoryCodes && user == 2)
                    {
                        Console.WriteLine(item.Title);
                    }
                    else if (user == item.categoryCodes && user == 3)
                    {
                        Console.WriteLine(item.Title);
                    }
                    else if (user == item.categoryCodes && user == 4)
                    {
                        Console.WriteLine(item.Title);
                    }
                }
                bool continueAgain = true;
                while (continueAgain)
                {
                    Console.WriteLine("Continue? (y/n)");
                    string userContinue = Console.ReadLine().ToLower();
                    if (userContinue == "y")
                    {
                        continueAgain = false;
                        playAgain = true;
                    }
                    else if (userContinue == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        playAgain = false;
                        continueAgain = false;
                    }
                }
            }

        }

        //Display movies by category having a user enter the name
        //foreach (var item in movie)
        //{
        //    if (input.ToLower() == item.Category.ToLower() && input == "animated")
        //    {
        //        Console.WriteLine(item.Title);
        //    }
        //    else if (input.ToLower() == item.Category.ToLower() && input == "drama")
        //    {
        //        Console.WriteLine(item.Title);
        //    }
        //    else if (input.ToLower() == item.Category.ToLower() && input == "horror")
        //    {
        //        Console.WriteLine(item.Title);
        //    }
        //    else if (input.ToLower() == item.Category.ToLower() && input == "scifi")
        //    {
        //        Console.WriteLine(item.Title);
        //    }

        //}

        //public static string Validator(List<Movie> userInput)
        //{
        //    bool validateAgain = true;
        //    bool playAgain = true;
        //    string stringUserInput = "";
        //    while(validateAgain)
        //    {
        //        try
        //        {
        //            stringUserInput = Console.ReadLine();
        //            //validateAgain = false;
        //            playAgain = true;

        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("Please use the correct format. Please try again.");
        //            //validateAgain = true;
        //            playAgain = false;
        //        }
        //        catch (Exception)
        //        {
        //            Console.WriteLine("An error has occurred. Please try again.");
        //            //validateAgain = true;
        //            playAgain = false;
        //        }
        //    } 
        //    return stringUserInput;

        //}
    }
}


