using System;
using System.Collections.Generic;

namespace MunicipalApp.DataStructures
{
    public class Graph
    {
        private Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();

        public void AddNode(int id)
        {
            if (!adjacencyList.ContainsKey(id))
                adjacencyList[id] = new List<int>();
        }

        public void AddEdge(int from, int to)
        {
            AddNode(from);
            AddNode(to);

            if (!adjacencyList[from].Contains(to))
                adjacencyList[from].Add(to);
        }

        public List<int> GetConnections(int id)
        {
            return adjacencyList.ContainsKey(id) ? adjacencyList[id] : new List<int>();
        }

        public List<int> BreadthFirstSearch(int startId)
        {
            var result = new List<int>();
            if (!adjacencyList.ContainsKey(startId))
                return result; // ✅ Prevents crash

            var visited = new HashSet<int>();
            var queue = new Queue<int>();

            queue.Enqueue(startId);
            visited.Add(startId);

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                result.Add(current);

                foreach (var neighbor in adjacencyList[current])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return result;
        }
    }
}
