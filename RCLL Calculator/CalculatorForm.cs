using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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

        private void tryCalculatorConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            this.ForeColor = System.Drawing.Color.Black;
            menuStrip1.BackColor = System.Drawing.Color.White;
            menuStrip1.ForeColor = System.Drawing.Color.Black;
            newToolStripMenuItem.BackColor = System.Drawing.Color.White;
            newToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            editToolStripMenuItem.BackColor = System.Drawing.Color.White;
            editToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            settingsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            settingsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            helpToolStripMenuItem.BackColor = System.Drawing.Color.White;
            helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            fileToolStripMenuItem.BackColor = System.Drawing.Color.White;
            fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            exitToolStripMenuItem.BackColor = System.Drawing.Color.White;
            exitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            cutToolStripMenuItem.BackColor = System.Drawing.Color.White;
            cutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            copyToolStripMenuItem.BackColor = System.Drawing.Color.White;
            copyToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            pasteToolStripMenuItem.BackColor = System.Drawing.Color.White;
            pasteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            clearToolStripMenuItem.BackColor = System.Drawing.Color.White;
            clearToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            tryCalculatorConsoleToolStripMenuItem.BackColor = System.Drawing.Color.White;
            tryCalculatorConsoleToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            themeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            themeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            lightToolStripMenuItem.BackColor = System.Drawing.Color.White;
            lightToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            darkToolStripMenuItem.BackColor = System.Drawing.Color.White;
            darkToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            aboutToolStripMenuItem.BackColor = System.Drawing.Color.White;
            aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            textBoxDisplay.BackColor = System.Drawing.Color.White;
            textBoxDisplay.ForeColor = System.Drawing.Color.Black;
            buttons.BackColor = System.Drawing.Color.White;
            buttons.ForeColor = System.Drawing.Color.Black;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Black;
            this.ForeColor = System.Drawing.Color.White;
            menuStrip1.BackColor = System.Drawing.Color.Black;
            menuStrip1.ForeColor = System.Drawing.Color.White;
            newToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            newToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            editToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            settingsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            helpToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            fileToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            exitToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            cutToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            cutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            copyToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            copyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            pasteToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            pasteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            clearToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            clearToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            tryCalculatorConsoleToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            tryCalculatorConsoleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            themeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            themeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            lightToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            lightToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            darkToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            darkToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            aboutToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            textBoxDisplay.BackColor = System.Drawing.Color.Black;
            textBoxDisplay.ForeColor = System.Drawing.Color.White;
            buttons.BackColor = System.Drawing.Color.Black;
            buttons.ForeColor = System.Drawing.Color.White;
        }
    }
}