using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentGL.Syntax.Expression.Nodes
{
    public class PutNode : Node
    {
        public PutNode() : base(Classifier.Put)
        {
        }

        public Node Statement { get; set; }

        protected override string ToStr()
        {
            return $"Statement: ({Statement})";
        }
    }
}
