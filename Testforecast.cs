using System;
using System.Collections.Generic;
using System.IO;

namespace weatherorsomething
{
    class Testforecast
    {
        public static bool RunTest()
        {   
            // TODO(jcollard 2022-02-03): This method accepts a string as a parameter and returns a list of strings.
            // A single test case would look something like this:

            Console.WriteLine("Testing Forecast.");
            List<string> testResults = Program.forecast("90304");
            
            // Check that the list contains 3 items (the weather for 3 days)
            if (testResults.Count != 3)
            {
                Console.Error.WriteLine("Expected the forecast to produce 3 elements but it has {testResults.Count} elements.");
                return false;
            }

            Console.WriteLine($"Today's weather: {testResults[0]}");
            Console.WriteLine($"Tomorrows's weather: {testResults[1]}");
            Console.WriteLine($"Third Day's weather: {testResults[2]}");
            Console.WriteLine("Does this look correct? Type 'y' if it is correct.");

            string response = Console.ReadLine();
            if (response != "y")
            {
                return false;
            }
            

            // Next, test for a few more zip codes.
            // Finally, what should happen if you give something weird?
            // For example Program.forecast("!!!!@#");
            // Or Program.forecast("90304-0555");
            

            return false;
        }
    }
}

// this is the one i need help with. Hopefully it not to bad. 