using System;
using Xunit;
using Trees;
using System.Collections.Generic;

namespace TestTree
{
    public class UnitTest1
    {
        // Can successfully instantiate an empty tree
        [Fact]
        public void TestinstantiateEmptyTree()
        {
            BinaryTree binaryTree = new BinaryTree();
            Assert.NotNull(binaryTree);
        }
        // Can successfully instantiate a tree with a single root node
        [Fact]
        public void TestinstantiateSingleTree()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(5);
            Assert.Equal(5, binaryTree.Root.Value);
        }
        [Fact]
        public void TestContains()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(5);
            binaryTree.Add(3);
            binaryTree.Add(2);
            binaryTree.PreOrder();

            Assert.True(binaryTree.Contains(5));
        }
        [Fact]
        public void TestGetMax()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(5);
            binaryTree.Add(3);
            binaryTree.Add(2);
            binaryTree.Getmax();

            Assert.Equal(5, binaryTree.Getmax());
        }
        [Fact]
        public void TestFGetMax()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(5);
            binaryTree.Add(3);
            binaryTree.Add(2);
            binaryTree.Getmax();

            Assert.NotEqual(4, binaryTree.Getmax());
        }
        [Fact]
        public void TestBreadthFirst()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(5);
            binaryTree.Add(3);
            binaryTree.Add(2);
            Assert.Equal(new List<object> { 5, 3, 2 }, binaryTree.BreadthFirst());
        }
        [Fact]
        public void TestInOrder()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(5);
            binaryTree.Add(3);
            binaryTree.Add(2);
            Assert.Equal(new List<object> { 2, 3, 5 }, binaryTree.InOrder());
        }
        [Fact]
        public void TestPreOrder()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(5);
            binaryTree.Add(3);
            binaryTree.Add(2);
            Assert.Equal(new List<object> { 5, 3, 2 }, binaryTree.PreOrder());
        }
        [Fact]
        public void TestPostOrder()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(5);
            binaryTree.Add(3);
            binaryTree.Add(2);
            Assert.Equal(new List<object> { 2, 3, 5 }, binaryTree.PostOrder());
        }
        [Fact]
        public void TestReturnsFizz()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(3);

            object[] result = binaryTree.FizzBuzzTree();

            Assert.Equal("Fizz", result[0]);
        }
        [Fact]
        public void TestReturnsBuzz()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(5);

            object[] result = binaryTree.FizzBuzzTree();

            Assert.Equal("Buzz", result[0]);
        }
        [Fact]
        public void TestReturnsFizzBuzz()
        {

            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(15);

            object[] result = binaryTree.FizzBuzzTree();

            Assert.Equal("FizzBuzz", result[0]);
        }
        [Fact]
        public void TestReturnsNum()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(8);

            object[] result = binaryTree.FizzBuzzTree();

            Assert.Equal(8, result[0]);
        }
        [Fact]
        public void TestFizzBuzz()
        {
            KAryTree tree = new KAryTree();
            FBNode root = new FBNode("15");
            root.Children.Add(new FBNode("2"));
            root.Children.Add(new FBNode("5"));
            root.Children.Add(new FBNode("21"));


            List<string> FizzBuzzTree = tree.FizzBuzzTree(root);
            Assert.Equal(new List<string>{"FizzBuzz", "2", "Buzz", "Fizz"}, FizzBuzzTree);





        }
    }
}
