using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEQ_Parser
{
    public class CodeAnalysis
    {
        private string key;
        private int number;

        public CodeAnalysis(string _key, int _number)
        {
            key = _key;
            number = _number;
        }

        public string Key
        {
            get { return key; }
            set { value = key; }
        }

        public int Number
        {
            get { return number;}
            set { value = number; }
        }


    }
}
