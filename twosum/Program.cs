/* https://leetcode.com/problems/two-sum/ */
using TwoSum;

var app = new Solution();

var res1 = app.TwoSum(new int[] { 1, 2, 3, 7, 11, 15 }, 9);

Console.WriteLine(string.Join(", ", res1));


var res2 = app.TwoSum(new int[] { 2, 4 }, 6);

Console.WriteLine(string.Join(", ", res2));