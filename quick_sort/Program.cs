using System;
using System.Collections.Generic;
using System.Linq;

namespace quick_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var sorted = quick_sort(new List<int>{ 1, 2, 44, 55, 16, 78, 0 });

            Console.WriteLine(String.Join(",", sorted));
        }

        static List<int> quick_sort(List<int> list) {
            if (list.Count < 2)
                return list;
            else {

                var pivot = list[0];

                var less = list.Where(n => n < pivot).ToList<int>();

                var greater = list.Where(n => n > pivot).ToList<int>();

                return quick_sort(less).Concat(new List<int> { pivot }).Concat(quick_sort(greater)).ToList<int>();
            }
        }
    }
}
