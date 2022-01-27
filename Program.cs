using System;

namespace weatherorsomething
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }



        /// <summary>
        /// This is bassicly the first part of the program where the user has to write start for the program to continue. 
        /// 
        /// TODO(jcollard: 2022-01-27): With comments, try to use the following format:
        ///     "Given {variable-name} and {variable-name}, describe the action being performed. Then, returns {describe return-type}"
        /// 
        ///     Because this method does not have any parameters, you can skip the "Given" part. This methods comment should probably be something like this:
        ///     "Prompts the user to enter a zip code and validates the text they entered is a 5 digit number. Then, returns the zip code they entered."
        /// 
        /// </summary>
        /// 
        /// <returns></returns>
        /// 
        public static string NavigationPage()
        {
            // 1. Have a way to write start.
            // 2. If start writen the start
            // 3. If not wait till it is. 

            return null;
        }

        // TODO(jcollard 2022-01-27): Write documentation
        // Maybe this method should be "ValidateZipcode(string input)"
        // This method checks that the input is 5 digits long and only contains numbers
        // It returns `true` if the zipcode is valid and `false` if the zipcode is not valid.
        public static string Zipcode()
        {
            // TODO(jcollard 2022-01-27): Add step-by-step human readable algorithm
            return null;
        }

        // TODO(jcollard: 2022-01-27): Add remaining method stubs

    } // Feedback(jcollard 2022-01-27): Moved this curly bracket such that the methods were inside of the class. Methods must be within a class
}
