using System;
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


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            myfmMain = new fmMain();

            Application.Run(myfmMain);
        }
    }
}
