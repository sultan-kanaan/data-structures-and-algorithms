using System;

namespace linkedList
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Stack stack = new Stack();
            //stack.push(5);
            //stack.push(6);
            //Console.WriteLine(stack.Size());
            //Console.WriteLine(stack.IsEmpty());
            //stack.pop();
            ////stack.pop();
            //Console.WriteLine(stack.peek());
            //Console.WriteLine(stack.Print());

            List MyList = new List();
            List list1 = new List();
            list1.Insert(50);
            list1.Insert(30);
            list1.Insert(10);
            List list2 = new List();
            list2.Insert(40);
            list2.Insert(20);

            MyList.ZipLists(list1, list2);
            Console.WriteLine(MyList.Tostring());
            Console.ReadLine();
        }
        }
}
