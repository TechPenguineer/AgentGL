using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentGL.Syntax.Expression
{
    public class RootNode : BlockNode
    {
        public RootNode() : base(Classifier.Root)
        {
        }

        public override string ToString()
        {
            return $"ROOT\n{base.ToStr()}";
        }
    }
}
