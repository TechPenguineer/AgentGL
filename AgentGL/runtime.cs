using Figgle;
namespace AgentGL.runtime
{
    public class AgentGL
    {
        public static void Main(string[] args)
        {
            dynamic data = Parser.parser.Parse(args[0]);
            foreach(var x in data)
            {
                Console.WriteLine(x);
            }
        }
    }
}