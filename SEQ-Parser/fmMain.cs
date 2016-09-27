using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEQ_Parser
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void button_Key_Click(object sender, EventArgs e)
        {
            button_Key.Enabled = false;
            openFileDialog_Key.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog_Key.ShowDialog() == DialogResult.OK)
            {
                Program.strFileName_Key = openFileDialog_Key.FileName;
                Program.myCFun.ImportKey(Program.strFileName_Key);
                button_Data.Enabled = true;
            }
            else
            {
                button_Key.Enabled = true;
            }
        }

        private void button_Data_Click(object sender, EventArgs e)
        {
            button_Data.Enabled = false;
            openFileDialog_Data.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog_Data.ShowDialog() == DialogResult.OK)
            {
                Program.strFileName_Data = openFileDialog_Data.FileName;
                Program.myCFun.ImportData(Program.strFileName_Data);
                button_Export.Enabled = true;
            }
            else
            {
                button_Data.Enabled = true;
            }

        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            button_Export.Enabled = false;
            StringBuilder mySB = new StringBuilder();
            Program.myAL_Undefined = new System.Collections.ArrayList();

            for (int i = 0; i < Program.myAL_Data.Count; i++)
            {
                SeqData mySD = (SeqData) Program.myAL_Data[i];
                mySB.Append(mySD.ID).Append("\t");

                string strData = Program.myCFun.AnalyseData(mySD.Data);
                mySB.Append(strData).Append("\t").Append(mySD.Time).Append("\r\n");
            }

            Program.myCFun.WriteToFile(mySB.ToString());

            MessageBox.Show("Done! Please see the Result.txt file.");

            StringBuilder mySB_Undefined = new StringBuilder();
            for (int i = 0; i < Program.myAL_Undefined.Count; i++)
            {
                mySB_Undefined.Append(Program.myAL_Undefined[i]).Append("\r\n");
            }

            richTextBox_Undefined.Text = mySB_Undefined.ToString();
        }
    }
}
