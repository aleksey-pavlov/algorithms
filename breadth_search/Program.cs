
using System;
using System.Collections.Generic;

namespace breadth_search
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Dictionary<string, string[]> {
                { "you", new string[] { "jane", "maggie" } },
                { "jane", new string[] { "bob", "alen" } }
            };

            var queue = new Queue<string>();
            var searched = new Dictionary<string, int>();

            foreach (var member in graph["you"])
                queue.Enqueue(member);


            while (queue.Count > 0)
            {
                var member = queue.Dequeue();
                if (member == "bob")
                {
                    Console.WriteLine($"Found seller! {member} is seller");
                }
                else if (!searched.ContainsKey(member) && graph.TryGetValue(member, out var members))
                {
                    foreach (var m in members)
                        queue.Enqueue(m);

                    searched[member] = 1;
                }
            }
        }
    }
}