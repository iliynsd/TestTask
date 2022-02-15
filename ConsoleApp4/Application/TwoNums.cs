using System.Collections.Generic;
using ConsoleApp4.Utils;

namespace ConsoleApp4
{
    public static class TwoNums
    {
        public static List<int> GetThreeNums(List<string> nums)
        {
            var convNums = NumbersUtil.OrderNums(nums);

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
    }
}