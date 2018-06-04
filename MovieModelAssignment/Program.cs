using System;
using System.Collections.Generic;

namespace MovieModelAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Movie Representaion");
            //Console.ReadKey();
            //Console.WriteLine(MyClass.Add(10, 20, 5));
            //Console.ReadKey();

            //Console.WriteLine("Give a movie title: ");
            //string title = Console.ReadLine();
            //Console.Write("You typed: ");
            //Console.Write(title);
            //Console.ReadKey();


            List<Movie> movies = new List<Movie>();

            Movie firstMovie = new Movie
            {
                Title = "Home alone",
                Rating = 0,
                Revenue = 285761243,
                Casting = "Macaulay Culkin, Joe Pesci, Daniel Stern"
            };

            Movie secondMovie = new Movie
            {
                Title = "Lord of the rings",
                Rating = 0,
                Revenue = 315544750,
                Casting = "Elijah Wood, Orlando Bloom, Viggo Mortensen, Ian McKellen"
            };

            Movie thirdMovie = new Movie
            {
                Title = "The Bank Job",
                Rating = 0,
                Revenue = 30028592,
                Casting = "	Jason Statham, Saffron Burrows, Stephen Campbell Moore"
            };


            movies.Add(firstMovie);
            movies.Add(secondMovie);
            movies.Add(thirdMovie);
            Console.ReadKey();

            foreach (Movie x in movies)
            {
                Console.WriteLine(x.Title);
            }
            Console.ReadKey();



            firstMovie.AddReview("Mediocre", 5);
            firstMovie.AddReview("Amazing", 9);

            secondMovie.AddReview("Amazing", 10);
            secondMovie.AddReview("Really good", 9);
            secondMovie.AddReview("Just Meh", 5);

            thirdMovie.AddReview("Entertaining", 7);


            Console.WriteLine("The average rating of " + firstMovie.Title + " is " + firstMovie.Rating);
            Console.WriteLine("The average rating of " + secondMovie.Title + " is " + secondMovie.Rating);

            //for (int i = 0; i < movies.Count; i++)
            //{
            //    // print another list items.
                
            //    Console.WriteLine( i + ")" + movies[i] + ".");

            //}


            Console.ReadKey();
        }

        //public static class MyClass
        //{

        //    // static method with two parameters
        //    public static long Add(int a, int b)
        //    {
        //        return a + b;
        //    }

        //    // static method with three parameters (method overloading)
        //    public static long Add(int a, int b, int c)
        //    {
        //        return a + b + c;
        //    }

        //}



        public class Movie
        {
            public string Title { get; set; }
            public double Rating { get; set; }
            public long Revenue { get; set; }
            public string Casting { get; set; }
            public List<Review> reviews = new List<Review>();


            public class Review
            {
                public string Comment { get; set; }
                public double Rating { get; set; }
            }


            public void AddReview(string rev, double rat)
            {
                Review newReview = new Review
                {
                    Comment = rev,
                    Rating = rat
                };
                reviews.Add(newReview);

                CalculateAverageRating();
            }


            private void CalculateAverageRating()
            {
                double avg = 0.0;

                foreach (Review rev in reviews)
                {
                    avg = avg + rev.Rating;
                }
                if (reviews.Count > 0)
                {
                    Rating = avg / reviews.Count;
                }
            }
        }


    }


}
