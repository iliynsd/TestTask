using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp4.Utils;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
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
                    resultNums = LessEnteredNum(int.Parse(numbers[0]));
                }
                else
                {
                    resultNums = MoreEnteredNum(int.Parse(numbers[0]));
                }
            }
            else
            {
                if (direction)
                {
                    resultNums = GetThreeNums(numbers).TakeLast(3).ToList();
                }
                else
                {
                    resultNums = GetThreeNums(numbers).Take(3).ToList();
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

            Menu();
        }
        
        /// <summary>
        /// This method returns three simple nums in range 
        /// </summary>
        /// /// <param name="nums">This method accepts list of string</param>
        ///<returns>
        /// This method returns List of int with three simple nums 
        /// </returns>
        public static List<int> GetThreeNums(List<string> nums)
        {
            var convNums = NumbersUtil.OrderStringNumsByIncrease(nums);

            var numbers = new List<int>();
            for (int i = convNums[0] + 1; i<convNums[1]; ++i )
            {
                bool simple = false;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        simple = true;
                    }
                }

                if (simple)
                {
                    continue;
                }
                
                numbers.Add(i);
            }
            return numbers;
        }
        /// <summary>
        /// This method gives three simple nums less than entered
        /// </summary>
        /// <param name="num">This method accepts int value</param>
        ///<returns>
        /// This method returns List of int with three simple nums 
        /// </returns>
        public static List<int> LessEnteredNum(int num)
        {
            var numbers = new List<int>();
            for (int i = num - 1, count = 0; count < 3; --i ) {
                bool simple = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        simple = false;
                    }
                }

                if (!simple)
                {
                    continue;
                }
                
                numbers.Add(i);
                ++count;
            }
            return numbers;
        }

        /// <summary>
        /// This method gives three simple nums more than entered
        /// </summary>
        /// <param name="num">This method accepts int value</param>
        ///<returns>
        /// This method returns List of int with three simple nums 
        /// </returns>
        public static List<int> MoreEnteredNum(int num)
        {
            var numbers = new List<int>();
            for (int i = num + 1, count = 0; count < 3; ++i ) {
                bool simple = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        simple = false;
                    }
                }

                if (!simple)
                {
                    continue;
                }
                
                numbers.Add(i);
                ++count;
            }
            return numbers;
        }
        
        /// <summary>
        /// This method represents main menu to restart or exit program
        /// </summary>
        public static void Menu()
        {
            Console.WriteLine("Enter 'restart' - to restart program or 'exit' to exit program:");
            var command = Console.ReadLine();
            if (command == "restart")
            {
                Main();
            }
            else if (command != "exit")
            {
                Menu();
            }
        }
    }
}