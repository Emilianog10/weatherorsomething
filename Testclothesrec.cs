using System;
using System.IO;

namespace weatherorsomething
{
    class Testclothesrec
    {
        public static bool RunTest()

        {
            if(weather < 50)
            {
            Console.Error.WriteLine("You should stay home. You will freeze");
            }

            else if(weather > 49 && weather < 60)
            {
                Console.Error.WriteLine("You should wear very warm clothes. Like a blanket that doubles as a sweater.");
            }

            else if(weather > 59 && weather < 70)
            {
                Console.WriteLine("You should wear a multiple layers. Like a sweater and a jacket. ");
            }

            else if(weather > 69 && weather < 80)
            {
                Console.WriteLine("Only need a light jacket maybe even a t-shirt");
            }

            else if(weather > 79 && weather < 90)
            {
                Console.WriteLine("You should wear a t-shirt and some jeans.");
            }

            else if(weather > 89 && weather < 100)
            {
                Console.WriteLine("You should wear shorts");
            }

            else if(weather > 99)
            {
                Console.WriteLine("Stay home. Too hot");
            } 

        return false;
        }
    }
}