using System;

namespace Word_count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your sentance: ");
            string sentance = Console.ReadLine(); 

            sentance = sentance.Trim(); 

            //Split sentance by spaces 
            string[] words = sentance.Split(' ');

            // get the words array length 
            int numberOfWords = words.Length; 

            Console.WriteLine("There are " + numberOfWords + " words in your sentance."); 
            Console.ReadKey();   
        }
    }
}
