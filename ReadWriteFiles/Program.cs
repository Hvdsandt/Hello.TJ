using System;
using System.IO; // IO = input/output 

namespace ReadWriteFiles
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "C:\\temp\\myTestApp\\sentence.txt";
            var sentance = File.ReadAllText(fileName); 
            Console.WriteLine(sentance); 

            string outputFile = "C:\\temp\\myTestApp\\outSentence.txt"; 
            File.WriteAllText(outputFile, sentance);  // write all text has 2 paramaters  

            Console.WriteLine("Enter your table name: ");
            string table = Console.ReadLine();

            string sql = "Select * from " + table;

            string sqlFile = "C:\\temp\\myTestApp\\mySql.sql";
            File.WriteAllText(sqlFile, sql); 

            Console.ReadKey();
            
        }
    }
}
