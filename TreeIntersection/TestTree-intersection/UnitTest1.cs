using System;
using Xunit;
using TreeIntersection;
using System.Collections.Generic;

namespace TestTree_intersection
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            Node root1 = null;
            root1 = Program.insert(root1, 5);
            root1 = Program.insert(root1, 1);
            root1 = Program.insert(root1, 10);
            root1 = Program.insert(root1, 0);
            root1 = Program.insert(root1, 4);
            root1 = Program.insert(root1, 7);
            root1 = Program.insert(root1, 9);

            Node root2 = null;
            root2 = Program.insert(root2, 10);
            root2 = Program.insert(root2, 7);
            root2 = Program.insert(root2, 20);
            root2 = Program.insert(root2, 4);
            root2 = Program.insert(root2, 9);

            Program.inorder(root1);
            Program.inorder(root2);
            Program.print(root1, root2);

            Assert.NotNull(root2);


        }
        [Fact]
        public void Test2()
        {
            Node root1 = null;
            root1 = Program.insert(root1, 5);
            root1 = Program.insert(root1, 1);
            root1 = Program.insert(root1, 10);
            root1 = Program.insert(root1, 0);
            root1 = Program.insert(root1, 4);
            root1 = Program.insert(root1, 7);
            root1 = Program.insert(root1, 9);

            Node root2 = null;
            root2 = Program.insert(root2, 10);
            root2 = Program.insert(root2, 7);
            root2 = Program.insert(root2, 20);
            root2 = Program.insert(root2, 4);
            root2 = Program.insert(root2, 9);

            Program.inorder(root1);
            Program.inorder(root2);
            Program.print(root1, root2);

            Assert.NotNull(root1);


        }
    }
}
