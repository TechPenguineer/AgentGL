using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentGL.Syntax.Expression.Nodes
{
    public class ArrayAccessNode : Node
    {
        public ArrayAccessNode() : base(Classifier.ArrayAccess)
        {
        }

        public Node Index { get; set; }
        public Node BaseNode { get; set; }

        protected override string ToStr()
        {
            return $"Index [{Index}] from ({BaseNode})";
        }
    }
}
