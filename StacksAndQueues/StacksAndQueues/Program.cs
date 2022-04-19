using System;
using System.Collections.Generic;

namespace StacksAndQueues
{
   public class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("press uparrow to show Stack  " +
                "\npress DawnArrow to show Queue" +
                "\npress RightArrow to show PseudoQueue" +
                "\npress LeftArrow to show animalShelter" +
                "\npress Enter to show Bracket Validation ");
            ConsoleKeyInfo Key = Console.ReadKey();
            if (Key.Key == ConsoleKey.UpArrow)
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
                Main();
            }
            if (Key.Key == ConsoleKey.DownArrow)
            {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed; 
            Console.WriteLine("==============QUEUE==============");
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            Console.WriteLine(queue.IsEmpty());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Print());
            Console.WriteLine("");
              Main();

            }
            if (Key.Key == ConsoleKey.RightArrow)
            {
             Console.Clear();
             Console.ForegroundColor = ConsoleColor.Blue;
             Console.WriteLine("==============PSEUDO QUEUE==============");
             PseudoQueue pseudoQueue = new PseudoQueue();
             pseudoQueue.Enqueue(5);
             pseudoQueue.Enqueue(10);
             pseudoQueue.Dequeue();
             Console.WriteLine(pseudoQueue.peek());
             Console.WriteLine("");
                Main();

            }
            if (Key.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("==============ANIMAL SHELTER==============");
                AnimalShelter animalShelter = new AnimalShelter();
                Dog dog1 = new Dog();
                Dog dog2 = new Dog();
                Cat cat1 = new Cat();
                animalShelter.Enqueue(dog1);
                animalShelter.Enqueue(dog2);
                animalShelter.Enqueue(cat1);
                Console.WriteLine(animalShelter.Dequeue("dog"));
                Console.WriteLine("");
                Main();
            }
            if (Key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("==============Bracket Validation==============");
                Console.Write("()(}{}[] : ");
                Console.WriteLine(BracketValidation("()(}{}[]"));
                
                Console.Write("()(){}[] : ");
                Console.WriteLine(BracketValidation("()(){}[]"));
                
                Console.Write("()(}{)}[] : ");
                Console.WriteLine(BracketValidation("()(}{)}[]"));
                
                Console.Write("() : ");
                Console.WriteLine(BracketValidation("()"));
                
                Console.Write("(}: ");
                Console.WriteLine(BracketValidation("(}"));
            }

            else
            {
            Stack stack = new Stack();
            stack.Sultan();
            }
            Console.Beep();
            Console.ReadLine();
        }
        
        public static bool BracketValidation(string input)
        {

            Stack<char> Brackets = new Stack<char>();
            foreach (char item in input.ToCharArray())
            {
            switch (item)
                {
                    case '(':
                    case '{':
                    case '[':
                        Brackets.Push(item);
                        break;
                    case ')':
                        if (Brackets.Pop() != '(')
                        {
                            return false;
                        }
                        break;
                    case '}':
                        if (Brackets.Pop() != '{')
                        {
                            return false;
                        }
                        break;
                    case ']':
                        if (Brackets.Pop() != '[')
                        {
                            return false;
                        }
                        break;
                }
            
            }
            if (Brackets.Count == 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
