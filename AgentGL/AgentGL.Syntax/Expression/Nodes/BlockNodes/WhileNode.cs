using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentGL.Syntax.Expression.Nodes.BlockNodes
{
    public class WhileNode : BlockNode
    {
        public WhileNode() : base(Classifier.While)
        {
        }

        public Node Condition { get; set; }

        protected override string ToStr()
        {
            return $"Condition: ({Condition})\n{base.ToStr()}";
        }
    }
}
