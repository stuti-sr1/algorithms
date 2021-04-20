using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{

    public class MultiNode
    {
        public int val;
        public IList<MultiNode> children;
        public MultiNode() { }
        public MultiNode(int _val)
        {
            val = _val;
        }
        public MultiNode(int _val, IList<MultiNode> _children)
        {
            val = _val;
            children = _children;
        }
    }

}
