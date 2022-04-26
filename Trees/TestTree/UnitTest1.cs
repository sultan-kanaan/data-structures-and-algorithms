using System;
using Xunit;
using Trees;

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
            Assert.Equal(5,binaryTree.Root.Value);
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

            Assert.Equal(5,binaryTree.Getmax());
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




    }
}
