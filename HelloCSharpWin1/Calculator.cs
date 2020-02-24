using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin
{
    public partial class Calculator : Form
    {

        public int result = 0;
        public bool isNewNumber = true;


        public Calculator()
        {
            InitializeComponent();
        }


        // SUM ////////////////////////////////////////////////////////////////////// 
        public int Add(int number1, int number2)
        {

            int sum = number1 + number2;
            return sum;
        }

        public float Add(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }
        /////////////////////////////////////////////////////////////////////////////



        // SUB ////////////////////////////////////////////////////////////////////// 
        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }

        public float Sub(float number1, float number2)
        {
            float sub = number1 - number2;
            return sub;
        }
        /////////////////////////////////////////////////////////////////////////////


        private void NumButton1_Click(object sender, EventArgs e)
        {
            setNum("1");
        }

        private void NumButton2_Click(object sender, EventArgs e)
        {
            setNum("2");

        }

        public void setNum(string num)
        {
            if (isNewNumber)
            {
                NumScreen.Text = num;
                isNewNumber = false;
            }
            else
            {
                if (NumScreen.Text == "0")
                {
                    NumScreen.Text = num;
                }
                else
                {
                    NumScreen.Text += num;
                }
            }

        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NumScreen.Text);

            result = result + num;

            NumScreen.Text = result.ToString();
            isNewNumber = true;
        }
    }
}
