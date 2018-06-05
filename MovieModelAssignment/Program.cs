using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieModelAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Movie Representaion");
            Console.WriteLine("==============================");
            Console.WriteLine("");

            //=====Create Movie List=====//
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

            Movie fourthMovie = new Movie
            {
                Title = "Deadpool 2",
                Rating = 0,
                Revenue = 254506035,
                Casting = "	Ryan Reynolds, Josh Brolin, Morena Baccarin"
            };

            Movie fifthMovie = new Movie
            {
                Title = "Eragon",
                Rating = 0,
                Revenue = 75030163,
                Casting = "	Ed Speleers, Jeremy Irons,	John Malkovich"
            };

            Movie sixthMovie = new Movie
            {
                Title = "The Notebook",
                Rating = 0,
                Revenue = 81001787,
                Casting = "	Ryan Gosling, Rachel McAdams"
            };

            Movie seventhMovie = new Movie
            {
                Title = "Ted",
                Rating = 0,
                Revenue = 218815487,
                Casting = "Mark Wahlberg, Mila Kunis, Seth MacFarlane"
            };

            Movie eighthMovie = new Movie
            {
                Title = "Avengers Infinity Wars",
                Rating = 0,
                Revenue = 643006211,
                Casting = "Robert Downey Jr., Chris Pratt, Chris Evans, Scarlett Johansson"
            };

            Movie ninethMovie = new Movie
            {
                Title = "Gringo",
                Rating = 0,
                Revenue = 5969853,
                Casting = "Joel Edgerton, Charlize Theron, David Oyelowo"
            };

            Movie tenthMovie = new Movie
            {
                Title = "Pulp Fiction",
                Rating = 0,
                Revenue = 107928762,
                Casting = "	Samuel L. Jackson, John Travolta, Uma Thurman"
            };

            movies.Add(firstMovie);
            movies.Add(secondMovie);
            movies.Add(thirdMovie);
            movies.Add(fourthMovie);
            movies.Add(fifthMovie);
            movies.Add(sixthMovie);
            movies.Add(seventhMovie);
            movies.Add(eighthMovie);
            movies.Add(ninethMovie);
            movies.Add(tenthMovie);
            Console.ReadKey();

            //=====Print Movie List as is=====//
            Console.WriteLine("Movie List: ");
            foreach (Movie x in movies)
            {
                Console.WriteLine(x.Title);
            }
            
            //=====Add comments and reviews to each movie=====//
            firstMovie.AddReview("Mediocre", 6);
            firstMovie.AddReview("Pretty good", 7);

            secondMovie.AddReview("Amazing", 10);
            secondMovie.AddReview("Really good", 9);
            secondMovie.AddReview("Just Meh", 5);

            thirdMovie.AddReview("Entertaining", 7);

            fourthMovie.AddReview("Incredible", 10);
            fourthMovie.AddReview("Loved it", 9);

            fifthMovie.AddReview("Book masacre", 3);
            fifthMovie.AddReview("Awful", 2);

            sixthMovie.AddReview("Beautiful", 9);
            sixthMovie.AddReview("Cry Me a River", 2);

            seventhMovie.AddReview("Hilarious" , 8);
            seventhMovie.AddReview("Very Funny", 7);

            eighthMovie.AddReview("Best SuperHero movie ever", 10);

            ninethMovie.AddReview("Just ok", 6);
            ninethMovie.AddReview("Dull", 5);

            tenthMovie.AddReview("Masterpiece", 10);
            tenthMovie.AddReview("Movie of the cecntury ", 10);
            tenthMovie.AddReview("Overrated", 6);

            Console.ReadKey();

            //=====Print average rating for each movie=====//
            Console.WriteLine("");
            foreach (Movie x in movies)
            {
                Console.WriteLine("The average rating of " + x.Title+ " is: " + x.Rating);
            }
            Console.ReadKey();

            //=====Sort and print movie list by average Rating=====//
            var i = 1;
            List<Movie> SortedByRating = movies.OrderByDescending(obj => obj.Rating).ToList();
            Console.WriteLine("");
            Console.WriteLine("Sorted Movie List by Rating: ");
            foreach (Movie x in SortedByRating)
            {
                Console.WriteLine(i + ") " +x.Title+ ": " + x.Rating);
                i++;
            }
            
            Console.ReadKey();
            
        }



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
