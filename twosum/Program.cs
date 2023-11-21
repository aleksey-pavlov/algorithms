/* https://leetcode.com/problems/two-sum/ */
using TwoSum;

var app = new Solution();

var res1 = app.TwoSum(new int[] { 2, 4, 5, 3 }, 5);

Console.WriteLine(string.Join(", ", res1));


var res2 = app.TwoSum(new int[] { 2, 4 }, 6);

Console.WriteLine(string.Join(", ", res2));