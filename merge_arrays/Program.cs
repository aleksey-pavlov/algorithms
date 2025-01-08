// input [1,2,3]  [1,3,4]
// output [1,1,2,3,3,4]
// O(n)

int[] arr1 = [1, 2, 3, 5, 25];
int[] arr2 = [1, 3, 4, 10, 20];

int[] result = new int[arr1.Length + arr2.Length];

int iter1 = 0;
int iter2 = 0;
int index = 0;

while (index < arr1.Length + arr2.Length)
{
    if (iter1 > arr1.Length - 1 && iter2 <= arr2.Length - 1)
    {
        result[index] = arr2[iter2++];
    } 
    else if (iter2 > arr2.Length - 1 && iter1 <= arr1.Length - 1)
    {
        result[index] = arr1[iter1++];
    } 
    else if (arr1[iter1] < arr2[iter2])
    {
        result[index] = arr1[iter1++];
    }
    else
    {
        result[index] = arr2[iter2++];
    }

    index++;
}

Console.WriteLine("Merged arrays:");
foreach (int i in result)
{
    Console.WriteLine(i);
}

int sumLen = arr1.Length + arr2.Length;
int mid = sumLen / 2;

Console.WriteLine("Median:");

if (sumLen % 2 == 0)
{
    double median = (double)(result[mid] + result[mid - 1]) / 2;
    Console.WriteLine(median);
    return;
}

Console.WriteLine(result[mid]);


