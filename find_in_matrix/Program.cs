/*

Find target in matrix:

Input:
[
    [1,3,5,7],
    [10,11,16,20],
    [23,30,34,60]
];

target = 3;

Output: true

*/

// wrost O(n log n)
// best O(log n)

int[][] matrix = [
    [1,3,5,7],
    [10,11,16,20],
    [23,30,34,60]
];

int target = 16;

var start = 0;
var end = matrix.Length * matrix[0].Length - 1;

while (start <= end)
{
    var mid = (start + end) / 2;
    var current = matrix[mid /  matrix[0].Length][mid % matrix[0].Length];

    if (current == target)
    {
        Console.WriteLine(true);
        break;
    }
    else if (current > target)
    {
        end = mid - 1;
    }
    else if (current < target)
    {
        start = mid + 1;
    }
}

