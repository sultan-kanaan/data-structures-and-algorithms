using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class Node
    {
        public string Key { get; set; }
        public object Value { get; set; }
        public Node Next { get; set; }
        public int Value1 { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(string key, string value)
        {
            Key = key;
            Value = value;
            Next = null;        
        }

        public Node(int value)
        {
            Value1 = value;
            Left = Right = null;
        }
    }
}
