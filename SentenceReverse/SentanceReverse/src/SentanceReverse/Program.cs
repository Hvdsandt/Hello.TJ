using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentanceReverse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filename = @"C:\temp\myTestApp\sentence2.txt";
            var sentence = File.ReadAllText(filename);

            string[] words = sentence.Split(' ');
            string[] newString = new string[words.Length];

            int counter = words.Length; 
             
            for (int i = 0; i < words.Length; i++)
            {
                newString[i] = words[counter -1];
                i++;          
            }

            Console.ReadLine();
        }
    }
}
