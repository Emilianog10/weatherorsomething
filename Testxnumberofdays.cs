using System;
using System.IO;

namespace weatherorsomething
{
    class Testxnumberofdays
    {
        public static bool RunTest()
        {       
            Console.WriteLine("You will be promted to enter 1 or 3");
            Console.WriteLine("Type in the letter 'a'. This should result in 'Invalid'");
            Console.WriteLine("Type in the number 5. This should result in 'Invalid'");
            Console.WriteLine("Type in the number 1. ");

            string result6 = Program.xnumberofdays(1); // I dont know whats wrong sorry.
            if (result6 != "valid")
            {
                return false;
            }

            string result7 = Program.xnumberofdays(3);
            if (result7 != "valid")
            {
                return false;
            }

            string result8 = Program.xnumberofdays(999);
            if (result8 != "invalid")
            {
                return false;
            }

            string result9 = Program.xnumberofdays(2);
            if (result9 != "invalid")
            {
                return false;
            }

            string result10 = Program.xnumberofdays(45);
            if (result10 != "invalid")
            {
                return false;
            }
            
            string result11 = Program.xnumberofdays(8);
            if (result11 != "invalid")
            {
                return false;
            }
            
                       
            return false;
        }
    }
}