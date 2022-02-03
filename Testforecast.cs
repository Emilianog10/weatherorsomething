using System;
using System.IO;

namespace weatherorsomething
{
    class Testforecast
    {
        public static bool RunTest()
        {   
            string result = Program.forecast(90304);
            if (result != "The weather is 80 degrees." && Weather)
            {
                return false;
            }

            string result2 = Program.forecast(90304);
            if (WeatherAPI != true)
            {
                return false;
            }


            return false;
        }
    }
}

// this is the one i need help with. Hopefully it not to bad. 