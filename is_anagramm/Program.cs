


/* simple method by order two comparable words */
string word1 = "anagramm";
string word2 = "nagaramm";

bool isAnagramm = true;
if (word1.Length != word2.Length)
{
    isAnagramm = false;
    Console.WriteLine("false");
    return;
}

var arr1 = word1.Order();
var arr2 = word2.Order();

if (!Enumerable.SequenceEqual(arr1, arr2))
{
    isAnagramm = false;
}

Console.WriteLine($"Method1: {isAnagramm}");

/* Method 2 - use dictionary */

Dictionary<char, int> map = new Dictionary<char, int>();
isAnagramm = true;

foreach (var i in word1)
{
    if (!map.TryGetValue(i, out int _))
    {
        map[i] = 1;
    }
    else
    {
        map[i]++;
    }
}

foreach (var i in word2)
{
    if (map.TryGetValue(i, out int _))
    {
        map[i]--;
    }
    else
    {
        isAnagramm = false;
        break;
    }
}

foreach (var i in map)
{
    if (i.Value != 0)
    {
        isAnagramm = false;
        break;
    }
}

Console.WriteLine($"Method2: {isAnagramm}");