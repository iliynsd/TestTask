using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp4.Utils;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the direction of search: 0 - straight, 1 - reverse:");
            bool direction = ConverterUtil.ConvertToBool(Convert.ToInt32(Console.ReadLine()));

            List<string> numbers;
            do
            {
                Console.WriteLine("Enter number or two numbers separated by comma:"); 
                numbers = Console.ReadLine().Split(',').ToList();
            } while (!InputValidationUtil.CorrectEnter(numbers));
            
            List<int> resultNums;
            
            if (numbers.Count == 1)
            {
                if (direction)
                {
                    resultNums = OneNum.LessEnteredNum(int.Parse(numbers[0]));
                }
                else
                {
                    resultNums = OneNum.MoreEnteredNum(int.Parse(numbers[0]));
                }
            }
            else
            {
                if (direction)
                {
                    resultNums = TwoNums.GetThreeNums(numbers).TakeLast(3).ToList();
                }
                else
                {
                    resultNums = TwoNums.GetThreeNums(numbers).Take(3).ToList();
                }
            }

            if (resultNums.Count < 3)
            {
                Console.WriteLine("Not found or find less than three nums");
            }
            else
            {
                resultNums.ForEach(Console.WriteLine);
            }
        }
    }
}