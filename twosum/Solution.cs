using System;
using System.Collections.Generic;
using System.Linq;


namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length == 2 && nums.Sum() == target)
                return new int[] { 0, 1 };

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                    var sum = nums[i] + nums[j];

                    if (i != j && sum == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[0];
        }
    }
}