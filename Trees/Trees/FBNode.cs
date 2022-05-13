using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class FBNode
    {
        public string Value;
        public List<FBNode> Children;
        public FBNode()
        {

        }
        public FBNode(string value)
        {
            Value = value;
            Children = new List<FBNode>();

        }
    }
}
