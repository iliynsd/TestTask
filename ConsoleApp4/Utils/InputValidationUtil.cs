using System.Collections.Generic;

namespace ConsoleApp4.Utils
{
    public static class InputValidationUtil
    {

        public static bool LessThanTwoNums(List<string> numbers) => numbers.Count < 3;

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

        public static bool CorrectEnter(List<string> numbers) => CheckIsNumbers(numbers) && LessThanTwoNums(numbers);
    }
}