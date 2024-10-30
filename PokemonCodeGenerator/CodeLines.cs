using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCodeGenerator
{
    public class CodeLines
    {
        public string[] Lines {get; set;}
        public int Indent { get; set; }
        public CodeLines(string[] linearray, int indentArray) 
        {
            this.Lines = linearray;
            this.Indent = indentArray;
        }
    }
}
