using System;
using System.Collections.Generic;

namespace dijkstra
{
    class Program
    {

        static Dictionary<string, int> Processed = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            var graph = new Dictionary<string, Dictionary<string, int>>
            {
                ["start"] = new Dictionary<string, int>
                {
                    ["a"] = 6,
                    ["b"] = 2
                },
                ["a"] = new Dictionary<string, int>
                {
                    ["fin"] = 1
                },
                ["b"] = new Dictionary<string, int>
                {
                    ["a"] = 3,
                    ["fin"] = 5
                },
                ["fin"] = new Dictionary<string, int>()
            };

            var costs = new Dictionary<string, int>
            {
                ["a"] = 6,
                ["b"] = 2,
                ["fin"] = int.MaxValue
            };

            var parents = new Dictionary<string, string>
            {
                ["a"] = "start",
                ["b"] = "start",
                ["fin"] = null
            };

            var node = FindLowestCostNode(costs);
            while (!String.IsNullOrEmpty(node)) {

                var cost = costs[node];
                var neighbors = graph[node];

                foreach(var i in neighbors) {

                    var newCost = cost + i.Value;
                    if (costs[i.Key] > newCost) {
                        costs[i.Key] = newCost;
                        parents[i.Key] = node;
                    }
                }

                Processed[node] = 1;
                node = FindLowestCostNode(costs);
            }

            foreach ( var i in costs ) {
                Console.WriteLine($"{i.Key} : {i.Value}");
            }

            foreach ( var i in parents ) {
                Console.WriteLine($"{i.Key} : {i.Value}");
            }
        }

        public static string FindLowestCostNode(Dictionary<string, int> costs) 
        {
            var lowestCostNode = String.Empty;
            var lowestCost = int.MaxValue;

            foreach( var i in costs ) {

                if (i.Value < lowestCost && !Processed.ContainsKey(i.Key))
                {
                    lowestCost = i.Value;
                    lowestCostNode = i.Key;
                }
            }

            return lowestCostNode;
        }
    }
}
