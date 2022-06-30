using System;
using System.Collections.Generic;

namespace Graphs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;


            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");


            Console.WriteLine($"Number of nodes in graph: {graph.Size()}");


            Vertex A = new Vertex("A");
            Vertex B = new Vertex("B");
            Vertex C = new Vertex("C");
            graph.AddEdge(A, B, 15);
            graph.AddEdge(A, C, 7);


            Console.WriteLine("Neighbors and weights of node A:");
            List<Edge> resultA = graph.GetNeighbors(A);
            foreach (Edge edge in resultA)
            {
                Console.Write($" {edge.Neighbor.Value} ");
                Console.Write($" {edge.Weight} ");
                Console.WriteLine();
            }
            Console.WriteLine("Neighbors and weights of node C:");
            List<Edge> resultC = graph.GetNeighbors(C);
            foreach (Edge edge in resultC)
            {
                Console.Write($" {edge.Neighbor.Value} ");
                Console.Write($" {edge.Weight} ");
                Console.WriteLine();
            }

            List<Vertex> nodes = graph.GetNodes();
            Console.Write("List of nodes in graph: ");
            foreach (Vertex node in nodes)
            {
                Console.Write($" {node.Value} ");
            }
            Console.WriteLine();


            List<Vertex> path = graph.BreadthFirst(A);
            Console.Write("Adjecency list of node A: ");
            foreach (Vertex node in path)
            {
                Console.Write($" {node.Value} ");
            }


            Console.ReadKey();


        }

        public static int? BusinessTrip(Graph graph, string[]  cityNames)
        {
            int Cost = 0;
            if ( cityNames.Length <= 1)
            {
                return null;
            }
            for (int i = 0; i <  cityNames.Length - 1; i++)
            {
                List<Edge> Edges = graph.GetNeighbors(new Vertex( cityNames[i]));

                if (!Edges.Exists(n => n.Neighbor.Value.ToString() ==  cityNames[i + 1]))
                {
                    return null;
                }
                else
                {
                    Cost += Edges.Find(n => n.Neighbor.Value.ToString() ==  cityNames[i + 1]).Weight;
                }
            }
            return Cost;
        }
    }
}
