using AgentGL.Syntax.Lexeme;

namespace AgentGL.Syntax.Expression.Nodes.LiteralNodes
{
    public class BoolLiteralNode : LiteralNode<bool>
    {
        public BoolLiteralNode(Token token) : base(Classifier.BoolLiteral)
        {
            Value = bool.Parse(token.Value);
        }
    }
}
