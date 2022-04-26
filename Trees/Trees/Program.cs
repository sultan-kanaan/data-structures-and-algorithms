using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(8);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(2);
            binaryTree.Add(6);
            binaryTree.Add(14);
            binaryTree.Add(9);
            binaryTree.Add(9);

            Console.Write("The Maximum Element Is : ");
            Console.WriteLine( binaryTree.Getmax());

            Console.WriteLine(binaryTree.Contains(0));
            Console.WriteLine(binaryTree.Contains(8));

            Console.Write("BreadthFirst : ");
            binaryTree.BreadthFirst();

            Console.WriteLine();
            Console.Write("PreOrder : ");
            binaryTree.PreOrder();

            Console.WriteLine();
            Console.Write("InOrder : ");
            binaryTree.InOrder();

            Console.WriteLine();
            Console.Write("PostOrder : ");
            binaryTree.PostOrder();

            Console.ReadLine();


        }
    }
}
