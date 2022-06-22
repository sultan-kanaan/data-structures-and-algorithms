using System;
using System.Collections.Generic;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;


            //Graph graph = new Graph();
            //graph.AddNode("A");
            //graph.AddNode("B");
            //graph.AddNode("C");


            //Console.WriteLine($"Number of nodes in graph: {graph.Size()}");


            //Vertex A = new Vertex("A");
            //Vertex B = new Vertex("B");
            //Vertex C = new Vertex("C");
            //graph.AddEdge(A, B, 15);
            //graph.AddEdge(A, C, 7);


            //Console.WriteLine("Neighbors and weights of node A:");
            //List<Edge> resultA = graph.GetNeighbors(A);
            //foreach (Edge edge in resultA)
            //{
            //    Console.Write($" {edge.Neighbor.Value} ");
            //    Console.Write($" {edge.Weight} ");
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Neighbors and weights of node C:");
            //List<Edge> resultC = graph.GetNeighbors(C);
            //foreach (Edge edge in resultC)
            //{
            //    Console.Write($" {edge.Neighbor.Value} ");
            //    Console.Write($" {edge.Weight} ");
            //    Console.WriteLine();
            //}

            //List<Vertex> nodes = graph.GetNodes();
            //Console.Write("List of nodes in graph: ");
            //foreach (Vertex node in nodes)
            //{
            //    Console.Write($" {node.Value} ");
            //}
            //Console.WriteLine();


            //List<Vertex> path = graph.BreadthFirst(A);
            //Console.Write("Adjecency list of node A: ");
            //foreach (Vertex node in path)
            //{
            //    Console.Write($" {node.Value} ");
            //}
            Console.WriteLine();
            Graph graph = new Graph();
            graph.AddNode("Houston");
            graph.AddNode("Seattle");
            graph.AddNode("Los Angeles");
            graph.AddNode("Cookeville");
            graph.AddNode("Riverside");
            Vertex A = new Vertex("Houston");
            Vertex B = new Vertex("Seattle");
            Vertex C = new Vertex("Los Angeles");
            Vertex D = new Vertex("Cookeville");
            Vertex E = new Vertex("Riverside");
            graph.AddEdge(A, B, 50);
            graph.AddEdge(A, C, 32);
            graph.AddEdge(B, C, 110);
            graph.AddEdge(C, D, 99);
            graph.AddEdge(C, E, 159);
            graph.AddEdge(D, E, 75);
            string start = "Seattle";
            string end = "Riverside";
            BusinessTrip(graph, start, end);

            Console.ReadKey();

            
        }
        public static void BusinessTrip(Graph graph, string start, string end)
        {
            bool pathFound = false;
            List<Vertex> route = new List<Vertex>();
            int cost = 0;
            Vertex root = graph.Vertices.Find(v => v.Value.ToString() == start);

            // Edge case of start and/or end location not existing on graph
            if (!graph.Vertices.Exists(c => c.Value.ToString() == start) || !graph.Vertices.Exists(c => c.Value.ToString() == end))
            {
                route.Add(new Vertex("None"));
            }
            // Edge case of start and end point being immediately adjacent to each other
            else if (root.Edge.Exists(n => n.Neighbor.Value.ToString() == end))
            {
                route.Add(root.Edge.Find(n => n.Neighbor.Value.ToString() == end).Neighbor);
                route.Add(root.Edge.Find(n => n.Neighbor.Value.ToString() == start).Neighbor);
                cost += root.Edge.Find(n => n.Neighbor.Value.ToString() == end).Weight;
            }
            else
            {
                Tuple<List<Vertex>, int, bool, Vertex> bestRoute = FindRoutes(graph, root, start, end, route, cost, pathFound);

                Console.WriteLine($"Route for travel from {start} to {end}:");
                for (int i = bestRoute.Item1.Count - 1; i >= 0; i--)
                {
                    Console.Write($"{bestRoute.Item1[i].Value.ToString()} ");
                }
                Console.WriteLine();
                Console.WriteLine($"Cost: ${bestRoute.Item2}");
            }
        }

        public static Tuple<List<Vertex>, int, bool, Vertex> FindRoutes(Graph graph, Vertex root, string start, string end, List<Vertex> route, int cost, bool pathFound)
        {
            root.Visited = true;
            if (root.Value.ToString() == end)
            {
                pathFound = true;
            }

            Vertex lastNode = null;

            foreach (Edge edge in root.Edge)
            {

                if (!edge.Neighbor.Visited)
                {
                    Tuple<List<Vertex>, int, bool, Vertex> path = FindRoutes(graph, edge.Neighbor, start, end, route, cost, pathFound);
                    if (path.Item3)
                    {
                        pathFound = true;
                        lastNode = path.Item4;
                        cost += path.Item2;
                    }
                }

                if (pathFound)
                {
                    route.Add(root);
                    if (lastNode == edge.Neighbor)
                    {
                        cost += edge.Weight;
                    }
                    return new Tuple<List<Vertex>, int, bool, Vertex>(route, cost, pathFound, root);
                }
            }

            return new Tuple<List<Vertex>, int, bool, Vertex>(route, cost, pathFound, root);
        }
    }
}
