using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            Program.myAL_Undefined = new System.Collections.ArrayList();

            string strData = Program.myCFun.DataBuilder(Program.myAL_Data);

            Program.myCFun.WriteToFile(strData, "Result");


            StringBuilder mySB_Undefined = new StringBuilder();
            for (int i = 0; i < Program.myAL_Undefined.Count; i++)
            {
                mySB_Undefined.Append(Program.myAL_Undefined[i]).Append("\r\n");
            }

            richTextBox_Undefined.Text = mySB_Undefined.ToString();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            openFileDialog_Data.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog_Data.ShowDialog() == DialogResult.OK)
            {
                listBox_FileList.Items.Add(openFileDialog_Data.FileName);
            }
            else
            {
                
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (listBox_FileList.SelectedItem != null)
            {
                listBox_FileList.Items.Remove(listBox_FileList.SelectedItem);
            }
        }

        private void button_Combine_Click(object sender, EventArgs e)
        {
            if (listBox_FileList.Items.Count > 0)
            {
                button_Combine.Enabled = false;
                Thread myThread_Combine = new Thread(Program.myCFun.CombineFile);

                myThread_Combine.Start();
                timer_ProgressBar.Enabled = true;
                 
   
            }
            else
                MessageBox.Show("Please add some files first!");
        }

        private void timer_ProgressBar_Tick(object sender, EventArgs e)
        {
            while (Program.myAL_File.Count == 0)
            {
                Thread.Sleep(2000);
            }
            Program.myfmMain.label_RawData.Text = Program.myAL_File.Count.ToString();
            Program.myfmMain.label_Combined.Text = Program.myAL_Temp.Count.ToString();


            toolStripStatusLabel_ProgressBar.Text = "0 / " + Program.myAL_File.Count;

            int intCount = (int) Math.Round((double) Program.intProcessedNumber/Program.myAL_File.Count*100);
            toolStripStatusLabel_ProgressBar.Text = (Program.intProcessedNumber+1).ToString() + " / " +
                                                    Program.myAL_File.Count.ToString();
            if (intCount > 100)
                intCount = 100;
            toolStripProgressBar_Main.Value = intCount;

        }
    }
}
