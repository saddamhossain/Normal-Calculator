using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculatorApp
{

    public partial class ScientificCalculatorUI : Form
    {
        private string opr;
        private double operand1;
        private double operand2;
        private double result;

       
        public ScientificCalculatorUI()
        {
            InitializeComponent();
            DisableField();
        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = string.Empty;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "0";
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text += "9";
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text.Contains("."))
            {
                resultTextBox.Text = resultTextBox.Text;
            }
            else
            {
                resultTextBox.Text = resultTextBox.Text + ".";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                operand1 = Convert.ToDouble(resultTextBox.Text);
            }
            catch (Exception exception)
            {

                MessageBox.Show("Please first give any digit then calculate");
            }
            

            opr = "+";
            resultTextBox.Clear();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                operand1 = Convert.ToDouble(resultTextBox.Text);
            }
            catch (Exception exception)
            {

                MessageBox.Show("Please first give any digit then calculate");
            }
            

            opr = "-";
            resultTextBox.Clear();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                operand1 = Convert.ToDouble(resultTextBox.Text);
            }
            catch (Exception)
            {

               
            }
           

            opr = "*";
            resultTextBox.Clear();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            try
            {
                operand1 = Convert.ToDouble(resultTextBox.Text);
            }
            catch (Exception exception)
            {

                MessageBox.Show("Please first give any digit then calculate");
            }
          

            opr = "/";
            resultTextBox.Clear();
        }

        private void percentageButton_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(resultTextBox.Text);
            opr = "%";
            resultTextBox.Clear();
        }

        private void acButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Enabled = true;
            resultTextBox.Text = "0";
            oneButton.Enabled = true;
            twoButton.Enabled = true;
            threeButton.Enabled = true;
            fourButton.Enabled = true;
            fiveButton.Enabled = true;
            sixButton.Enabled = true;
            sevenButton.Enabled = true;
            eightButton.Enabled = true;
            nineButton.Enabled = true;
            zeroButton.Enabled = true;
        }

        private void piButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "3.1416";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            operand2 = Convert.ToDouble(resultTextBox.Text);
            switch (opr)
            {
                case "+":
                {
                    result = operand1 + operand2;
                    resultTextBox.Text = result.ToString();
                    break;
                }
                case "-":
                {
                    result = operand1 - operand2;
                    resultTextBox.Text = result.ToString();
                    break;
                }

                case "*":
                {
                    result = operand1 * operand2;
                    resultTextBox.Text = result.ToString();
                    break;
                }
                case "/":
                {
                    if (operand2 == 0)
                    {
                        resultTextBox.Text = "0.0";
                    }
                    else
                    {
                        result = operand1 / operand2;
                        resultTextBox.Text = result.ToString();
                        
                    }
                    break;
                   
                }
                case "%":
                {

                    result = operand1 % operand2;
                    resultTextBox.Text = result.ToString();
                    break;
                }

            }
        }

        private void DisableField()
        {           
            resultTextBox.ReadOnly = true;
        }

    }
}
