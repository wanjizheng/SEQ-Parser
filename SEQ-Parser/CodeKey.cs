using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEQ_Parser
{
    public class CodeKey
    {
        private string code1;
        private string code2;

        public CodeKey(string _code1, string _code2)
        {
            code1 = _code1;
            code2 = _code2;
        }

        public string Code1
        {
            get { return code1;}
            set { value = code1; }
        }

        public string Code2
        {
            get { return code2; }
            set { value = code2; }
        }

    }
}
