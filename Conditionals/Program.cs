using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 45;
            double b = 23.65;
            decimal c = 345.0M;
            float d = 0.0f;
            string e = "Hello everyone";
            bool f = false;  
            long g = 123456789; 
            
             // b = c; //cannot implicit convert data types

            
            // if statement will not writeline as bool value "f" is false. 
            if (f == true)  
            {// scope area 
             Console.WriteLine("hi there"); 
            }  

            // if conditional with else clause. 
            bool justinhasbananas = false; 
            if (justinhasbananas == true)
            {
                Console.WriteLine("Hey Justin, can I have some bananas"); 
            }
            else  
            //cannot have anything between an if and an else. 
            //cannot have an else statement with no if statement. 
            {
                Console.WriteLine("I'm disappointed that you have no bananas");  
            }

        }
    }
}




/* Conditionals and Data Types

// C# is a strongly typed language. 
// php is a weakly typed language. 

    data types 
            // signed values are positive and negative 
            // unsigned is positive 

    int
    long - bigint
    string - text 
    double - "Decimals"
    decimal - Decimals  // M always indicate it should be a decimal  
    float - 
    bool - only 2 values (True or false) - 2 bits 

    int32 - allocate 32 bits in memory 
    i.e. 
    int a = 1 
     
//if statements - Conditional 

== is a conditional operator 


 */
