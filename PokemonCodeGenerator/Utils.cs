using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCodeGenerator
{
    public class Utils
    {
        public Utils()
        {
        }

        public string numTabs(int x)
        {
            string tabs = "";
            for (int i = 0; i < x; i++)
            {
                tabs += "\t";
            }
            return tabs;
        }
        public string insertCodeLine(string line, string code, int indent)
        {
            StringBuilder sb = new StringBuilder(code);
            line = line.PadLeft(line.Length + (indent * 2));
            if (code.Length > 0)
            {
                sb.AppendLine();
            }
            sb.Append(line);
            return sb.ToString();
        }

        public string insertCodeLines(string[] lines, string code, int indent)
        {
            string new_code = code;
            for (int i = 0; i < lines.Length; i++)
            {
                new_code = insertCodeLine(lines[i], new_code, indent);
            }
            return new_code;
        }
    }
}
