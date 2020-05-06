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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsTxtFileIO objFile = new ClsTxtFileIO();//Instantiate custom class with Text File IO functions
            objFile.AppendRecords(textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, "0");
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox7.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClsTxtFileIO objFile = new ClsTxtFileIO();
            objFile.OverWriteRecords(textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text);
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox7.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClsTxtFileIO objFile = new ClsTxtFileIO();
            objFile.CreateFile();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

