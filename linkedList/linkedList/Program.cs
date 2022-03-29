using System;

namespace linkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Node one = new Node(1);
            //Node two = new Node(2);
            //Node three = new Node(3);
            //one.Next = two;
            //two.Next = three;
            //Console.WriteLine(one.Date);
            //Console.WriteLine(one.Next.Date);
            //Console.WriteLine(two.Date);
            //Console.WriteLine(one.Next.Date);
            //Console.WriteLine(two.Date);
            //Console.WriteLine(one.Next.Next.Date);
            //Console.WriteLine(two.Next.Date);

            List MyList = new List();

            //MyList.Remove(0);
            //MyList.Remove(6);
            //MyList.Remove(4);
            //MyList.Insert(2);
            MyList.Insert(1);
            MyList.Append(3);
            MyList.Append(4);
            MyList.InsertBefore(3, 0);
            MyList.InsertAfter(1, 2);
            MyList.kthFromEnd(4);
            Console.WriteLine(MyList.Include(3));
            Console.WriteLine(MyList.Tostring());
            //MyList.Display();
            }
        }
}
