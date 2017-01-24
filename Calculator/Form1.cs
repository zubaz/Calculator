using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operationPerformed = "";
        bool isoperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttClick(object sender, EventArgs e)
        {
            if ((txtBoxResult.Text == "0") || (isoperationPerformed))
                txtBoxResult.Clear();
            isoperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            
            {
                if(!txtBoxResult.Text.Contains("."))
                    txtBoxResult.Text = txtBoxResult.Text + button.Text;
            }
            else
            txtBoxResult.Text = txtBoxResult.Text + button.Text;
        }

        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(txtBoxResult.Text);
            labCurrentOperation.Text = resultValue + " " + operationPerformed;
            isoperationPerformed = true;
            
            }
        private void bttC_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = "0";
            resultValue = 0;
        }

        private void bttCe_Click(object sender, EventArgs e)
        {
            txtBoxResult.Text = "0";
        }

        private void bttEquals_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    txtBoxResult.Text = (resultValue + Double.Parse(txtBoxResult.Text)).ToString();
                    break;
                case "-":
                    txtBoxResult.Text = (resultValue - Double.Parse(txtBoxResult.Text)).ToString();
                    break;
                case "/":
                    txtBoxResult.Text = (resultValue / Double.Parse(txtBoxResult.Text)).ToString();
                    break;
                case "*":
                    txtBoxResult.Text = (resultValue * Double.Parse(txtBoxResult.Text)).ToString();
                    break;

            }
        }
    }
}
