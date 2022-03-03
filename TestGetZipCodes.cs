using System;
using System.Collections.Generic;
using System.IO;

namespace weatherorsomething
{
    class TestGetZipCodes
    {
        public static bool RunTest()
        {   
            // I  want it to check if a list contains the number of things that were supposed to be input.
            // Probably have a input and then tell if they have the right number of things
            //
                List<string> expectedZipCodes = new List<string>();
                expectedZipCodes.Add("90304");
                expectedZipCodes.Add("90201");
                expectedZipCodes.Add("90302");

                Console.WriteLine("Pleas input");
                Console.WriteLine("90304");
                Console.WriteLine("90201");
                Console.WriteLine("90302");

                List<string> results = Program.getZipCodes();   

                if (results.Count != 3)
                {
                    Console.WriteLine($"The list should contain 3 zipcodes but only contains {results.Count}");
                    return false;
                }

                if (!results.Contains("90304")) 
                {
                    Console.WriteLine("This list should contain 90304 but it doesnt");
                    return false;
                }

                if (!results.Contains("90201")) 
                {
                    Console.WriteLine("This list should contain 90201 but it doesnt");
                    return false;
                }

                if (!results.Contains("90302")) 
                {
                    Console.WriteLine("This list should contain 90302 but it doesnt");
                    return false;
                }


                // If list doesnt have 4 things in it
                    {
                        // Console.WriteLine($"It should have {result} things");
                        // return false; 
                    }

                // string result = Program.compare(6);
                // If list doesnt have 6 things in it
                    {
                        // Console.WriteLine($"It should have {result} things");
                        // return false; 
                    }


            return false;
        }
    }
}