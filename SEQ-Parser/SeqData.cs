using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEQ_Parser
{
    public class SeqData
    {
        private string strid;
        private string strdata;
        private string strtime;
        public SeqData(string _id, string _data, string _time)
        {
            strid = _id;
            strdata = _data;
            strtime = _time;
        }

        public string ID
        {
            get { return strid;}
            set { value = strid; }
        }

        public string Data
        {
            get { return strdata;}
            set { value = strdata; }
        }

        public string Time
        {
            get { return strtime; }
            set { value = strtime; }
        }

    }
}
