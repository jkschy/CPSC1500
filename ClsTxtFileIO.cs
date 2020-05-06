using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProofConceptFinalProj
{
    public class  ClsTxtFileIO
    {
        private StreamReader streamIn;
        protected int mNumRecordsRead = 0;

        public int RecordsRead
        {
            get
            {
                return mNumRecordsRead;
            }
            set
            {
                if(value==0)
                {
                    mNumRecordsRead = value;
                }
            }

        }
        public void AppendRecords(string pFName, string pLName,  string pDept, string pPhone, string pSalary, string pDays)
        {
            StreamWriter StreamOut = File.AppendText(@"EmpData.txt");

            StreamOut.WriteLine(pFName + " " + pLName + " " + pDept +" " + pPhone + " " + pSalary + " " + pDays);

            StreamOut.Flush();
            StreamOut.Close();
             
        }

        public void OverWriteRecords(string pFName, string pLName, string pDept, string pPhone)
        {
            StreamWriter StreamOut = File.CreateText(@"EmpData.txt");
            StreamOut.WriteLine(pFName + " " + pLName + " " + pDept + " " + pPhone);

            StreamOut.Flush();
            StreamOut.Close();

        }

        public void OpenForRead()
        {
           
           streamIn = File.OpenText(@"EmpData.txt");
        }
        public string ReadRecord()
        {
            mNumRecordsRead++;
            return streamIn.ReadLine();
        }

        public void CloseForRead()
        {
            streamIn.Close();
        }

        public void CreateFile()
        {
            StreamWriter StreamOut = File.CreateText(@"EmpData.txt");
            StreamOut.Close();
        }


    }
}
