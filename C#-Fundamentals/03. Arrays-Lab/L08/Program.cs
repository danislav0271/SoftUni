using System;
using System.Linq;

namespace L08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstLength = nums.Length - 1;

            for (int i = 0; i < firstLength; i++)
            {
                int[] condensed = new int[nums.Length - 1];
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    condensed[j] = nums[j] + nums[j + 1];
                }
                nums = condensed;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
