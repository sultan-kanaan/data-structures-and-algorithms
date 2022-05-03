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
        public List<object> Tree = new List<object>();


        public BinaryTree()
        {

        }
        public BinaryTree(Node node)
        {

        }
        public void Add(object value)
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
        private void AddTo(Node node, object value)
        {
            if ((int)value <= (int)node.Value)
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
        public List<object> PreOrder()
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
        private List<object> PreOrder(Node node)
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
        public List<object> InOrder()
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
        private List<object> InOrder(Node node)
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
        public List<object> PostOrder()
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
        private List<object> PostOrder(Node node)
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
        public bool Contains(object value)
        {
            try
            {
                Node current = Root;
                while (current != null)
                {
                    if ((int)value > (int)current.Value)
                    {
                        current = current.Right;
                    }
                    else if ((int)value < (int)current.Value)
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
        public object Getmax()
        {

           return Getmax(Root);

        }

        public object Getmax(Node node)
        {
            if (node == null)
            {
                return null;
            }

            object root = node.Value;
            object left = Getmax(node.Left);
            object right = Getmax(node.Right);

            if ((int)left > (int)root)
            {
                root = left;
            }
            if ((int)right > (int)root)
            {
                root = right;
            }

            return root;
        }

        public List<object> BreadthFirst()
        {
            BreadthFirst(Root);
            return Tree;
        }
        
        private List<object> BreadthFirst(Node root)
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
        public object[] FizzBuzzTree()
        {
            return FizzBuzzTree(Root);
        }
        private object[] FizzBuzzTree(Node root)
        {

            try
            {
                if ((int)root.Value % 15 == 0)
                {
                    root.Value = "FizzBuzz";
                }
                else if ((int)root.Value % 3 == 0)
                {
                    root.Value = "Fizz";
                }
                else if ((int)root.Value % 5 == 0)
                {
                    root.Value = "Buzz";
                }

                Tree.Add(root.Value);

                if (root.Left != null)
                {
                    FizzBuzzTree(root.Left);
                }
                if (root.Right != null)
                {
                    FizzBuzzTree(root.Right);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return Tree.ToArray();
        }
    }
}
