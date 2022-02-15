using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    public static class OneNum
    {
        public static List<int> LessEnteredNum(int num)
        {
            var numbers = new List<int>();
            
            for (var i = 2; i < num; i++)
            {
                numbers.Add(i);
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                for (var j = 2; j < num; j++)
                {
                    numbers.Remove(numbers[i] * j);
                }
            }

            return numbers.TakeLast(3).ToList();
        }

        public static List<int> MoreEnteredNum(int num)
        {
            var numbers = new List<int>();
            for (int i = num + 1, count = 0; count < 3; ++i ) {
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
                ++count;
            }
            return numbers;
        }
    }
}