namespace Dijkstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var graph = new Dictionary<string, Dictionary<string, double>>
            {
                ["start"] = new() { ["a"] = 6.0, ["b"] = 2.0},
                ["a"] = new() { ["fin"] = 1.0},
                ["b"] = new() { ["a"] = 3.0, ["fin"] = 5.0 },
                ["fin"] = new(),
            };

            var costs = new Dictionary<string, double>
            {
                ["a"] = 6.0,
                ["b"] = 2.0,
                ["fin"] = double.PositiveInfinity,
            };

            var parents = new Dictionary<string, string?>
            {
                ["a"] = "start",
                ["b"] = "start",
                ["fin"] = null
            };

            var processed = new HashSet<string>();
            var node = FindLowestCostNode(costs, processed);
            while (node is not null)
            {
                double cost = costs[node];
                var neighbors = graph[node];

                foreach (var n in neighbors)
                {
                    double newCost = cost + n.Value;

                    if (costs[n.Key] > newCost)
                    {
                        costs[n.Key] = newCost;
                        parents[n.Key] = node;
                    }
                }

                processed.Add(node);
                node = FindLowestCostNode(costs, processed);
            }

            Console.WriteLine(string.Join(", ", costs));
        }

        private static string? FindLowestCostNode(Dictionary<string, double> costs, 
            HashSet<string> processed)
        {
            var lowestCost = double.PositiveInfinity;
            string? lowestCostNode = null;

            foreach (var node in costs)
            {
                var cost = node.Value;
                if (cost < lowestCost && !processed.Contains(node.Key))
                {
                    lowestCost = cost;
                    lowestCostNode = node.Key;
                }
            }

            return lowestCostNode;
        }
    }
}
