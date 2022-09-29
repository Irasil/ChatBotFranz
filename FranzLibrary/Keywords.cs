using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranzLibrary
{
    public class Keyword
    {
        public string? Frage { get; set; }
        public string? Antwort { get; set; }
    }

    public class Keywordlist
    {
        public List<Keyword>? Keywords { get; set; }
    }
}
