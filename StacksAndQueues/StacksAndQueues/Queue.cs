using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Queue
    {
        public Node Front;
        public Node Rear;
        public Queue()
        {

        }
        public Queue(Node node)
        {
            Front = node;
            Rear = node;
        }

        public void Enqueue(int value)
        {
            Node node = new Node(value);
            if (Rear == null && Front == null)
            {
                Front = Rear = node;
            }
            else
            {
                Rear.Next = node;
                Rear = node;

            }
        }


        public void Dequeue()
        {
            if (Front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = Front;
                Front = Front.Next;
                temp.Next = null;
                Console.WriteLine($"{temp.Value} is deleted");
            }
        }


        public string Peek()
        {
            if (Front == null)
            {
                return "Queue is empty";
            }
            else
                return $"peek is {Front.Value}";

        }
        public bool IsEmpty()
        {
            if (Front == null)
            {
                return true;
            }
            else
                return false;
        }
        public string Print()
        {
            string Format = "";

            if (Front == null)
                return "Queueis Empty!";

            else
            {
                Node current = Front;
                while (current != null)
                {
                    Format += "[" + current.Value + "] -> ";
                    current = current.Next;
                }
            }

            Format += "NULL";

            return Format;
        }
    }
}
