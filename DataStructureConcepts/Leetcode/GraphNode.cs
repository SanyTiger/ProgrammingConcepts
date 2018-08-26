using System;
using System.Collections.Generic;

namespace Leetcode
{
    public class GraphNode<T>
    {
        public Dictionary<T, HashSet<T>> adjList = new Dictionary<T, HashSet<T>>();
        public GraphNode() { }
        public GraphNode(IEnumerable<T> vertices, IEnumerable<Tuple<T, T>> edges)
        {
            foreach (var vertex in vertices)
                AddVertex(vertex);
            foreach (var edge in edges)
                AddEdge(edge);
        }
        public void AddVertex(T vertex)
        {
            adjList[vertex] = new HashSet<T>();
        }
        public void AddEdge(Tuple<T, T> edge)
        {
            if(adjList.ContainsKey(edge.Item1) && adjList.ContainsKey(edge.Item2))
            {
                adjList[edge.Item1].Add(edge.Item2);
                adjList[edge.Item2].Add(edge.Item1);
            }
        }
    }
}
