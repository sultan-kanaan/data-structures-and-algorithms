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
            //List to hold join data.
            List<string> joinTable = new List<string>();

            //Stepping through all hashnode is left hash table
            for (int i = 0; i < left.Table.Length; i++)
            {
                //If the bucket has a hashnode in it
                if (left.Table[i] != null)
                {
                    //Take the first hashnode out of the bucket.
                    Node currentNode = left.Table[i];

                    //Runs until collision storage is null
                    while (currentNode != null)
                    {
                        //Will hold the data collected from hashnode
                        string concat = null;
                        //Adds left hashnode key and value
                        concat = concat + $"{currentNode.Key}, {currentNode.Value}, ";
                        //Checks to see if right hashtable contains matching key
                        if (right.Contains(currentNode.Key))
                        {
                            // Adds right hashnodes value to concat
                            concat = concat + right.Get(currentNode.Key);
                        }
                        else
                        {
                            //Adds NULL if right hashtable doesnt have matching key
                            concat += "NULL";
                        }
                        //Adds saved key value data to list.
                        joinTable.Add(concat);
                        //Moves to next node in collision storage.
                        currentNode = currentNode.Next;
                    }
                }
            }
            //Returns joinTable
            return joinTable;
        }
    }
}

