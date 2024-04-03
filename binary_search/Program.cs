using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Enumerable.Range(0, 100000000).ToList();
            var find = 513;

            var start = 0;
            var finish = arr.Count;

            while (start <= finish)
            {
                var mid = (start + finish) / 2;
                Console.WriteLine($"mid: {mid}");
                var value = arr[mid];
                if (value == find)
                {
                    Console.WriteLine($"Found {find}");
                    break;
                }
                else if (value > find)
                {
                    finish = mid - 1;
                }
                else if (value < find)
                {
                    start = mid + 1;
                }
            }
        }
    }
}
