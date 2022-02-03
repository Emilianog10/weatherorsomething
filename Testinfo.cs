using System;
using System.IO;

namespace weatherorsomething
{
    class Testinfo
    {
        public static bool RunTest()
        {    
            Console.WriteLine("You should see the forecast");   

            bool result = Program.info(day);// i dont know if this is right exactly but i think its easy enough to fix with you tommorow
            if (result = "true")
            {
                return false;
            }

            string result2 = Program.info(day);// i dont know if this is right exactly but i think its easy enough to fix with you tommorow
            if (result2 != "Here is you weather : Today it is 10 degrees, tommorow it will be 30 degrees, and the day after tommorow it will 20002 degrees.")
            {
                return false;
            }

            return true;
        }
    }
}