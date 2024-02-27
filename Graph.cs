using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreadthFirstSearch
{
    public class Graph
    {
        private int V; // Number of vertices
        private List<int>[] adj; // Adjacency List

        public Graph(int vertices)
        {
            V = vertices;
            adj = new List<int>[V];
            for (int i = 0; i < V; ++i)
                adj[i] = new List<int>();
        }

        // Function to add an edge into the graph
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w); // Add w to v's list
        }

        // BFS traversal of the vertices reachable from v
        public void BFS(int startVertex)
        {
            // Mark all the vertices as not visited(By default set as false)
            bool[] visited = new bool[V];

            // Create a queue for BFS
            Queue<int> queue = new Queue<int>();

            // Mark the current node as visited and enqueue it
            visited[startVertex] = true;
            queue.Enqueue(startVertex);

            while (queue.Count != 0)
            {
                // Dequeue a vertex from queue and print it
                startVertex = queue.Dequeue();
                Console.Write(startVertex + " ");

                // Get all adjacent vertices of the dequeued vertex startVertex.
                // If an adjacent vertex has not been visited, then mark it
                // visited and enqueue it
                foreach (int adjVertex in adj[startVertex])
                {
                    if (!visited[adjVertex])
                    {
                        visited[adjVertex] = true;
                        queue.Enqueue(adjVertex);
                    }
                }
            }
        }
    }
}
