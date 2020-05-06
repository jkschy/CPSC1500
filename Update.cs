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
    public partial class Update : Form
    {
        ClsEmployee[] Data = new ClsEmployee[200];
        SubClsTxtFileIO objSubClsTxtFileIO = new SubClsTxtFileIO();
        int location = 0;
        int totalNum = 0;

        public Update()
        {
            InitializeComponent();
            for (int i = 0; i < Data.Length; i++)
            {
                Data[i] = new ClsEmployee();
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {
            objSubClsTxtFileIO.PopulateEmployees(Data);
            foreach (ClsEmployee test in Data)
            {
                if (test.EmployeeFName != "")
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            location++;
            if (location == totalNum)
            {
                location = 0;
                displayInfo();
            }
            else
            {
                displayInfo();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Data[location].VacationDaysEarned = textBox1.Text;
            } catch
            {
                Console.WriteLine("ERR");
                textBox1.Text = "";
                textBox1.Focus();
            }

            ClsTxtFileIO objFile = new ClsTxtFileIO();
            objFile.CreateFile();

            for (int i = 0; i <= totalNum - 1; i++)
            {
                objFile.AppendRecords(Data[i].EmployeeFName, Data[i].EmployeeLName, Data[i].Department, Data[i].PhoneNumber, Data[i].AnnualSalary, Data[i].VacationDaysEarned);
            }


        }
    }
}
