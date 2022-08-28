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
                [Items.Guitar] = new int[] { 1500, 1 },
                [Items.Bumbox] = new int[] { 3000, 4 },
                [Items.Laptop] = new int[] { 2000, 3 },
                [Items.Phone] = new int[] { 2000, 1 }
            };
            
            var bucket = 4;

            int[,] cell = new int[items.Count, bucket];


            for (int i = 0; i < items.Count; i++) {
                
                for (int j = 0; j < bucket; j++) {

                    var cellWeight = j + 1;
                    var cellPrice = cell[i,j];

                    var itemKey = (Items)i;
                    var itemPrice = items[itemKey][0];
                    var itemWeight = items[itemKey][1];

                    var remindWeight = cellWeight - itemWeight;

                    if (i == 0)
                        cell[i, j] = remindWeight >= 0 ? itemPrice : 0;
                    else
                        cell[i, j] = remindWeight < 0 ? cell[i-1, j] : remindWeight == 0 ? itemPrice : itemPrice + cell[i-1, remindWeight-1];

                    Console.WriteLine(cell[i, j]);
                }

                Console.WriteLine("-------------");
            }
        }
    }
}
