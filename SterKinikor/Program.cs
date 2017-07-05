// Funcitons cant be created outside classes

using System;
using System.Collections.Generic;  // Use System.collections for lists 
using System.Threading; 

namespace SterKinikor
{
    class Movie // Creating a new class for Moview objects and define object varuables  
    {
        public string movieName; 
        public int ageRestriction;  
    }

    class Program
    { 
        static int age(int dob)
        {
          var date = (DateTime.Now.Year - dob);  
          return date;  
        }

        static void Main(string[] args)
        {
        // Creating List for movies 
        List <Movie>  movies  = new List <Movie> (); 
        
        //Set Movie Varuables 
        movies.Add(new Movie
        {
            movieName = "Star Wars The Force Awakens",
            ageRestriction = 16,
        });

        movies.Add( new Movie
        {
            movieName = "Frozen", 
            ageRestriction = 10,
        }); 

        movies.Add(new Movie 
        {
            movieName = "Pulp Fiction", 
            ageRestriction = 18, 
        }); 

        movies.Add(new Movie
        {
            movieName = "Debbie Does Dallas", 
            ageRestriction = 21, 
        }); 

        movies.Add(new Movie 
        {
            movieName = "Dirty Harry", 
            ageRestriction = 13, 
        }); 
        
        
            Console.WriteLine("Welcome to Ster Kinekor");
            System.Threading.Thread.Sleep(3000); 
            Console.WriteLine("Please select one of the following movies for your entertainment"); 
            System.Threading.Thread.Sleep(3000);
            

            foreach (Movie movie in movies)
          {
              Console.WriteLine(movie.movieName);
              
          }

          var uservalue = Console.ReadLine

            Console.WriteLine(); 
            Console.ReadKey(); 
        
        }
    
    }

}
