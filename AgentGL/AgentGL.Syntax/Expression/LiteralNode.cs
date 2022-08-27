using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentGL.Syntax.Expression
{
    public abstract class LiteralNode<T> : Node
    {
        protected LiteralNode(Classifier classifier) : base(classifier)
        {
        }

        public T Value { get; set; }

        protected override string ToStr()
        {
            return string.Empty;
        }

        public override string ToString()
        {
            return $"Value: {Value}";
        }
    }
}
