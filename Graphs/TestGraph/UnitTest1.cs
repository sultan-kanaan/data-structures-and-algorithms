using System;
using Xunit;
using Graphs;
using System.Collections.Generic;

namespace TestGraph
{
    public class UnitTest1
    {
        [Fact]
        public void AddNodeToGraph()
        {
            Graph graph = new Graph();

            Vertex node = (Vertex)graph.AddNode("A");

            Assert.Contains(node, graph.Vertices);
        }

        [Fact]
        public void AddedEdgeToGraph()
        {
            Graph graph = new Graph();
            Vertex A = (Vertex)graph.AddNode("A");
            Vertex B = (Vertex)graph.AddNode("B");
            Vertex C = (Vertex)graph.AddNode("C");

            graph.AddEdge(A, B, 15);

            Assert.NotEmpty(A.Edge);
        }

        [Fact]
        public void GetGraphNodeList()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
            graph.AddNode("G");

            var list = graph.GetNodes();

            Assert.IsType<List<Vertex>>(list);
        }

        [Fact]
        public void GetNeighborsFromNode()
        {
            Graph graph = new Graph();
            Vertex A = (Vertex)graph.AddNode("A");
            Vertex B = (Vertex)graph.AddNode("B");
            Vertex C = (Vertex)graph.AddNode("C");
            graph.AddEdge(A, B, 45);
            graph.AddEdge(A, C, 9);

            var result = graph.GetNeighbors(A);

            Assert.Equal(2, result.Count);
        }

        [Fact]
        public void NieghborNodesHaveWeight()
        {
            Graph graph = new Graph();
            Vertex A = (Vertex)graph.AddNode("A");
            Vertex B = (Vertex)graph.AddNode("B");
            graph.AddEdge(A, B, 9999);

            Edge[] result = graph.GetNeighbors(A).ToArray();

            Assert.Equal(9999, result[0].Weight);
        }

        [Fact]
        public void GetSizeOfGraph()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");

            int count = graph.Size();

            Assert.Equal(3, count);
        }

        [Fact]
        public void GraphCanHaveOneNodeAndEdge()
        {
            Graph graph = new Graph();
            Vertex A = (Vertex)graph.AddNode("A");
            graph.AddEdge(A, A, 7);

            List<Vertex> result = graph.GetNodes();

            Assert.Equal(A, result.ToArray()[0]);
        }

        [Fact]
        public void EmptyGraphReturnsNull()
        {
            Graph graph = new Graph();

            var result = graph.GetNodes();

            Assert.Null(result);
        }
        [Fact]
        public void CanReturnRouteAtoG()
        {
            Graph graph = new Graph();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
            graph.AddNode("G");
            Vertex A = new Vertex("A");
            Vertex B = new Vertex("B");
            Vertex C = new Vertex("C");
            Vertex D = new Vertex("D");
            Vertex E = new Vertex("E");
            Vertex F = new Vertex("F");
            Vertex G = new Vertex("G");
            graph.AddEdge(A, B, 15);
            graph.AddEdge(A, C, 7);
            graph.AddEdge(A, D, 6);
            graph.AddEdge(B, E, 10);
            graph.AddEdge(C, E, 80);
            graph.AddEdge(D, E, 74);
            graph.AddEdge(E, F, 9);
            graph.AddEdge(F, G, 44);

            List<Vertex> list = graph.BreadthFirst(A);
            object[] result = new object[7];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = list[i].Value;
            }
            object[] expected = { "A", "B", "C", "D", "E", "F", "G" };

            Assert.Equal(expected, result);
        }
        [Fact]
        public void BusinessTriptest()
        {
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
            string[] citynames = { "Houston", "Seattle", "Los Angeles" };
            var result = Program.BusinessTrip(graph, citynames);
            var expected = 160;

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GraphReturnsPreOrderList()
        {
            Graph graph = new Graph();
            Vertex A = new Vertex("A");
            Vertex B = new Vertex("B");
            Vertex C = new Vertex("C");
            Vertex D = new Vertex("D");
            Vertex E = new Vertex("E");
            Vertex F = new Vertex("F");
            Vertex G = new Vertex("G");
            Vertex H = new Vertex("H");
            Vertex I = new Vertex("I");
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");
            graph.AddNode("D");
            graph.AddNode("E");
            graph.AddNode("F");
            graph.AddNode("G");
            graph.AddNode("H");
            graph.AddNode("I");
            graph.AddEdge(A, B, 5);
            graph.AddEdge(A, C, 5);
            graph.AddEdge(B, D, 5);
            graph.AddEdge(B, E, 5);
            graph.AddEdge(C, F, 5);
            graph.AddEdge(C, G, 5);
            graph.AddEdge(F, G, 5);
            graph.AddEdge(F, H, 5);
            graph.AddEdge(G, H, 5);
            graph.AddEdge(H, I, 5);

            List<Vertex> list = Program.DepthFirst(graph);
            List<object> result = new List<object>();
            foreach (Vertex node in list)
            {
                result.Add(node.Value);
            }
            List<object> expected = new List<object> { "A", "B", "D", "E", "C", "F", "G", "H", "I" };

            Assert.Equal(expected, result);
        }

    }
}
