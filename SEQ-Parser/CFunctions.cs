using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                FileStream myFileStream_Key = new FileStream(_filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
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
                FileStream myFileStream_Data = new FileStream(_filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                StreamReader myStreamReader_Data = new StreamReader(myFileStream_Data);

                string strLine;
                Program.myAL_Data = new ArrayList();
                while ((strLine = myStreamReader_Data.ReadLine()) != null)
                {
                    strLine.Trim();
                    string[] strTemp = strLine.Split('\t');

                    SeqData mySD = new SeqData(strTemp[0],strTemp[1].Replace("\"",""),strTemp[2]);


                    Program.myAL_Data.Add(mySD);
                }
                MessageBox.Show(Program.myAL_Data.Count + " Keys have been imported", "Successful");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error...");
                Program.myfmMain.button_Key.Enabled = true;
            }
        }

        public void WriteToFile(string _data)
        {
            FileInfo myFI = new FileInfo(Program.strFileName_Data);
            FileStream myFS = new FileStream(myFI.DirectoryName+"/Result.txt", FileMode.Create);
            StreamWriter mySW = new StreamWriter(myFS);
            mySW.Write(_data);
            mySW.Flush();
            mySW.Close();
            myFS.Close();
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
