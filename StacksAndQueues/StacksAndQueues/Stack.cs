using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Stack
    {
        public Node Top { get; set; }
        int count = 0;
        public Stack()
        {

        }
        public Stack(Node node)
        {
            Top = node;
        }

        public void push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
            count++;
        }
        public int Size()
        {
            return count;
        }
        public bool IsEmpty()
        {
            if (Top == null)
            {
                return true;
            }
            else
                return false;
        }
        public void pop()
        {
            if (Top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Node temp = Top;
                Top = Top.Next;
                temp.Next = null;
                count--;
                Console.WriteLine($"{temp.Value} is deleted");
            }
        }
        public string peek()
        {

            if (Top == null)
            {
                return "Stack is empty";
            }
            else
            {

                return $"peek is {Top.Value}";
            }
        }
        public string Print()
        {
            string Format = "";

            if (Top == null)
                return "Stack is Empty!";

            else
            {
                Node current = Top;
                while (current != null)
                {
                    Format += "[" + current.Value + "] -> ";
                    current = current.Next;
                }
            }

            Format += "NULL";

            return Format;
        }
        public void Sultan()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nCode By Sultan Kanaan");
        }
    }
}
