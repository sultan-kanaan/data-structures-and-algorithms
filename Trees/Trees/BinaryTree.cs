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
        public void PreOrder()
        {
            try
            {
                PreOrder(Root);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        private void PreOrder(Node node)
        {
            if (node != null)
            {
                Console.Write($"{ node.Value},");
                PreOrder(node.Left);
                PreOrder(node.Right);
            }

        }
        public void InOrder()
        {
            try
            {
                InOrder(Root);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Console.Write($"{ node.Value},");
                InOrder(node.Right);
            }
        }
        public void PostOrder()
        {
            try
            {
                PostOrder(Root);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void PostOrder(Node node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Console.Write($"{ node.Value},");
            }
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
    }
}
