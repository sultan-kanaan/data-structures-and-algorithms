using System;

namespace linkedList
{
    class Program
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
            MyList.AddEnd(1);
            MyList.AddEnd(2);
            //MyList.AddEnd(4);
            //MyList.AddEnd(5);
            //MyList.AddFirst(0);
            //MyList.AddFirst(4);
            //MyList.AddFirst(5);
            MyList.AddEnd(0);
            //MyList.Serche(2);
            //MyList.Remove(0);
            //MyList.Remove(6);
            //MyList.AddAfter(3,2);
            //MyList.Remove(4);
            var x = MyList.Tostring();
            Console.WriteLine(x);
            MyList.Display();
            }
        }
}
