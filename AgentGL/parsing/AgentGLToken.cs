using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentGL.Parsing.Tokens
{
    public class AgentGLToken
    {
        public AgentGLToken(TokenType tokenType)
        {
            TokenType = tokenType;
            Value = string.Empty;
        }
        public AgentGLToken(TokenType tokenType, string value)
        {
            TokenType=tokenType;
            Value = value;
        }

        public TokenType TokenType { get; set; }
        public string Value { get; set; }

        public AgentGLToken Clone()
        {
            return new AgentGLToken(TokenType, Value);
        }
    }
}
