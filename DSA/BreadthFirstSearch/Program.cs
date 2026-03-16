namespace BreadthFirstSearch
{
    internal class Program
    {
        private static Dictionary<string, string[]> _graph = new();

        static void Main(string[] args)
        {
            _graph.Add("you", ["alice", "bob", "claire"]);
            _graph.Add("bob", ["anuj", "peggy"]);
            _graph.Add("alice", ["peggy"]);
            _graph.Add("claire", ["thom", "jonny"]);
            _graph.Add("anuj", []);
            _graph.Add("peggy", []);
            _graph.Add("thom", []);
            _graph.Add("jonny", []);

            Search();
        }

        static bool PersonIsSeller(string name) => name.EndsWith('m');

        static bool Search()
        {
            var queue = new Queue<string>(_graph["you"]);
            var visited = new HashSet<string>();

            while (queue.Count > 0)
            {
                var person = queue.Dequeue();

                if (!visited.Contains(person))
                {
                    if (PersonIsSeller(person))
                    {
                        Console.WriteLine($"{person} is a mango seller!");
                        return true;
                    }

                    foreach (var neighbor in _graph[person])
                    {
                        queue.Enqueue(neighbor);
                    }

                    visited.Add(person);
                }
            }

            return false;
        }
    }
}
