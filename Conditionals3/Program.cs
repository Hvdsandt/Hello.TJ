using System;

namespace Conditionals3
{
    class Program
    {
        static void Main(string[] args)
        {
           //  sotck take 

           // More than/Less than operator 
           // > : More than
           // < : Less than 
           // >= : More than or equals 
           // <= : Less than or equals 

           //loop - repeats code 
           //while loop - simplest loop 
           //works like if 
           //while condition is true then execute 

           char exit = 'n'; 

           while (exit == 'n')
            {
                int apples = 20; 
                int bananas = 35; 

                Console.Write("How many apples are in stock?");  //console.write - does not go to new line - readline will input after question 
                string applesString = Console.ReadLine();        // always read lines as string and then convert to data type required 

                Console.Write("How many bananas are in stock?"); 
                string bananaString = Console.ReadLine(); 
                
                apples = Convert.ToInt32(applesString); 
                bananas = Convert.ToInt32(bananaString); 

                int lowStockApples = 10; 
                int lowStockBananas = 15; 

                int highStockaApples = 45; 
                int highStockBananas = 60; 

               if (apples < lowStockApples)
                // bool applelow = (apples < lowStockApples); equivalant 
                // if (applelow == true )
                {
                    Console.WriteLine("Order Apples.");
                }
                else if (apples > highStockaApples)
                {
                    Console.WriteLine("Discount Apples, No re-order"); 
                }
                else
                {
                    Console.WriteLine("Stock is fine");
                } 

                if (bananas < lowStockBananas)
                {
                    Console.WriteLine("Order bananas.");
                }
                else if (bananas > highStockBananas)
                {
                    Console.WriteLine("Discount bananas, No re-order"); 
                }
                else 
                {
                    Console.WriteLine("Stock is fine"); 
                }

                Console.WriteLine("Do you want to exit (y/n): "); 
                exit = Console.ReadKey().KeyChar;
                Console.WriteLine(); 

           
            }
        }
    }
}
