using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4.Utils
{
    /// <summary>
    /// This class works with list of strings
    /// </summary>
    public static class NumbersUtil
    {
        /// <summary>
        /// This method converts List of string in list of int and order by ascending
        /// </summary>
        /// <param name="nums">This method accepts List of string</param>
        ///<returns>
        /// This method returns list of int 
        /// </returns>
        public static List<int> OrderStringNumsByIncrease(List<string> nums) => nums.Select(num => int.Parse(num)).OrderBy(i=>i).ToList();
    }
}