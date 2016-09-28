using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SEQ_Parser
{
    public class CFunctions
    {

        public CFunctions()
        {

        }

        public void ImportKey(string _filename)
        {
            try
            {
                FileStream myFileStream_Key = new FileStream(_filename, FileMode.Open, FileAccess.Read,
                    FileShare.ReadWrite);
                StreamReader myStreamReader_Key = new StreamReader(myFileStream_Key);

                string strLine;
                Program.myAL_Key = new ArrayList();
                while ((strLine = myStreamReader_Key.ReadLine()) != null)
                {
                    strLine.Trim();
                    string[] strTemp = strLine.Split('\t');
                    CodeKey myCK = new CodeKey(strTemp[0], strTemp[1]);
                    Program.myAL_Key.Add(myCK);
                }
                MessageBox.Show(Program.myAL_Key.Count + " Keys have been imported", "Successful");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error...");
                Program.myfmMain.button_Key.Enabled = true;
            }
        }

        public void ImportData(string _filename)
        {
            try
            {
                FileStream myFileStream_Data = new FileStream(_filename, FileMode.Open, FileAccess.Read,
                    FileShare.ReadWrite);
                StreamReader myStreamReader_Data = new StreamReader(myFileStream_Data);

                string strLine;
                Program.myAL_Data = new ArrayList();
                while ((strLine = myStreamReader_Data.ReadLine()) != null)
                {
                    strLine.Trim();
                    string[] strTemp = strLine.Split('\t');

                    SeqData mySD = new SeqData(strTemp[0], strTemp[1].Replace("\"", ""), strTemp[2]);


                    Program.myAL_Data.Add(mySD);
                }
                MessageBox.Show(Program.myAL_Data.Count + " Data have been imported", "Successful");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error...");
                Program.myfmMain.button_Key.Enabled = true;
            }
        }

        public void CombineFile()
        {
            try
            {
                Program.myAL_File = new ArrayList();
                for (int i = 0; i < Program.myfmMain.listBox_FileList.Items.Count; i++)
                {
                    FileStream myFS_Data = new FileStream(Program.myfmMain.listBox_FileList.Items[i].ToString(), FileMode.Open,
                        FileAccess.Read, FileShare.ReadWrite);
                    StreamReader mySR_Data = new StreamReader(myFS_Data);
                    string strLine;
                    while ((strLine = mySR_Data.ReadLine()) != null)
                    {
                        strLine.Trim();
                        string[] strTemp = strLine.Split('\t');

                        SeqData mySD = new SeqData(strTemp[1], strTemp[4].Replace("\"", ""), strTemp[2]);


                        Program.myAL_File.Add(mySD);
                    }
                }

                

                Program.myAL_Temp = new List<SeqData>();
                
                
                for (int x = 0; x < Program.myAL_File.Count; x++)
                {
                    SeqData mySD = (SeqData)Program.myAL_File[x];
                    SeqData mySD1 = null;

                    if (x == 0)
                    {
                        Program.myAL_Temp.Add(mySD);
                    }
                    else
                    {
                        bool ToF = false;
                        for (int j = Program.myAL_Temp.Count-1; j >=0 ; j--)
                        {
                            mySD1 = Program.myAL_Temp[j];
                            if (mySD1.ID == mySD.ID)
                            {
                                string strData = mySD1.Data + ", " + mySD.Data;
                                mySD1 = new SeqData(mySD1.ID, strData, mySD1.Time);

                                Program.myAL_Temp.Insert(j, mySD1);
                                Program.myAL_Temp.RemoveAt(j + 1);
                                ToF = true;
                                break;
                            }
                        }
                        if (!ToF)
                        {
                            Program.myAL_Temp.Add(mySD);
                        }
                        Program.intProcessedNumber = x;
                    }
                    
                }

                string strFinalData = DataBuilder(Program.myAL_Temp);

                WriteToFile(strFinalData, "DATA");


                //MessageBox.Show(Program.myAL_File.Count+" Data have been imported!");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error...");
                throw;
            }
        }

        public string DataBuilder(ArrayList _al)
        {
            StringBuilder mySB = new StringBuilder();

            for (int i = 0; i < _al.Count; i++)
            {
                SeqData mySD = (SeqData)_al[i];
                mySB.Append(mySD.ID).Append("\t");

                string strData = Program.myCFun.AnalyseData(mySD.Data);
                mySB.Append(strData).Append("\t").Append(mySD.Time).Append("\r\n");
            }

            return mySB.ToString();
        }

        public string DataBuilder(List<SeqData> _al)
        {
            StringBuilder mySB = new StringBuilder();

            for (int i = 0; i < _al.Count; i++)
            {
                SeqData mySD = (SeqData)_al[i];
                mySB.Append(mySD.ID).Append("\t");

                
                mySB.Append(mySD.Data).Append("\t").Append(mySD.Time).Append("\r\n");
            }

            return mySB.ToString();
        }


        public void WriteToFile(string _data, string _filename)
        {
            FileInfo myFI;
            if (Program.strFileName_Data != null)
            {
                myFI = new FileInfo(Program.strFileName_Data);
            }
            else
            {
                myFI = new FileInfo(Program.myfmMain.listBox_FileList.Items[0].ToString());
            }
            FileStream myFS = new FileStream(myFI.DirectoryName+"/"+_filename+".txt", FileMode.Create);
            StreamWriter mySW = new StreamWriter(myFS);
            mySW.Write(_data);
            mySW.Flush();
            mySW.Close();
            myFS.Close();
            MessageBox.Show("Done! Please see the "+_filename+".txt file.");

        }

        public string AnalyseData(string _data)
        {
            string strData = _data.Replace(" ", "");

            string strResult = "";

            string[] strTemp = strData.Split(',');
            ArrayList myAL_Temp = new ArrayList();

            

            for (int i = 0; i < strTemp.Length; i++)
            {

                if (strTemp[i] != " " && strTemp[i] != "")
                {
                    string strKey = KeyReplacement(strTemp[i]);


                    if (i == 0)
                    {
                        CodeAnalysis myCA = new CodeAnalysis(strKey, 1);
                        myAL_Temp.Add(myCA);
                        strResult = strKey + "/1";
                    }
                    else
                    {
                        int j = myAL_Temp.Count - 1;
                        CodeAnalysis myCA = (CodeAnalysis) myAL_Temp[j];
                        if (strKey == myCA.Key)
                        {
                            int intNumber = myCA.Number + 1;
                            myAL_Temp.RemoveAt(j);
                            CodeAnalysis myCA1 = new CodeAnalysis(strKey, intNumber);
                            myAL_Temp.Add(myCA1);
                            if (intNumber - 1 < 10)
                            {
                                //strResult.Substring(0, strResult.Length - 3);
                                strResult = strResult.Remove(strResult.Length - 3, 3);
                            }
                            else if (intNumber - 1 < 100)
                            {
                                strResult = strResult.Remove(strResult.Length - 4, 4);
                            }
                            strResult += intNumber;
                        }
                        else
                        {
                            CodeAnalysis myCA2 = new CodeAnalysis(strKey, 1);
                            myAL_Temp.Add(myCA2);
                            strResult += strKey + "/1";
                        }

                    }
                    if (i < strTemp.Length - 1)
                    {
                        strResult += ", ";
                    }
                }
            }

            return strResult;
        }

        public string KeyReplacement(string _data)
        {
            string strKey = _data;

            for (int i = 0; i < Program.myAL_Key.Count; i++)
            {
                CodeKey myCK = (CodeKey) Program.myAL_Key[i];
                if (_data == myCK.Code1)
                {
                    strKey = myCK.Code2;
                    break;
                }
            }

            if (strKey == _data)
            {
                bool ToF = false;
                for (int j = 0; j < Program.myAL_Undefined.Count; j++)
                {
                    if (strKey == Program.myAL_Undefined[j].ToString())
                    {
                        ToF = true;
                        break;
                    }
                }
                if (!ToF)
                {
                    Program.myAL_Undefined.Add(strKey);
                }
            }
                
            return strKey;
        }

    }
}
