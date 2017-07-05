using System;

namespace Conditionals2
{
    class Program
    {
        static void Main(string[] args)
        {
           // boolian logic 
           // can create complex if statements 
           bool hungryForApples = false; 
           bool hungryForMangos = true;  

           if (hungryForApples == true && hungryForMangos == true) // && and opertator - allows multiple if statements  
            {
            Console.WriteLine("I'm really hungry"); 
            }


            if (hungryForApples == true || hungryForMangos == true) // || or operator 
            {
                Console.WriteLine("you are hungry"); 
            }

            // 

        }
    }
}
