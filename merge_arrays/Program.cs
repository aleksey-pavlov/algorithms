// input [1,2,3]  [1,3,4]
// output [1,1,2,3,3,4]
// O(n)

int[] arr1 = [1, 2, 3, 5, 25];
int[] arr2 = [1, 3, 4, 10, 20];

List<int> result = [];


for (int i = 0; i < Math.Max(arr1.Length, arr2.Length); i++)
{
    if (i > arr1.Length - 1)
    {
        result.Add(arr2[i]);
        continue;
    }
    else if (i > arr2.Length - 1)
    {
        result.Add(arr1[i]);
        continue;
    }

    if (arr1[i] >= arr2[i])
    {
        result.Add(arr2[i]);
        result.Add(arr1[i]);

    }
    else
    {
        result.Add(arr1[i]);
        result.Add(arr2[i]);
    }
}


foreach (int i in result)
{
    Console.WriteLine(i);
}
