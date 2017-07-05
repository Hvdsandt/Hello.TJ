using System;

namespace Conditionals2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hungryForApples = false;
            bool hungryForMangos = true;

            // AND operator
            // multiplication
            // supposing true = 1 and false = 0
            // true && false equivalent to saying: 1 x 0 = 0
            bool hungryForApplesAndMangos = ((hungryForApples == true) && (hungryForMangos == true));
            //bool hungryForApplesAndMangos = (false && true);
            // 0x1 = 0 -> false

            if (hungryForApplesAndMangos == true)
            {
                Console.WriteLine("Really hungry...");
            }


            // OR operator: ||
            // OR works like +
            // true = 1, false = 0: ANy positive number is TRUE, any 0 is false
            if (hungryForApples == true || hungryForMangos == true)
            {
                Console.WriteLine("You are hungry");
            }

            // NOT operator
            // not negates any boolean value: will make true false and make false true
            if (!hungryForMangos && !hungryForApples)
            {
                Console.WriteLine("You are not hungry");
            }

            if (true)
            {
                // do things
            }

            if (false)
            {
                // this will never happen unless the universe collapses into nonsense
            }

            //bool hungryForApples = false;
            //bool hungryForMangos = true;

            bool hungryForMeat = true;
            if (hungryForApples || hungryForMangos && hungryForMeat)
            {
                Console.WriteLine("Yum");
            }
        }
    }
}