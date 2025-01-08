
var res1 = TwoSum(new int[] { 1, 2, 3, 7, 11, 15 }, 9);

Console.WriteLine(string.Join(", ", res1));


var res2 = TwoSum(new int[] { 3, 2, 4 }, 6);

Console.WriteLine(string.Join(", ", res2));


int[] TwoSum(int[] nums, int target)
{
    if (nums.Length == 2)
        return new int[] { 0, 1 };

    var map = new Dictionary<int, int>();

    for (var i = 0; i < nums.Length; i++)
    {
        map[nums[i]] = i;
    }

    for (var i = 0; i < nums.Length; i++)
    {
        var remind = target - nums[i];

        if (map.TryGetValue(remind, out int left) && left != i)
        {
            return new int[2] { i, left };
        }
    }

    return new int[0];
}