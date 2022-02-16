using System.Collections.Generic;

namespace ConsoleApp4.Utils
{
    /// <summary>
    /// This class validates input
    /// </summary>
    public static class InputValidationUtil
    {
        /// <summary>
        /// This method checks if list has more than 3 objects
        /// </summary>
        /// <param name="numbers">This method accepts List of string</param>
        ///<returns>
        /// This method returns true if list has less than 3 objects, false if more than 3 objects 
        /// </returns>
        public static bool LessThanTwoNums(List<string> numbers) => numbers.Count < 3;

        /// <summary>
        /// This method checks if strings in list contains only numbers
        /// </summary>
        /// <param name="numbers">This method accepts List of string</param>
        ///<returns>
        /// This method returns true if strings in list consist only of number 
        /// </returns>
        public static bool CheckIsNumbers(List<string> numbers)
        {
            foreach (var number in numbers)
            { 
                foreach (var sym in number)
                { 
                    if (!int.TryParse(sym.ToString(), out int symb))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// This method checks if entered data is correct
        /// </summary>
        /// <param name="numbers">This method accepts List of string</param>
        ///<returns>
        /// This method returns true if entered data is correct 
        /// </returns>
        public static bool CorrectEnter(List<string> numbers) => CheckIsNumbers(numbers) && LessThanTwoNums(numbers);
    }
}