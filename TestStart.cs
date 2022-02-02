using System;
using System.IO;

namespace weatherorsomething
{
    
    class TestStart
    
    {
        string input;
        public static bool RunTest()
        {
            Console.WriteLine("Input a zipcode. This must be 5 numbers. ");
            string input = Console.ReadLine();
            TestValidateZipcode;
            return false;
        }
    }
}