using System;
using System.Collections.Generic;
using System.Linq;

namespace sort_selection
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<int>{ 1, 33, 2, 56, 23, 99 };
            var sortedList = new List<int>();

            while (list.Count > 0) {
                
                var max = 0;
                foreach (var i in list) {
                    if (max < i) {
                        max = i;
                    }
                }

                list.Remove(max);
                sortedList.Add(max);
            }

            Console.WriteLine(String.Join(",", sortedList));
        }
    }
}
