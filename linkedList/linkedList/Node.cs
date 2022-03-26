using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList
{
    class Node 
    {
        int date;
        Node next;

        public int Date 
        {
            get { return date; }
            set { date = value; }
        }
        public Node Next
        {
            get { return next; }
            set {next = value; }
        }
        public Node(int value)
        {
            this.date = value;
            next = null; 
        }
    }
}
