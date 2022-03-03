using System;
using System.Collections.Generic;

namespace TwoSum
{
    internal class Program
    {
        //  Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        //  You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //  You can return the answer in any order.
        static void Main(string[] args)
        {
            Console.WriteLine("Array of ints: ");
            //int[] nums = Console.ReadLine();
        }

        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return Array.Empty<int>();
        }

        public int[] JustThoughts(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int leftOver = target - nums[i];

                //This is a problem if there are two equal values in the array
                //Also a problem if the value doesn't exist in the array
                //could also drop the value that was checked?
                //Or simply ignore the value checked
                if (Array.Find(nums, element => element == leftOver) + nums[i] == target && leftOver != nums[i])
                {
                    return new int[] { nums[i], leftOver };
                }
            }

            return Array.Empty<int>();
        }
    }
}
