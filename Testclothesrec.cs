using System;
using System.IO;

namespace weatherorsomething
{
    class Testclothesrec
    {
        public static bool RunTest()

        {
            string result = Program.clothesrec(49);
            if (result != "stay home")
            {
                // TODO(jcollard 2022-02-03): Add error messages to explain why the test is failing
                Console.Error.WriteLine($"Expected the result to be 'stay home' but it was {result}");
                return false;
            }

            string result2 = Program.clothesrec(55);
            if (result2 != "wear warm clothes")
            {
                Console.Error.WriteLine($"Expected the result to be 'wear warm clothes' but it was {result2}");
                return false;
            }

            string result3 = Program.clothesrec(63);
            if (result3 != "wear a jacket")
            {
                Console.Error.WriteLine($"Expected the result to be 'wear a jacket' but it was {result3}");
                return false;
            }

            string result4 = Program.clothesrec(77);
            if (result4 != "wear a t-shirt")
            {
                Console.Error.WriteLine($"Expected the result to be 'wear a t-shirt' but it was {result4}");
                return false;
            }

            string result5 = Program.clothesrec(82);
            if (result5 != "wear shorts")
            {
                Console.Error.WriteLine($"Expected the result to be 'wear shorts' but it was {result5}");
                return false;
            }

            string result6 = Program.clothesrec(96);
            if (result6 != "Halleluia its very hot. Tank top")
            {
                Console.Error.WriteLine($"Expected the result to be 'Halleluia its veryhot. Tank Top' but it was {result6}");
                return false;
            }

            string result7 = Program.clothesrec(102);
            if (result7 != "stay home")
            {
                Console.Error.WriteLine($"Expected the result to be 'stay home' but it was {result7}");
                return false;
            }

            
            

            


            

        return true;
        }
    }
}