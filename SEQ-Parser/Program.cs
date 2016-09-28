using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEQ_Parser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static fmMain myfmMain;

        public static CFunctions myCFun;

        public static ArrayList myAL_Key;

        public static ArrayList myAL_Data;

        public static ArrayList myAL_Undefined;

        public static ArrayList myAL_File;

        public static List<SeqData> myAL_Temp = new List<SeqData>();

        public static int intProcessedNumber = 0;

        public static string strFileName_Key;

        public static string strFileName_Data;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            myfmMain = new fmMain();
            myCFun = new CFunctions();

            Application.Run(myfmMain);
        }
    }
}
