using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentGL.Syntax.Expression.Nodes.LiteralNodes
{
    public class OperationNodeNode : LiteralNode<Lexeme.Classifier>
    {
        public readonly string Representation;

        public OperationNodeNode(Lexeme.Classifier classifier, string val) : base(Classifier.Operation)
        {
            Value = classifier;
            Representation = val;
        }
    }
}
