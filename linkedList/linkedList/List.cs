using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    public class List
    {
        public Node Head;
        public Node Tail; 
        public List()
        {
            Head = Tail = null;
        }
        public void Append(int value)
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
        public void Insert(int value)
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
        public void InsertBefore(int value, int newValue)
        {

            Node NewNode = new Node(value);
            if (Head == null)
            {
                Console.WriteLine("List is empty");
            }
            if (Head.Date == value)
            {
                NewNode.Next = Head;
                Head= NewNode;
                NewNode.Date = newValue;
                return;
            }

            Node previous = Head;
            Node current = Head.Next;
            while (current != null)
            {

                if (current.Date == value)
                {
                    NewNode.Date = newValue;
                    previous.Next = NewNode;
                    NewNode.Next = current;
                    if (NewNode.Next == null)
                    {
                        Tail = NewNode;
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

        public void InsertAfter(int value, int newValue)
        {

            Node NewNode = new Node(value);
            if (Head == null)
            {
                Console.WriteLine("List is empty");
            }
            if (Tail.Date == value)
            {
                NewNode.Next = null;
                Tail.Next = NewNode;
                NewNode.Date = newValue;
                return;
            }

            Node next = Head.Next;
            Node current = Head;
            while (current != null)
            {

                if (current.Date == value)
                {
                    current.Next = NewNode;
                    NewNode.Date = newValue;
                    NewNode.Next = next;
                    if (NewNode.Next == null)
                    {
                        Tail = NewNode;
                    }
                    return;
                }
                next = next.Next;
                current = current.Next;
            }
            if (current == null)
            {
                Console.WriteLine("not found!");
            }

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
            string format = "";
            Node current = Head;
            while (current != null)
            {
                format += $"[ {current.Date} ] -> ";
                current = current.Next;
            }

            format += "NULL";
            return format;
        }
        public bool Include(int value)
        {
            Node current = Head;
            while (current != null)
            {
                if (value.Equals(current.Date))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        

    }
}
