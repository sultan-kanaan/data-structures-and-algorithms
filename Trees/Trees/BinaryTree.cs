using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinaryTree
    {
        public Node Root;
        public List<int> Tree = new List<int>();


        public BinaryTree()
        {

        }
        public BinaryTree(Node node)
        {

        }
        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                AddTo(Root, value);
            }
        }
        private void AddTo(Node node, int value)
        {
            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(value);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node(value);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }

        }
        public List<int> PreOrder()
        {
            try
            {
                PreOrder(Root);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Tree;

        }
        private List<int> PreOrder(Node node)
        {
            if (node != null)
            {
                Tree.Add(node.Value);
                Console.Write($"{ node.Value},");
                PreOrder(node.Left);
                PreOrder(node.Right);
                
            }
            return Tree;

        }
        public List<int> InOrder()
        {
            try
            {
                InOrder(Root);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Tree;
        }
        private List<int> InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Tree.Add(node.Value);
                //Console.Write($"{ node.Value},");
                InOrder(node.Right);
            }
            return Tree;
        }
        public List<int> PostOrder()
        {
            try
            {
                PostOrder(Root);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Tree;
        }
        private List<int> PostOrder(Node node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Tree.Add(node.Value);
                Console.Write($"{ node.Value},");
            }
            return Tree;
        }
        public bool Contains(int value)
        {
            try
            {
                Node current = Root;
                while (current != null)
                {
                    if (value > current.Value)
                    {
                        current = current.Right;
                    }
                    else if (value < current.Value)
                    {
                        current = current.Left;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public int Getmax()
        {
            Node current = Root;
            while (current.Right != null)
            {
                current = current.Right;
            }
            return current.Value;
        }
       
        public List<int> BreadthFirst()
        {
            BreadthFirst(Root);
            return Tree;
        }
        
        private List<int> BreadthFirst(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                Node node = queue.Dequeue();

                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
                Tree.Add(node.Value);
                Console.Write($"{ node.Value},");
            }
            return Tree;

        }
    }
}
