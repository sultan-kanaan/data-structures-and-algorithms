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
    }
}
