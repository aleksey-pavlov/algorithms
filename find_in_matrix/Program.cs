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

int target = 34;


for (var i = 0; i < matrix.Length; i++)
{
    if (matrix[i][matrix[i].Length - 1] > target)
    {
        var arr = matrix[i];
        var start = 0;
        var end = matrix[i].Length;

        while (start <= end)
        {
            var mid = (start + end) / 2;

            if (arr[mid] == target)
            {
                Console.WriteLine(true);
                break;
            }
            else if (arr[mid] > target)
            {
                end = mid - 1;
            }
            else if (arr[mid] < target)
            {
                start = mid + 1;
            }
        }
    }
}