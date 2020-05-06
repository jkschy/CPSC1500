using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProofConceptFinalProj
{
    public partial class Form3 : Form
    {
        private ClsEmployee[] empArray2 = new ClsEmployee[200];
        private int recordCount = 0;

        public Form3()
        {
            InitializeComponent();


            //Initialize all elements to instances of the ClsEmployee Class:
            for (int i = 0; i < empArray2.Length; i++)
            {
                empArray2[i] = new ClsEmployee();
            }
        }
    


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string inRec;
            ClsTxtFileIO objFile = new ClsTxtFileIO();
            objFile.OpenForRead();
            try
            {
                inRec = objFile.ReadRecord(); ;//stores each line read from file - returns "null at end of file

                while (inRec != null)
                {
                    //this.Text += "*";
                    listBox1.Items.Add(inRec);
                    inRec = objFile.ReadRecord();
                }

                objFile.CloseForRead();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Trap: " + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SubClsTxtFileIO objSubClsTxtFileIO = new SubClsTxtFileIO();

            ClsEmployee[] empArray = new ClsEmployee[200];

            //Initialize all elements to instances of the ClsEmployee Class:
            for (int i = 0; i < empArray.Length; i++)
            {
                empArray[i] = new ClsEmployee();
            }

            listBox1.Items.Clear();



            objSubClsTxtFileIO.PopulateEmployees(empArray);

            //MessageBox.Show("Made It");
            for (int i = 0; i < objSubClsTxtFileIO.RecordsRead; i++)
            {

                listBox1.Items.Add(empArray[i].EmployeeFName + " " + empArray[i].PhoneNumber);
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SubClsTxtFileIO objSubClsTxtFileIO = new SubClsTxtFileIO();

            

            try
            {
 
                objSubClsTxtFileIO.PopulateEmployees(empArray2);
                this.Text = objSubClsTxtFileIO.RecordsRead.ToString() + "   " + recordCount.ToString();

                if ((recordCount+1) < objSubClsTxtFileIO.RecordsRead)
                {
                    label5.Text = empArray2[recordCount].EmployeeFName;
                    label6.Text = empArray2[recordCount].EmployeeLName;
                    label7.Text = empArray2[recordCount].Department;
                    label8.Text = empArray2[recordCount].PhoneNumber;
                    label9.Text = empArray2[recordCount].AnnualSalary;
                    label11.Text = empArray2[recordCount].VacationDaysEarned;
                    label13.Text = empArray2[recordCount].CalculateVacationValue().ToString();
                }
                else
                {
                    recordCount = 0;
                    label5.Text = empArray2[recordCount].EmployeeFName;
                    label6.Text = empArray2[recordCount].EmployeeLName;
                    label7.Text = empArray2[recordCount].Department;
                    label8.Text = empArray2[recordCount].PhoneNumber;
                    label9.Text = empArray2[recordCount].AnnualSalary;
                    label11.Text = empArray2[recordCount].VacationDaysEarned;
                    label13.Text = empArray2[recordCount].CalculateVacationValue().ToString();
                }
                recordCount++;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }





        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}