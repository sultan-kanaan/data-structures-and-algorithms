using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class KAryTree
    {
        public FBNode Root;

        public List<string> FizzBuzzTree(FBNode root)
        {
            List<string> FBlist = new List<string>();
            if (root == null)
            {
                return null;
            }
            Queue<FBNode> FBQueue = new Queue<FBNode>();
            FBQueue.Enqueue(root);
            while (FBQueue.Count > 0)
            {
                for (int i = 0; i < FBQueue.Count(); i++)
                {
                    int value = Convert.ToInt32(FBQueue.First().Value);

                    if (value % 15 == 0)
                    {
                        FBlist.Add("FizzBuzz");
                    }
                    else if (value % 3 == 0)
                    {
                        FBlist.Add("Fizz");
                    }
                    else if (value % 5 == 0)
                    {
                        FBlist.Add("Buzz");
                    }
                    else
                    {
                        FBlist.Add(FBQueue.First().Value.ToString());
                    }


                    FBNode node = FBQueue.Dequeue();
                    foreach (FBNode item in node.Children)
                    {
                        FBQueue.Enqueue(item);
                    }
                }
            }
            return FBlist;
        }
        public List<string> FizzBuzz(FBNode root)
        {
            List<string> FizzBuzzTree = new List<string>();
            
            if (root == null) 
            {
                return null; 
            }
            
            Queue<FBNode> FizzBuzzQueue = new Queue<FBNode>();
            FizzBuzzQueue.Enqueue(root);
            
            while (FizzBuzzQueue.Count > 0)
            {
                for (int i = 0; i < FizzBuzzQueue.Count(); i++)
                {
                    FBNode node = FizzBuzzQueue.Dequeue();
                    FizzBuzzTree.Add(node.Value.ToString());
                    foreach (FBNode item in node.Children)
                    {
                        FizzBuzzQueue.Enqueue(item);
                    }
                }
            }
            return FizzBuzzTree;

        }
    }
}
