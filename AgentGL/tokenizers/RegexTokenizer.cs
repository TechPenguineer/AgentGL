using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using AgentGL.Parsing.Tokens;

namespace AgentGL.Parsing.Tokenizers
{
    public class RegexTokenizer : ITokenizer
    {
        private List<TokenDefinition> _tokenDefinitions;

        public RegexTokenizer()
        {
            _tokenDefinitions = new List<TokenDefinition>();
            _tokenDefinitions.Add(new TokenDefinition(TokenType.And, "and", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.Application, "app|application", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.Between, "between", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.CloseParenthesis, "\\)", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.Comma, ",", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.Equals, "=", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.ExceptionType, "ex|exception", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.Fingerprint, "fingerprint", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.NotIn, "not in", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.In, "in", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.Like, "like", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.Limit, "limit", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.Match, "match", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.Message, "msg|message", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.NotEquals, "!=", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.NotLike, "not like", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.OpenParenthesis, "\\(", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.Or, "or", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.StackFrame, "sf|stackframe", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.DateTimeValue, "\\d\\d\\d\\d-\\d\\d-\\d\\d \\d\\d:\\d\\d:\\d\\d", 2));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.StringValue, "'([^']*)'", 1));
            _tokenDefinitions.Add(new TokenDefinition(TokenType.Number, "\\d+", 2));
        }


    }
}
