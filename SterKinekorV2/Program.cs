using System;
using System.Threading; 

namespace SterKinekorV2
{
    class Program
    {
        static int Age(int dob)
        {
            var result = (DateTime.Now.Year - dob); 
            return result; 
        }
        static void Main(string[] args)
        {  
           Console.WriteLine();
           Console.WriteLine("Welcome to Ster Kinekor!"); 
        //    Thread.Sleep(3000); 
           Console.WriteLine("Tonights movie for your enjoyment is Star Wars: The Force Awakens!"); 
        //    Thread.Sleep(3000); 
           Console.WriteLine("The age restriction on tonights movie is 17."); 
        //    Thread.Sleep(3000); 
           Console.WriteLine("Please enter the year you were born."); 

           var restriction = 17; 
           var birthyear = Convert.ToInt32(Console.ReadLine()); 
           Console.WriteLine(birthyear);   
           var dob = Age(Convert.ToInt32(Console.ReadLine())); 
           Console.WriteLine(dob);
                      
           if(dob > restriction)
           {
             Console.WriteLine("One Ticket Admitted!");
            //  Thread.Sleep(3000);
             Console.WriteLine("May the force be with you.");
             Console.ReadLine(); 
           }
           else if (dob < restriction)
           {
            Console.WriteLine("Sorry, you are not old enough to watch this movie.");
            Console.ReadKey();  
           }

        }
    }
}
