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
            List list1 = new List();
            //list1.Insert(70);
            //list1.Insert(50);
            list1.Insert(30);
            list1.Insert(10);
            List list2= new List();
            list2.Insert(80);
            list2.Insert(60);
            list2.Insert(40);
            list2.Insert(20);
            //Console.WriteLine(list1.Tostring());
            MyList.ZipLists(list1,list2);
            Console.WriteLine(MyList.Tostring());
            //MyList.Remove(0);
            //MyList.Remove(6);
            //MyList.Remove(4);
            //MyList.Insert(2);
            //MyList.Insert(1);
            //MyList.Append(3);
            //MyList.Append(4);
            //MyList.InsertBefore(3, 0);
            //MyList.InsertAfter(1, 2);
            //MyList.kthFromEnd(3);
            //Console.WriteLine(MyList.Include(3));
            //Console.WriteLine(MyList.Tostring());
            //MyList.Display();
            Console.ReadLine();
        }
        }
}
