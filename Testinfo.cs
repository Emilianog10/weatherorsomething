using System;
using System.IO;

namespace weatherorsomething
{
    class Testinfo
    {
        public static bool RunTest()
        {    
            Console.WriteLine("You should see the forecast");   

            // TODO(jcollard 2022-02-03): It looks like this method should probably have different parameters.
            // I would suggest the following:
            // public static string info(int days, List<string> report)
            // The first argument should be 1 or 3
            // The second argument is a list containing 3 strings (the weather report for each day).

            // With this method, it becomes a little easier to write the test.
            // What should it do in the following situation:
            
            // List<string> report = new List<string>();
            // report.Add("68F");
            // report.Add("69F");
            // report.Add("66F");
            // string result = Program.info(1, report);

            // What about this:
            
            // string result2 = Program.info(3, report);

            // What are some other situations you could test?
            
            return true;
        }
    }
}