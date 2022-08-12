
var graph = new Dictionary<string, string[]> {
   { "you", new string[] { "jane", "maggie" } },
   { "jane", new string[] { "bob", "alen" } }
};

var queue = new Queue<string>();

foreach (var member in graph["you"])
    queue.Enqueue(member);


while (queue.Count > 0)
{
    var member = queue.Dequeue();
    if (member == "bob")
    {
        Console.WriteLine($"Found seller! {member} is seller");
    }
    else if (graph.TryGetValue(member, out var members))
    {

        foreach (var m in members)
            queue.Enqueue(m);
    }
}