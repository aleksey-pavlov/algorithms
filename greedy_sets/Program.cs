using System;
using System.Collections.Generic;

namespace greedy_sets
{
    class Program
    {
        static void Main(string[] args)
        {
            var states = new HashSet<string> {"mt", "wa", "or", "id", "nv", "ut", "ca", "az"};

            var stations = new Dictionary<string, HashSet<string>> {
                ["kone"] = new HashSet<string> { "id", "nv", "ut" },
                ["ktwo"] = new HashSet<string> { "wa", "id", "mt" },
                ["kthree"] = new HashSet<string> { "or", "nv", "ca" },
                ["kfour"] = new HashSet<string> { "nv", "ut" },
                ["kfive"] = new HashSet<string> { "ca", "az" }
            };

            var final = new HashSet<string> { };

            while (states.Count > 0) {
                var bestStation = String.Empty;
                var covered = new HashSet<string>();
                foreach (var s in stations) {
                    var cStates = new HashSet<string>(states);
                    cStates.IntersectWith(s.Value);
                    
                    if (cStates.Count > covered.Count) {
                        bestStation =  s.Key;
                        covered = s.Value;
                    }
                }

                states.ExceptWith(covered);
                final.Add(bestStation);
            }

            Console.WriteLine(string.Join(",", final));
        }
    }
}
