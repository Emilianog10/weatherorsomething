// using System;
// using System.IO;
// // Hopefully this is right? I think what i need to do is make a actull code but no this is a test.
// namespace weatherorsomething
// {
//     class TestValidateZipcode
//     {
//         public static bool RunTest()
//         {
//             Console.WriteLine("You should see  'not valid' if the zipcode is not valid.");
//             Console.WriteLine("You should see 'thank you' if the zipcode is valid");    

//             string result = Program.ValidateZipcode("jfjfjf");
//             if (result != "Invalid")
//             {
//                 return false;
//             }

//             string result2 = Program.ValidateZipcode("11111");
//             if (result2 != "Valid")
//             {
//                 return false;
//             }

//             string result3 = Program.ValidateZipcode("1f2f4f");
//             if (result3 != "Invalid")
//             {
//                 return false;
//             }
            
//             string result4 = Program.ValidateZipcode("jfjfjf");
//             if (result4 != "Invalid")
//             {
//                 return false;
//             }
            
//             string result5 = Program.ValidateZipcode("12345");
//             if (result5 != "valid")
//             {
//                 return false;
//             }
//             return true;
//         }
//     }
// }