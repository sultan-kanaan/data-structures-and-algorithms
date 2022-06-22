using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HashTables
{
    public class Program
    {
        static void Main(string[] args)
        {
            {

                string exampleOne = "Once upon a time, there was a brave princess who...";
                string exampleTwo = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
                string exampleThree = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The repeated word is :");
                Console.WriteLine(RepeatedWord(exampleOne));
                Console.WriteLine(RepeatedWord(exampleTwo));
                Console.WriteLine(RepeatedWord(exampleThree));

                Console.WriteLine();
                Console.WriteLine();

                BinaryTree testTreeOne = new BinaryTree();
                testTreeOne.Root = new Node(1);
                testTreeOne.Root.Left = new Node(2);
                testTreeOne.Root.Right = new Node(3);

                BinaryTree testTreeTwo = new BinaryTree();
                testTreeTwo.Root = new Node(4);
                testTreeTwo.Root.Left = new Node(1);
                testTreeTwo.Root.Right = new Node(2);

                List<int> values = TreeIntersection(testTreeOne, testTreeTwo);

                Console.WriteLine("Common Values");
                foreach (int value in values)
                {
                    Console.WriteLine($"Value = {value}");
                }

                Console.ReadKey();
            }
        }

          
            public static string RepeatedWord(string input)
            {
                string[] words = input.Split(' ');

                HashTable hashtable = new HashTable();

                for (int i = 0; i < words.Length; i++)
                {
                string word = Regex.Replace(words[i].ToLower(), @"[^\w\d\s]", "");

                    if (hashtable.Contains(word))
                    {
                        return hashtable.Get(word).Value;
                    }

                    hashtable.Set(word, word);
                }

                return "No Repeated Word";
            }
        public static List<string> LeftJoin(HashTable left, HashTable right)
        {
            List<string> joinTable = new List<string>();

            for (int i = 0; i < left.Table.Length; i++)
            {
                if (left.Table[i] != null)
                {
                    Node currentNode = left.Table[i];

                    while (currentNode != null)
                    {
                        string concat = null;
                        concat = concat + $"{currentNode.Key}, {currentNode.Value}, ";
                        if (right.Contains(currentNode.Key))
                        {
                            concat = concat + right.Get(currentNode.Key);
                        }
                        else
                        {
                            concat += "NULL";
                        }
                        joinTable.Add(concat);
                        currentNode = currentNode.Next;
                    }
                }
            }
            return joinTable;
        }
        public static List<int> TreeIntersection(BinaryTree treeOne, BinaryTree treeTwo)
        {

            List<int> commonValues = new List<int>();
            HashTable visitedValues = new HashTable();

            // Traverses first tree and adds values to hashmap.
            void TraversalOne(Node root)
            {
                if (root == null)
                {
                    return;
                }

                visitedValues.Set(root.Value1.ToString(), null);
                TraversalOne(root.Left);
                TraversalOne(root.Right);
            }

            // Traverses second tree and adds values to list if value is contained within hashmap.
            void TraversalTwo(Node root)
            {
                if (root == null)
                {
                    return;
                }
                if (visitedValues.Contains(root.Value1.ToString()))
                {
                    commonValues.Add(root.Value1);
                }
                TraversalTwo(root.Left);
                TraversalTwo(root.Right);
            }

            // Fires both recursive methods.
            TraversalOne(treeOne.Root);
            TraversalTwo(treeTwo.Root);

            // Returns list of common values.
            return commonValues;
        }
    }
}

