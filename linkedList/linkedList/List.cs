using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    class List
    {
        Node Head;
        Node Tail; 
        public List()
        {
            Head = Tail = null;
        }
        public void AddEnd(int value)
        {
            Node item = new Node(value);
            if (Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                Tail.Next = item;
                Tail = item;
            }
        }
        public void AddFirst(int value)
        {
            Node item = new Node(value);
            if(Head == null)
            {
                Head = item;
                Tail = item;
            }
            else
            {
                item.Next = Head;
                Head = item;
            }
        }
        public void AddAfter(int value, int position)
        {
            Node current = Head;
            for (int i = 0; i < position; i++)
            {
                current = current.Next;
                if (current == null)
                {
                    Console.WriteLine("out of range!");
                    return;
                }
            }
            Node NewNode = new Node(value);
            NewNode.Next = current.Next;
            current.Next = NewNode;

        }
        public void Display()
        {
            Node Start = Head;
            if (Start == null)
            {
                Console.WriteLine("List is empty");
            }
            else 
            {
                while(Start != null)
                {
                    Console.WriteLine(Start.Date);
                    Start = Start.Next;
                }
            }
        }
        public void Serche(int value)
        {
            Node current = Head;
            int position = 1;

            while(current != null)
            {
                if(current.Date == value)
                {
                    Console.WriteLine($"item {value} found at position {position}");
                    return;
                }
                current = current.Next;
                position++;
                if(current == null)
                {
                    Console.WriteLine("item not found");
                }
            }
        }
        public void Remove(int value)
        {
          if(Head == null)
            {
                Console.WriteLine("List is empty");
            }
          if(Head.Date == value)
            {
                Head = Head.Next;
                return;
            }
            Node previous = Head;
            Node current = Head.Next;
            
            while (current != null )
            {
            
                if (current.Date == value)
            {
                previous.Next = current.Next;
                    if (previous.Next == null)
                    {
                        Tail = previous;
                    }
                    return;
            }
                previous = previous.Next;
                current = current.Next;
            }
            if (current == null)
            {
                Console.WriteLine("not found!");
            }

        }
        public string Tostring()
        {
            string str = "";
            Node current = Head;
            while (current != null)
            {
                str += $"[ {current.Date} ] -> ";
                current = current.Next;
            }

            str += "NULL";
            return str;
        }


    }
}
