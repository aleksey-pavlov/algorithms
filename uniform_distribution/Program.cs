var sum = 20;
var chunks = 5;

if (sum % chunks > 0)
{
    throw new Exception($"sum should be {sum - sum % chunks}");
}

var middle = sum / chunks;
var chunksMid = chunks / 2;
List<int> result = new List<int>();

for (var i = 0; i < chunks; i++)
{
    if (i < chunksMid)
    {
        result.Add(middle + (chunksMid - i));
    }
    else if (i > chunksMid)
    {
        result.Add(middle - (i - chunksMid));
    }
    else
    {
        result.Add(middle);
    }
}

/* 6 5 4 3 2 */
foreach (var i in result)
{
    Console.WriteLine($" - {i} - ");
}

