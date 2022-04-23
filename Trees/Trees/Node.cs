using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class Node
    {
        public int Value;
        public Node Left;
        public Node Right;
        public Node()
        {

        }

        public Node(int value)
        {
            Value = value;
        }
    }
}
