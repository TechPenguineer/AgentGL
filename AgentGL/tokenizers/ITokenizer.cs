using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentGL.Parsing.Tokenizers
{
    public interface ITokenizer
    {
        IEnumerable<Parsing.Tokens.AgentGLToken> Tokenize(string queryDsl);
    }
}
