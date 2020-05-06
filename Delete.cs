using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProofConceptFinalProj
{
    public partial class Delete : Form
    {
        ClsEmployee[] Data = new ClsEmployee[200];
        SubClsTxtFileIO objSubClsTxtFileIO = new SubClsTxtFileIO();
        int location = 0;
        int totalNum = 0;

        public Delete()
        {
            InitializeComponent();
            for (int i = 0; i < Data.Length; i++)
            {
                Data[i] = new ClsEmployee();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Load(object sender, EventArgs e)
        {
            objSubClsTxtFileIO.PopulateEmployees(Data);
            foreach(ClsEmployee test in Data)
            {
                if(test.EmployeeFName != "")
                {
                    totalNum++;
                }
            }
            displayInfo();
        }
        
        private void displayInfo()
        {
            label1.Text = Data[location].EmployeeFName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            location++;
            if (location == totalNum)
            {
                location = 0;
                displayInfo();
            } else
            {
                displayInfo();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data[location] = new ClsEmployee();
            
            if (location != 2)
            {
                for (int i = location; i <= totalNum - 1; i++)
                {
                   Data[i] = Data[i + 1];
                }
            } else
            {
                location = -1;
            }
            totalNum--;

            ClsTxtFileIO objFile = new ClsTxtFileIO();
            objFile.CreateFile();

            for(int i = 0; i <= totalNum - 1;i++)
            {
                objFile.AppendRecords(Data[i].EmployeeFName, Data[i].EmployeeLName, Data[i].Department, Data[i].PhoneNumber, Data[i].AnnualSalary, Data[i].VacationDaysEarned);
            }

        }
    }
}
