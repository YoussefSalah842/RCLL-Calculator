using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCLL_Calculator
{
    public partial class CalculatorForm : Form
    {
        private string currentInput = string.Empty;
        private string firstOperand = string.Empty;
        private string operation = string.Empty;

        public CalculatorForm()
        {
            InitializeComponent();
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            string[] buttonTexts = { "7", "8", "9", "/", "4", "5", "6", "*", "1", "2", "3", "-", "C", "0", "=", "+" };
            foreach (string text in buttonTexts)
            {
                Button button = new Button();
                button.Text = text;
                button.Font = new System.Drawing.Font("Segoe UI", 16F);
                button.Dock = DockStyle.Fill;
                button.Click += Button_Click;
                buttons.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string value = button.Text;

            if (value == "C")
            {
                Clear();
            }
            else if (value == "=")
            {
                Calculate();
            }
            else if ("+-*/".Contains(value))
            {
                operation = value;
                firstOperand = currentInput;
                currentInput = string.Empty;
            }
            else
            {
                currentInput += value;
            }
            textBoxDisplay.Text = currentInput;
        }

        private void Clear()
        {
            currentInput = string.Empty;
            firstOperand = string.Empty;
            operation = string.Empty;
            textBoxDisplay.Text = string.Empty;
        }

        private void Calculate()
        {
            try
            {
                double operand1 = Convert.ToDouble(firstOperand);
                double operand2 = Convert.ToDouble(currentInput);
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = operand1 + operand2;
                        break;
                    case "-":
                        result = operand1 - operand2;
                        break;
                    case "*":
                        result = operand1 * operand2;
                        break;
                    case "/":
                        result = operand1 / operand2;
                        break;
                }

                textBoxDisplay.Text = result.ToString();
                currentInput = result.ToString();
                firstOperand = string.Empty;
                operation = string.Empty;
            }
            catch (Exception)
            {
                textBoxDisplay.Text = "Error";
                Clear();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "";
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Paste();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About AboutForm = new About();
            AboutForm.Show();
        }
    }
}