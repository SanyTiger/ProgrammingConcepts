using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Leetcode
{
    [TestClass]
    public class BreadthFirstSearch
    {
        [TestMethod]
        public void TestMethod1()
        {
            var vertices = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var edges = new[] { Tuple.Create(1,2), Tuple.Create(1,3),
                Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
                Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
                Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10) };
            var graph = new GraphNode<int>(vertices, edges);
            var sol = new BreadthFirstSearchSolution();
            var result = sol.BFS(graph, 1);
        }
    }
    public class BreadthFirstSearchSolution
    {
        public HashSet<T> BFS<T>(GraphNode<T> graph, T source)
        {
            var visited = new HashSet<T>();
            var queue = new Queue<T>(); 
            if (!graph.adjList.ContainsKey(source))
                return visited;

            queue.Enqueue(source);
            while(queue.Count > 0)
            {
                var vertex = queue.Dequeue();
                if (visited.Contains(vertex))
                    continue;

                visited.Add(vertex);

                foreach(var neighbour in graph.adjList[vertex])
                {
                    if (!visited.Contains(neighbour))
                        queue.Enqueue(neighbour);
                }
            }
            return visited;
        }
    }

    public class DepthFirstSearch
    {
        public HashSet<T> DFS<T>(GraphNode<T> graph, T source)
        {
            var hash = new HashSet<T>();

            return hash;
        }
    }
}
