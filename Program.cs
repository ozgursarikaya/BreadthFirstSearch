using BreadthFirstSearch;

Graph g = new Graph(4);

g.AddEdge(0, 1);
g.AddEdge(0, 2);
g.AddEdge(1, 2);
g.AddEdge(2, 0);
g.AddEdge(2, 3);
g.AddEdge(3, 3);

Console.WriteLine("Breadth First Traversal (starting from vertex 2): ");
g.BFS(2);