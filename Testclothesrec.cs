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
                return false;
            }

            string result2 = Program.clothesrec(55);
            if (result2 != "wear warm clothes")
            {
                return false;
            }

            string result3 = Program.clothesrec(63);
            if (result3 != "wear a jacket")
            {
                return false;
            }

            string result4 = Program.clothesrec(77);
            if (result4 != "wear a t-shirt")
            {
                return false;
            }

            string result5 = Program.clothesrec(82);
            if (result5 != "wear shorts")
            {
                return false;
            }

            string result6 = Program.clothesrec(96);
            if (result6 != "Halleluia its very hot. Tank top")
            {
                return false;
            }

            string result7 = Program.clothesrec(102);
            if (result7 != "stay home")
            {
                return false;
            }

            
            

            


            

        return true;
        }
    }
}