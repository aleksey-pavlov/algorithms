
// input: [[2,6], [1,3], [8,10], [18,25]]
// out: [[1,6], [8,10], [18,25]]

int[][] intervals = [[2, 6], [1, 3], [8, 10], [18, 25]];
intervals = intervals.OrderBy(s => s[0]).ToArray();
/*
[[1, 3], [2, 6], [8, 10], [18, 25]]
*/

int[][] result = [intervals[0]];

for (var i = 1; i < intervals.Length; i++) {

    var last = result.Last();
    if ( last[1] >= intervals[i][0] ) {
        last[1] = Math.Max(last[1], intervals[i][1]);
    } else {
        result = result.Append(intervals[i]).ToArray();
    }
}


foreach (var i in result)
{
    Console.WriteLine($"[{i[0]}, {i[1]}]");
}