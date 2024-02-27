
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

            var left = 0;
            for (var right = nums.Length - 1; left < right;)
            {
                if (nums[right] >= target)
                {
                    right--;
                    continue;
                }

                var sum = nums[left] + nums[right];

                if (sum < target)
                {
                    left++;
                }
                else if (sum > target)
                {
                    right--;
                }
                else
                {
                    return new int[] { left, right };
                }
            }

            return new int[0];
        }
    }
}