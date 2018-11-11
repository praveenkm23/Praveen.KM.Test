using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dotNetTechChallenge.Controllers
{
    public class ConversionController : ApiController
    {
        /// <summary>
        /// HTTP Get method to convert the input number into words.
        /// </summary>
        /// <param name="number">Decimal value</param>
        /// <returns></returns>
        [HttpGet]
        public string ConvertToWords(decimal number)
        {
            // Check if the number is Zero. Return if True.
            if (number == 0)
                return "zero";

            // Check if the number is a negative value. Convert the Absolute value if True
            if (number < 0)
                return "minus " + ConvertToWords(Math.Abs(number));

            // Split the input number into Integer and Fractions. 
            int intPortion = (int)number;
            decimal fraction = (number - intPortion) * 100;
            int decPortion = (int)fraction;

            string words = string.Empty;

            // Convert the Integer portion into Words
            words = NumberToWords(intPortion) + " dollars";
            
            // Convert the fraction into words if exists
            if (decPortion > 0)
            {
                // Concatenate string to indicate currency values
                words += " and ";
                words += NumberToWords(decPortion);
                words += " cents";
            }

            // Return the result
            return words;
        }

        /// <summary>
        /// Private method to convert the Int value to Words
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static string NumberToWords(int number)
        {
            // Check if the number is Zero. Return if True.
            if (number == 0)
                return "zero";
            
            string words = string.Empty;

            // Check the input value for Million's value
            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            // Check the input value for Thousand's value
            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            // Check the input value for Hundred's value
            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            // If the number is less than hundred
            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                // Create reference arrarys for Units and Tens mapping arrays.
                var unitsMapArray = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMapArray = new string[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                // Convert the number based on the reference arrays
                if (number < 20)
                    words += unitsMapArray[number];
                else
                {
                    words += tensMapArray[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMapArray[number % 10];
                }
            }

            return words;
        }
    }
}
