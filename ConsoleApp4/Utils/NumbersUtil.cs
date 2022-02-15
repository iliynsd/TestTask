using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4.Utils
{
    public static class NumbersUtil
    {
        public static List<int> OrderNums(List<string> nums) => nums.Select(num => int.Parse(num)).OrderBy(i=>i).ToList();
    }
}