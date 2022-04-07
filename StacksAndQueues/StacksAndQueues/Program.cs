using System;

namespace StacksAndQueues
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("==============STACK==============");
            Stack stack = new Stack();
            stack.push(5);
            stack.push(6); 
            stack.push(7);
            stack.pop();
            //stack.pop();
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.peek());
            Console.WriteLine(stack.Print());
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==============QUEUE==============");
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            Console.WriteLine(queue.IsEmpty());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Print());

            Console.ReadLine();
        }
    }
}
