using System;
using System.Collections.Generic;

namespace weatherorsomething
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Checks if the user added a command line argument 
            // // Also checks if the first argument is "test"
            // if (args.Length > 0 && args[0] == "test")
            // {
            //     TestAll();
            //     return; // Exits the program
            // }

            // Otherwise, the program continues executing
            while (true)
            {
                Console.WriteLine("Please input a 5 digit zipcode:");
                string zipcode1 = Console.ReadLine();
                Console.WriteLine($"Is this right: {zipcode1}. If this is right, write y.");
                string rightowrong = Console.ReadLine();
                if (rightowrong == "y")
                {
                    if (ValidateZipcode(zipcode1) == true)
                    {
                        List<string> results = forecast(zipcode1);
                        // results.ForEach(Console.WriteLine);
                        foreach(string result in results)
                        {
                            Console.WriteLine(result);
                        }
                        return;
                    }
                    else if (ValidateZipcode(zipcode1) == false)
                    {
                        Console.WriteLine("Type zipcode again:");
                    }
                }
                else
                {
                    Console.WriteLine("Type it again:");
                }
            }
            // TODO(jcollard 2022-02-10): Write a program that asks the user to input a zip code.
            // Then, call forecast with the users input
            // Then, write a foreach loop which displays the 3 day forecast


        }

        public static void TestAll()
        {
            // bool testStart = TestStart.RunTest();
            // Console.WriteLine($"Test TestStart(filename): {testStart}");

            // bool testValidateZipcode = TestValidateZipcode.RunTest();
            // Console.WriteLine($"Test TestValidateZipcode(filename): {testValidateZipcode}");

            bool testforecast = Testforecast.RunTest();
            Console.WriteLine($"Test TestForecast(filename): {testforecast}");

            // bool testinfo = Testinfo.RunTest();
            // Console.WriteLine($"Test Testinfo(filename): {testinfo}");

            // bool testxnumberofdays = Testxnumberofdays.RunTest();
            // Console.WriteLine($"Test Testxnumberofdays(filename): {testxnumberofdays}");

            // bool testclothesrec = Testclothesrec.RunTest();
            // Console.WriteLine($"Test Testclothesrec(filename): {testclothesrec}");



        }


        /// <summary>
        /// Prompts the user to enter a zip code and validates the text they entered is a 5 digit number. Then, returns the zip code they entered.
        /// </summary>
        /// 
        /// <returns>if the zipcode is valid or not</returns>
        /// 
        public static string start()
        {
            // Feedback(jcollard 2022-01-30): I don't understand what this
            // method is doing. Rethink your step-by-step algorithm here and
            // think about how someone who doesn't understand your program will
            // understand it.

            // 1. Prompts user to input zipcode. 
            // 2. Runs (ValidateZipcode(string method))
            // run (xnumberofdays)


            return null;
        }

        // TODO(jcollard 2022-01-27): Write documentation
        // Maybe this method should be "ValidateZipcode(string input)"
        // This method checks that the input is 5 digits long and only contains numbers
        // It returns `true` if the zipcode is valid and `false` if the zipcode is not valid.

        /// <summary>
        /// Given a string to validate, validates it by cheking to see if it 5 charecters long and all chars are numbers. If valid returns true otherwise returns false.
        /// </summary>
        /// <param name="input">zipcode</param>
        /// <returns>if the zipcode is valid or not</returns>
        public static bool ValidateZipcode(string input)
        {
            // TODO(jcollard 2022-01-27): Add step-by-step human readable algorithm
            // 1. Takes zipToValidate and reads it
            // 2. Makes sure that it is 5 charecters long.
            // 3. Makes sure that it is only numbers. 
            // 4. If all parameters are met, then return the zipcode as valid, if not all the paramaters are met, then return invalid. 

            foreach (char c in input)
            {
                if (char.IsDigit(c) == false)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Prompts user to input either "1" for one day forecast or "3" for 3 day forcast. If not "1" or "3" return false. 
        /// </summary>
        /// <returns>if the input was valid</returns>
        public static string xnumberofdays(int numdays)
        {
            // 1. ask for input of ether 1 or 3
            // If the input is not 1 or 3 return false.
            // If 1 set "day" = true(this will be used when deciding what to show later on)
            // run (info)



            return null;
        }

        /// <summary>
        /// This method is called when the weather is needed. This method contains the forecast for the next 3 days.  
        /// </summary>
        /// <param name="input">this is the zipcode that was imputed</param>
        /// <returns>this should return the weather in a list/string</returns>
        public static List<string> forecast(string input)
        {

            // TODO(jcollard 2022-02-10): You need to check that input is a 5 digit zipcode
            // Something like:

            if (input.Length != 5)
            {
                // What do you do if the zip is not 5 characters?
            }

            if (int.TryParse(input, out int asNum) == false)
            {
                // What do you do if the zip is not a number?
            }

            // 1. Take zipcode (zipToValidate) and input it into WeatherAPI
            // 2. Save weather for current day in (currentday)
            // 3. Save weather for today and next 3 days in (moredays)
            // 4. Save the info as a list. 
            List<string> forecast;
            List<string> forecast1;
            forecast = new List<string>();
            forecast1 = new List<string>();
            Weather weather = new WeatherAPI().GetWeather(input);

            string date0 = weather.ForecastData[0]["date"];
            string high0 = weather.ForecastData[0]["maxtemp_f"];
            forecast.Add($"Forecast {date0} High: {high0}");
            forecast1.Add($"Forecast {date0} High: {high0}");

            string date1 = weather.ForecastData[1]["date"];
            string high1 = weather.ForecastData[1]["maxtemp_f"];
            forecast.Add($"Forecast {date1} High: {high1}");

            string date2 = weather.ForecastData[2]["date"];
            string high2 = weather.ForecastData[2]["maxtemp_f"];
            forecast.Add($"Forecast {date2} High: {high2}");


            // forecast.Add("Forecast string");
            return forecast;
        }

        /// <summary>
        /// DIsplays info
        /// </summary>
        /// <param name="days"></param>
        /// <param name="report"></param>
        /// <returns></returns>
        public static string info(int days, List<string> report)
        {
            // 1. Check if "day" is equal to true. 
            // 2. If true show (currentday)
            // 3. If false run (moredays).
            // 4. Then run (clothesrec)
            return null;

        }
        /// <summary>
        /// This method should try to recommend what the user should wear based on what the weather is. 
        /// </summary>
        /// <param name="weather">A recording of what the weather is</param>
        /// <returns>a recomendation of clothes</returns>
        public static string clothesrec(int temperatue)
        {
            //TODO(jcollard 2022-01-30): This method probably needs to take in a
            //Weather object. How will it know what to say? What do the if
            //statements look like?


            // 1. Read the (weather)
            // 2. Input a list of sorts where the system reads the weather and then uses the info to recommend a set of clothes. 
            // 3. If 0-60; stay home
            // 4. If 60-70; wear warm clothes
            // 5. If 70-80; wear a jacket
            // 6. If 80-90; wear a t-shirt
            // 7. If 90-100; wear shorts
            // 8. If 100-150; stay home
            return null;
        }



    } // Feedback(jcollard 2022-01-27): Moved this curly bracket such that the methods were inside of the class. Methods must be within a class
}
