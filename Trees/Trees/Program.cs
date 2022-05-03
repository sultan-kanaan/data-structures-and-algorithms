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
            binaryTree.Add(15);
            binaryTree.Add(9);
            binaryTree.Add(9);


            Console.Write("The Maximum Element Is : ");
            Console.WriteLine(binaryTree.Getmax());

            Console.WriteLine(binaryTree.Contains(0));
            Console.WriteLine(binaryTree.Contains(8));

            binaryTree.Tree.Clear();
            Console.Write("BreadthFirst : ");
            binaryTree.BreadthFirst();

            binaryTree.Tree.Clear();
            Console.WriteLine();
            Console.Write("PreOrder : ");
            binaryTree.PreOrder();

            binaryTree.Tree.Clear();
            Console.WriteLine();
            Console.Write("InOrder : ");
            var InOrder = binaryTree.InOrder();
            foreach (var item in InOrder)
            {
                Console.Write($"{item},");
            }

            binaryTree.Tree.Clear();
            Console.WriteLine();
            Console.Write("PostOrder : ");
            binaryTree.PostOrder();

            binaryTree.Tree.Clear();
            Console.WriteLine();
            Console.Write("FizzBuzzTree : ");
            var FizzBuzz = binaryTree.FizzBuzzTree();
            foreach (var item in FizzBuzz)
            {
                Console.Write($"{item},");
            }
            Console.ReadLine();


        }
       
    }
}
