using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public string StoredOperation { get; set; }
        public decimal StoredOperand { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void number1_Click(object sender, EventArgs e)
        {
            displayBox.Text += number1.Text;
        }

        private void number2_Click(object sender, EventArgs e)
        {
            displayBox.Text += number2.Text;
        }

        private void number3_Click(object sender, EventArgs e)
        {
            displayBox.Text += number3.Text;
        }

        private void number4_Click(object sender, EventArgs e)
        {
            displayBox.Text += number4.Text;
        }

        private void number5_Click(object sender, EventArgs e)
        {
            displayBox.Text += number5.Text;
        }

        private void number6_Click(object sender, EventArgs e)
        {
            displayBox.Text += number6.Text;
        }

        private void number7_Click(object sender, EventArgs e)
        {
            displayBox.Text += number7.Text;
        }

        private void number8_Click(object sender, EventArgs e)
        {
            displayBox.Text += number8.Text;
        }

        private void number9_Click(object sender, EventArgs e)
        {
            displayBox.Text += number9.Text;
        }

        private void number0_Click(object sender, EventArgs e)
        {
            displayBox.Text += number0.Text;
        }

        private void operationDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() == "+" || e.KeyChar.ToString() == "-" || e.KeyChar.ToString() == "*" || e.KeyChar.ToString() == "/")
            {
                if (string.IsNullOrEmpty(operationDisplay.Text) && !string.IsNullOrEmpty(displayBox.Text))
                {
                    StoredOperation = e.KeyChar.ToString();
                    StoredOperand = decimal.Parse(displayBox.Text);
                    displayBox.Clear();
                }
                else if(!string.IsNullOrEmpty(operationDisplay.Text) && string.IsNullOrEmpty(displayBox.Text))
                {
                    operationDisplay.Clear();
                    StoredOperation = e.KeyChar.ToString();
                    
                }
                else if (!string.IsNullOrEmpty(operationDisplay.Text) && !string.IsNullOrEmpty(displayBox.Text))
                {
                    operationDisplay.Clear();
                    StoredOperation = e.KeyChar.ToString();
                    equalsButton_Click(sender, e);
                    StoredOperation = e.KeyChar.ToString();
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void displayBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                equalsButton_Click(sender, e);
            }

            if (e.KeyCode == Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operationDisplay.Text) && !string.IsNullOrEmpty(displayBox.Text))
            {
                StoredOperation = plusButton.Text;
                StoredOperand = decimal.Parse(displayBox.Text);
                operationDisplay.Text = plusButton.Text;
                displayBox.Clear();
            }
            else if (!string.IsNullOrEmpty(operationDisplay.Text) && string.IsNullOrEmpty(displayBox.Text))
            {
                operationDisplay.Clear();
                operationDisplay.Text = plusButton.Text;
                StoredOperation = plusButton.Text;
            }
            else if (!string.IsNullOrEmpty(operationDisplay.Text) && !string.IsNullOrEmpty(displayBox.Text))
            {
                operationDisplay.Clear();
                equalsButton_Click(sender, e);
                operationDisplay.Text = plusButton.Text;
                StoredOperation = plusButton.Text;
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operationDisplay.Text) && !string.IsNullOrEmpty(displayBox.Text))
            {
                StoredOperation = minusButton.Text;
                StoredOperand = decimal.Parse(displayBox.Text);
                operationDisplay.Text = minusButton.Text;
                displayBox.Clear();
            }
            else if (!string.IsNullOrEmpty(operationDisplay.Text) && string.IsNullOrEmpty(displayBox.Text))
            {
                operationDisplay.Clear();
                operationDisplay.Text = minusButton.Text;
                StoredOperation = minusButton.Text;
            }
            else if (!string.IsNullOrEmpty(operationDisplay.Text) && !string.IsNullOrEmpty(displayBox.Text))
            {
                operationDisplay.Clear();
                equalsButton_Click(sender, e);
                operationDisplay.Text = minusButton.Text;
                StoredOperation = minusButton.Text;
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operationDisplay.Text) && !string.IsNullOrEmpty(displayBox.Text))
            {
                StoredOperation = multiplyButton.Text;
                StoredOperand = decimal.Parse(displayBox.Text);
                operationDisplay.Text = multiplyButton.Text;
                displayBox.Clear();
            }
            else if (!string.IsNullOrEmpty(operationDisplay.Text) && string.IsNullOrEmpty(displayBox.Text))
            {
                operationDisplay.Clear();
                operationDisplay.Text = multiplyButton.Text;
                StoredOperation = multiplyButton.Text;
            }
            else if (!string.IsNullOrEmpty(operationDisplay.Text) && !string.IsNullOrEmpty(displayBox.Text))
            {
                operationDisplay.Clear();
                equalsButton_Click(sender, e);
                operationDisplay.Text = multiplyButton.Text;
                StoredOperation = multiplyButton.Text;
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operationDisplay.Text) && !string.IsNullOrEmpty(displayBox.Text))
            {
                StoredOperation = divideButton.Text;
                StoredOperand = decimal.Parse(displayBox.Text);
                displayBox.Clear();
                operationDisplay.Text = divideButton.Text;
            }
            else if (!string.IsNullOrEmpty(operationDisplay.Text) && string.IsNullOrEmpty(displayBox.Text))
            {
                operationDisplay.Clear();
                operationDisplay.Text = divideButton.Text;
                StoredOperation = divideButton.Text;
            }
            else if (!string.IsNullOrEmpty(operationDisplay.Text) && !string.IsNullOrEmpty(displayBox.Text))
            {
                operationDisplay.Clear();
                equalsButton_Click(sender, e);
                operationDisplay.Text = divideButton.Text;
                StoredOperation = divideButton.Text;
            }
        }

        private void decimalPoint_Click(object sender, EventArgs e)
        {
            if (!(displayBox.Text.IndexOf(".") > -1)) 
            { 
                displayBox.Text += decimalPoint.Text;
            }
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (StoredOperation != null && StoredOperand != null && displayBox.Text != null)
            {
                switch (StoredOperation)
                {
                    case "+":
                        StoredOperand += decimal.Parse(displayBox.Text);
                        displayBox.Text = StoredOperand.ToString();
                        operationDisplay.Clear();
                        StoredOperation = "";
                        break;
                    case "-":
                        StoredOperand -= decimal.Parse(displayBox.Text);
                        displayBox.Text = StoredOperand.ToString();
                        operationDisplay.Clear();
                        StoredOperation = "";
                        break;
                    case "*":
                        StoredOperand *= decimal.Parse(displayBox.Text);
                        displayBox.Text = StoredOperand.ToString();
                        operationDisplay.Clear();
                        StoredOperation = "";
                        break;
                    case "/":
                        try
                        {
                            StoredOperand /= decimal.Parse(displayBox.Text);
                            displayBox.Text = StoredOperand.ToString();
                            operationDisplay.Clear();
                            StoredOperation = "";
                        }
                        catch (DivideByZeroException)
                        {
                            MessageBox.Show("cannot divide by zero");
                            displayBox.Clear();
                        }
                        break;

                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            StoredOperation = "";
            StoredOperand = 0;
            displayBox.Clear();
            operationDisplay.Clear();
        }

        private void displayBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != '.') && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void binaryButton_Click(object sender, EventArgs e)
        {
            try
            {
                string output = String.Empty;
                int remainder = 0;
                if (!string.IsNullOrEmpty(displayBox.Text))
                {
                    int decimalNumber = int.Parse(displayBox.Text);
                    while(decimalNumber > 0)
                    {
                        remainder = decimalNumber % 2;
                        decimalNumber /= 2;
                        output = remainder.ToString() + output;
                    }
                    displayBox.Text = output;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number");
                displayBox.Clear();
            }
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            try
            {
                string output = String.Empty;
                if (!string.IsNullOrEmpty(displayBox.Text))
                {
                    bool IsBinary = Regex.IsMatch(displayBox.Text, "^[01]");
                    if (IsBinary)
                    {
                        int getDecimal = Convert.ToInt32(displayBox.Text, 2);
                        output = getDecimal.ToString();
                        displayBox.Text = output;

                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                        displayBox.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number");
                displayBox.Clear();
            }
        }

        private void locationalButton_Click(object sender, EventArgs e)
        {
            try
            {
                string output = String.Empty;
                List<int> remainders = new List<int>();
                List<int> powers = new List<int>();
                char[] chars = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
                if (!string.IsNullOrEmpty(displayBox.Text))
                {
                    int decimalNumber = int.Parse(displayBox.Text);
                    while (decimalNumber > 0)
                    {
                        remainders.Add(decimalNumber % 2);
                        decimalNumber /= 2;
                    }
                    for(int i = 0; i < remainders.Count; i++)
                    {
                        if(remainders[i] == 1)
                        {
                            powers.Add(i);
                        }
                    }
                    for(int i =0; i < powers.Count; i++)
                    {
                        int index = powers[i];
                        output = output + chars[index].ToString();
                        displayBox.Text = output;
                    }
                }
                else
                {
                    MessageBox.Show("ERROR");
                    displayBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number");
                displayBox.Clear();
            }
        }
    }
}