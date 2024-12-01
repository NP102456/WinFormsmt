using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsmt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //txtResult.Text = Triangle(5);
            txtResult.Text = Triangle("A", 9);
        }

        string Triangle(int size)
        {
            string txt_result = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txt_result += "*";
                }
                txt_result += Environment.NewLine;
            }
            return txt_result;
        }

        string Triangle(string letter, int size)
        {
            string txt_result = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txt_result += letter;
                }
                txt_result += Environment.NewLine;
            }
            return txt_result;
        }

        string Triangle(string letter)
        {
            string txt_result = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txt_result += letter;
                }
                txt_result += Environment.NewLine;
            }
            return txt_result;
        }

        string Triangle()
        {
            string txt_result = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txt_result += "*";
                }
                txt_result += Environment.NewLine;
            }
            return txt_result;
        }
    }
}