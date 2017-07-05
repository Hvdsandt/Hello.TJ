using System;

namespace Calc_Function
{
    class Program
    {
        static int calc(int x, int y) 
        {
         
         var result = (x*y)+1; 
         return result; 

        }
        static void Main(string[] args)
        {
           var r1 = calc(5,10); 
           var r2 = calc(3,9); 
           var r3 = calc(5,3); 


           Console.WriteLine("Please select A, B or C.. "); 
           
            var uservalue1 = Console.ReadLine();
            
            Console.WriteLine();
            if(uservalue1 == "A")
            {
                Console.WriteLine("You chose.. " + r1); 
            }             
            else if(uservalue1 == "B")
            {
                Console.WriteLine("You chose.. " + r2);
            }
            else if(uservalue1 == "C")
            {
                Console.WriteLine("You chose.. " + r3); 
            }
            else 
            {
                Console.WriteLine("you dumb, thats not what I said... Try again.. "); 
            }
           Console.WriteLine(); 


           Console.WriteLine("Please select again.. ");
           var uservalue2 = Console.ReadLine(); 

           Console.WriteLine(); 
            if(uservalue2 == "A")
            {
                Console.WriteLine("You chose.. " + r1); 
            }             
            else if(uservalue2 == "B")
            {
                Console.WriteLine("You chose..  " + r2);
            }
            else if(uservalue2 == "C")
            {
                Console.WriteLine("You chose.. " + r3); 
            }
            else 
            {
                Console.WriteLine("Not again... You suck..."); 
            }
           Console.WriteLine(); 
           
           Console.WriteLine("Noice, now lets add them together"); 
           Console.WriteLine(); 
           
           Console.WriteLine(uservalue1 + uservalue2);  

        }
    }

}
