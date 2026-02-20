using System;
using System.Collections.Generic;


namespace dinamycal_programming
{
    enum Items
    {
        Guitar = 0,
        Bumbox,
        Laptop,
        Phone

    };

    class Program
    {
        static void Main(string[] args)
        {
            
            var items = new Dictionary<Items, int[]>{ 
                [Items.Guitar] = [1500, 1],
                [Items.Bumbox] = [3000, 4],
                [Items.Laptop] = [2000, 3],
            };
            
            var bucket = 4;

            int[,] cell = new int[items.Count, bucket];
            
            for (int i = 0; i < items.Count; i++) {
                var itemKey = (Items)i;
                var cols = new string[bucket + 1];
                cols[0] = $"{itemKey}";

                for (int j = 0; j < bucket; j++) {

                    var cellWeight = j + 1;

                    var itemPrice = items[itemKey][0];
                    var itemWeight = items[itemKey][1];

                    var remindWeight = cellWeight - itemWeight;

                    if (i == 0)
                        cell[i, j] = remindWeight >= 0 ? itemPrice : 0;
                    else
                        cell[i, j] = remindWeight < 0 ? cell[i-1, j] : remindWeight == 0 ? itemPrice : Math.Max(itemPrice, itemPrice + cell[i-1, remindWeight-1]);

                    cols[j + 1] = $"{cell[i, j]}";
                }

                Console.WriteLine(string.Join(" | ", cols));
                Console.WriteLine("------------------------------------------");
            }

            Console.WriteLine($"\nResult: {cell[items.Count - 1, bucket - 1]}");
        }
    }
}
