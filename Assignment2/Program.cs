using System;
using System.Threading; 

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "1) Chicken Soup";
            string num2 = "2) Brown Goo"; 
            string num3 = "3) Generic Dessert";  

            Console.WriteLine("Welcome to my restaurant.");
            Thread.Sleep(1000); 
            Console.WriteLine("Please provide your name and surname.");
            Thread.Sleep(1000);  
            string Username = Console.ReadLine(); 
            Thread.Sleep(1000);
            
            Console.WriteLine("On the menu today is.. ");
            Thread.Sleep(1000);              
            Console.WriteLine(num1); 
            Thread.Sleep(1000);  
            Console.WriteLine(num2);  
            Thread.Sleep(1000);  
            Console.WriteLine(num3);  
            Thread.Sleep(1000);  

            char exit = 'n'; 

            while (exit == 'n')
            {
                Console.Write("Please place your order."); 
                string UserOrder = Console.ReadLine(); 
                var orderName = ""; 
                if (UserOrder == "1")
                {
                    orderName = num1;
                }
                if (UserOrder == "2")
                {
                    orderName = num2;   
                }
                if (UserOrder == "3")
                {
                    orderName = num3;   
                }
                    Console.WriteLine("You ordered " + orderName);  
                    Thread.Sleep(1000);                  

                Console.Write("Is this order correct? (y/n): "); 
                exit = Console.ReadKey().KeyChar; 
                Console.WriteLine(); 
            }

            Console.WriteLine("Thank you for your order " + Username); 

        }
    }
}
