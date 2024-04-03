
using System.Data;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length < 2)
                return new int[0];

            if (nums.Length == 2 && nums.Sum() == target)
                return new int[] { 0, 1 };

            var map = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                map[nums[i]] = i;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    continue;
                }

                var remind = target - nums[i];

                if (map.TryGetValue(remind, out int left) && left != i)
                {
                    return new int[2] { i, left };
                }
            }

            return new int[0];
        }
    }
}