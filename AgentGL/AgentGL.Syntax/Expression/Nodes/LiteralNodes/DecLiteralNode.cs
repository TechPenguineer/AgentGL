using System.Globalization;
using AgentGL.Syntax.Lexeme;

namespace AgentGL.Syntax.Expression.Nodes.LiteralNodes
{
    public class DecLiteralNode : LiteralNode<decimal>
    {
        public DecLiteralNode(Token token) : base(Classifier.DecLiteral)
        {
            Value = decimal.Parse(token.Value, CultureInfo.InvariantCulture);
        }
    }
}
