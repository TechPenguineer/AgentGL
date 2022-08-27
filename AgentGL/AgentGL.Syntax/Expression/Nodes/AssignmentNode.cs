using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentGL.Syntax.Expression.Nodes
{
    public class AssignmentNode : Node
    {
        public AssignmentNode() : base(Classifier.Assignment)
        {
        }

        public Node Variable { get; set; }
        public Node Value { get; set; }

        protected override string ToStr()
        {
            return $"({Value}) to ({Variable})";
        }
    }
}
