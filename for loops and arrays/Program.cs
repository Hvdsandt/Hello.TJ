using System;

namespace for_loops_and_arrays
{
    class Program
    {
        static void Main(string[] args)
        // Arrays  
        // can only store data type with is declared in array i.e. int in int and string in string 
        // arrays have fixed size 
        // All arrays start count on 0. 

        //For loop 
        // has 3 components , variable decleration; termination condition, increment. 


        {
            int [] myArray = new int[] {1,2,3};  

            int [] arrB = new int [3];

            Console.WriteLine(myArray[1]);

            for (int i = 0; i < 3; i++) 

            {
                Console.WriteLine("Index: " + i.ToString() + "Value: " + myArray[i].ToString()); 
            } 
            Console.ReadKey(); 
        }
    }
}
