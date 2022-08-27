using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentGL.Parser
{
    public class parser
    {
        public static dynamic Parse(string file)
        {
            string text = System.IO.File.ReadAllText(file);
            return text.Split();
        }

    }
}
