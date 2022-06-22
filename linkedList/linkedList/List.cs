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
        public List()
        {
            Head = null;
        }
        public void Append(int value)
        {
            Node item = new Node(value);
            Node current = Head;
            if (Head == null)
            {
                Insert(value);
                return;
            }
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = item;
            }
        }
        public void Insert(int value)
        {
            Node item = new Node(value);
            if (Head == null)
            {
                Head = item;
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

            Node NewNode = new Node(newValue);
            if (Head == null)
            {
                Console.WriteLine("List is empty");
            }
            Node Current = Head;

            if (Current.Date == value)
            {
                Insert(newValue);
                return;
            }

            while (Current.Next != null)
            {
                if (Current.Next.Date == value)
                {
                    NewNode.Next = Current.Next;
                    Current.Next = NewNode;
                    return;
                }
                Current = Current.Next;
            }
        }




        public void InsertAfter(int value, int newValue)
        {

            if (Head == null)
            {
                Console.WriteLine("List is empty");
            }

            Node Current = Head;

            while (Current.Next != null)
            {
                if (Current.Date == value)
                {
                    Node node = new Node(newValue);
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }
                Current = Current.Next;
            }

            if (Current.Date == value)
            {
                Append(newValue);
                return;
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
                while (Start != null)
                {
                    Console.WriteLine(Start.Date);
                    Start = Start.Next;
                }
            }
        }
        public void kthFromEnd(int value)
        {
            Node current = Head;
            int position = 0;
            Node p = null;
            Node n = null;

            while (current != null)
            {
                n = current.Next;
                current.Next = p;
                p = current;
                current = n;


            }
            Head = p;

            current = Head;
            while (current != null)
            {
                if (current.Date == value)
                {
                    Console.WriteLine($"item {value} found at position {position}");
                    return;
                }
                current = current.Next;
                position++;
                if (current == null)
                {
                    Console.WriteLine("Exception");
                }
            }

        }
        public void Remove(int value)
        {
            if (Head == null)
            {
                Console.WriteLine("List is empty");
            }
            if (Head.Date == value)
            {
                Head = Head.Next;
                return;
            }
            Node previous = Head;
            Node current = Head.Next;

            while (current != null)
            {

                if (current.Date == value)
                {
                    previous.Next = current.Next;

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

        public List ZipLists(List list1, List list2)
        {
            List MyList = new List();
            Node current1 = list1.Head;
            Node current2 = list2.Head;
            int value;
            while (current1 != null || current2 != null)
            {
                if (current1 != null)
                {
                    value = current1.Date;
                    Append(value);
                    current1 = current1.Next;
                }
                if (current2 != null)
                {
                    value = current2.Date;
                    Append(value);
                    current2 = current2.Next;
                }

            }
            return MyList;



        }




    }
}