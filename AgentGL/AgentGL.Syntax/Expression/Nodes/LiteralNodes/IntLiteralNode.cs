
using AgentGL.Syntax.Lexeme;

namespace AgentGL.Syntax.Expression.Nodes.LiteralNodes
{
    public class IntLiteralNode : LiteralNode<int>
    {
        public IntLiteralNode(Token token) : base(Classifier.IntLiteral)
        {
            Value = int.Parse(token.Value);
        }
    }
}
