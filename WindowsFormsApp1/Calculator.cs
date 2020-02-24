using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public enum Season { Spring, Summer, Fall, Winter } 

    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;

        public Calculator()
        {
            InitializeComponent();

            int number1;
        }


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

        public int sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }
        private void NumButton1_Click(object sender, EventArgs e)
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
           
        }

        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }
            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }
            else
            {

                NumScreen.Text = NumScreen.Text + num;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NumScreen.Text);
            Result = Result + num;

            NumScreen.Text = Result.ToString();
            isNewNum = true;
        }

       
    }

}
