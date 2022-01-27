using System;
using System.Collections.Generic;

namespace weatherorsomething
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }



        /// <summary>
        /// Prompts the user to enter a zip code and validates the text they entered is a 5 digit number. Then, returns the zip code they entered.
        /// </summary>
        /// 
        /// <returns></returns>
        /// 
        public static string NavigationPage()
        {
            // 1. Have a way to write start.
            // 2. If start written the start
            // 3. If not wait till it is. 

            return null;
        }

        // TODO(jcollard 2022-01-27): Write documentation
        // Maybe this method should be "ValidateZipcode(string input)"
        // This method checks that the input is 5 digits long and only contains numbers
        // It returns `true` if the zipcode is valid and `false` if the zipcode is not valid.

        /// <summary>
        /// Given a string to validate, validates it by cheking to see if it 5 charecters long and all chars are numbers. If valid returns true otherwise returns false.
        /// </summary>
        /// <param name="zipToValidate"></param>
        /// <returns></returns>
        public static string ValidateZipcode(string zipToValidate)
        {
            // TODO(jcollard 2022-01-27): Add step-by-step human readable algorithm
            // 1. Takes zipToValidate and reads it
            // 2. Makes sure that it is 5 charecters long.
            // 3. Makes sure that it is only numbers. 
            return null;
        }

        // TODO(jcollard: 2022-01-27): Add remaining method stubs
        /// <summary>
        /// Prompts user to input either "1" for one day forecast or "3" for 3 day forcast. If not "1" or "3" return false. 
        /// </summary>
        /// <returns></returns>
        public static string xnumberofdays()
        {
            // 1. Asks user if they want a 1 day forecast or a 3 day forcast. 
            // 2. If they input 1 show todays forecast (currentDayWeather())
            // 3. If they input 3 show 3 day forecast (forecast()) 
            // 4. If not 1 or 3 return with invalid. 
            return null;
        }

        public static void DisplayWeather()
        {

        }
        /// <summary>
        /// This method is called when the weather is needed. This method contains the forecast for the current day. 
        /// </summary>
        /// <param name="zipToValidate"></param>
        /// <returns></returns>
        public static List<string> forecast(string zipToValidate)
        {
            // 1. Take zipcode (zipToValidate) and input it into WeatherAPI
            // 2. Save the info as a list. 
            return null;
        }
        /// <summary>
        /// This method is called when the weather is needed. This method contains the forecast for the next 3 days. 
        /// </summary>
        /// <param name="zipcode"></param>
        /// <returns></returns>
        public static string currentDayWeather(string zipcode)
        {
            // 1. Take zipcode (zipToValidate) and input it into WeatherAPI
            // 2. Save the info as a list. 
            return null;
        }

    } // Feedback(jcollard 2022-01-27): Moved this curly bracket such that the methods were inside of the class. Methods must be within a class
}
