using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentGL.Syntax.Expression.Nodes
{
    public class NullConditionNode : Node
    {
        public NullConditionNode() : base(Classifier.NullCondition)
        {
        }

        public Node Condition { get; set; }
        public Node Operation { get; set; }

        protected override string ToStr()
        {
            return $"Return ({Operation}) if ({Condition}) evaluates to null";
        }
    }
}
