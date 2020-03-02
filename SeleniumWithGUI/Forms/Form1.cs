using SeleniumWithGUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumWithGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtBoxAppUrl.Text = "https://www.goal.com/en/tables";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InputItems input = new InputItems();
            input.AppUrl = txtBoxAppUrl.Text;
            input.OutputPath = outputpath.Text;
            input.isHeadless = checkBoxBrowserless.Checked;
            if (input.AppUrl.Equals(""))
            {
                Message.Text = "URL is empty";
                Message.Visible = true;
            }
            else if (input.OutputPath.Equals(""))
            {
                Message.Text = "Destination Folder is not selected";
                Message.Visible = true;
            }
            else
            {
                Message.Visible = false;
                new Scrapper().Run(input);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "SELECT DESTINATION FOLDER FOR OUTPUT FILE";
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                outputpath.Text = fbd.SelectedPath + "\\";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
