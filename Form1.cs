using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double output = 0;
        double output2 = 0;
        int i = 0;
        int temp = 0;
        int clearTemp = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void deffaultButton(string symbol)
        {
            if (i==0) 
            {
                outputLabel.Text += symbol;
                output = double.Parse(outputLabel.Text);
            } else
            {
                outputLabel.Text += symbol;
                output2 = double.Parse(outputLabel.Text);
            }
            
        }

        private void actionButton(string symbol)
        {
            if (i == 0)
            {
                i++;
                outputLabel.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)  /// 1
        {
            deffaultButton("1");
        }

        private void twoButton_Click(object sender, EventArgs e) /// 2
        {
            deffaultButton("2");
        }

        private void threeButton_Click(object sender, EventArgs e) /// 3
        {
            deffaultButton("3");
        }

        private void fourButton_Click(object sender, EventArgs e) /// 4
        {
            deffaultButton("4");
        }

        private void fiveButton_Click(object sender, EventArgs e) /// 5
        {
            deffaultButton("5");
        }

        private void button6_Click(object sender, EventArgs e) /// 6
        {
            deffaultButton("6");
        }

        private void button1_Click(object sender, EventArgs e) /// 7
        {
            deffaultButton("7");
        }
        private void button2_Click(object sender, EventArgs e) /// 8
        {
            deffaultButton("8");
        }
        private void button4_Click(object sender, EventArgs e) /// 9
        {
            deffaultButton("9");
        }

        private void nullButton_Click(object sender, EventArgs e)/// 0
        {
            deffaultButton("0");
        }

        private void button20_Click(object sender, EventArgs e)/// (
        {
            deffaultButton("(");
        }

        private void parenthesisButtonR_Click(object sender, EventArgs e)/// )
        {
            deffaultButton(")");
        }

        private void smileButton_Click(object sender, EventArgs e)/// :)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)/// clear
        {
            output = 0;
            output2 = 0;
            outputLabel.Text = "";
            temp = 0; 
            i = 0; 
        }

        private void divideButton_Click(object sender, EventArgs e)/// /
        {
            actionButton("/"); temp = 1;
        }

        private void multiplyButton_Click(object sender, EventArgs e)/// *
        {
            actionButton("*"); temp = 2;
        }

        private void plusButton_Click(object sender, EventArgs e)/// +
        {
            actionButton("+"); temp = 3;
        }

        private void minusButton_Click(object sender, EventArgs e)/// -
        {
            actionButton("-"); temp = 4;
        }

        private void dotButton_Click(object sender, EventArgs e)/// .
        {
            /*string dot = ".";
            actionButton(dot);
            deffaultButton(dot); soon*/
        }

        private void equalsButton_Click(object sender, EventArgs e)/// =
        {
            double result = 0;
            if (temp == 1)
            {
                result = output / output2;
                outputLabel.Text = result.ToString();
            }
            if (temp == 2)
            {
                result = output * output2;
                outputLabel.Text = result.ToString();
            }
            if (temp == 3)
            {
                result = output + output2;
                outputLabel.Text = result.ToString();
            }
            if (temp == 4)
            {
                result = output - output2;
                outputLabel.Text = result.ToString();
            }
            temp = 0;
            output = 0;
            output2 = 0;
        }

        private void outputLabel_Click(object sender, EventArgs e)/// output
        {

        }
    }
}
