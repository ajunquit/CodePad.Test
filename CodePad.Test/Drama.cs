using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodePad.Test
{
    class Drama
    {
        public string AddDrama(string text)
        {
            string patron = "(!+)";
            string resultado = Regex.Replace(text, patron, m => m.Value + "!");
            return resultado.Replace('.', '!');
        }
    }
}
