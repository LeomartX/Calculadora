namespace Calculadora
{
    public partial class Calculadora : Form
    {
        // Variables para el cálculo
        private double num1 = 0;
        private double num2 = 0;
        private double num3 = 0;
        private string operation = string.Empty;
        private bool isNewOperation = true;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button00_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "00";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            displayTextBox.Text += "9";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (!isNewOperation)
            {
                num2 = double.Parse(displayTextBox.Text);
                PerformOperation();
            }

            num1 = double.Parse(displayTextBox.Text);
            operation = "+";
            displayTextBox.Clear();
            isNewOperation = false;
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (!isNewOperation)
            {
                num2 = double.Parse(displayTextBox.Text);
                PerformOperation();
            }

            num1 = double.Parse(displayTextBox.Text);
            operation = "-";
            displayTextBox.Clear();
            isNewOperation = false;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (!isNewOperation)
            {
                num2 = double.Parse(displayTextBox.Text);
                PerformOperation();
            }

            num1 = double.Parse(displayTextBox.Text);
            operation = "*";
            displayTextBox.Clear();
            isNewOperation = false;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (!isNewOperation)
            {
                num2 = double.Parse(displayTextBox.Text);
                PerformOperation();
            }

            num1 = double.Parse(displayTextBox.Text);
            operation = "/";
            displayTextBox.Clear();
            isNewOperation = false;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (!isNewOperation)
            {
                num2 = double.Parse(displayTextBox.Text);
                PerformOperation();
                isNewOperation = true;
            }
        }

        // Método para realizar la operación
        private void PerformOperation()
        {
            switch (operation)
            {
                case "+":
                    num1 = num1 + num2;
                    break;
                case "-":
                    num1 = num1 - num2;
                    break;
                case "*":
                    num1 = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        num1 = num1 / num2;
                    }
                    else
                    {
                        displayTextBox.Text = "Error";
                        return;
                    }
                    break;
            }

            displayTextBox.Text = num1.ToString(); 
            operation = string.Empty; 
            num2 = 0; 
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operation = string.Empty;
            isNewOperation = true; 

            displayTextBox.Clear();
        }
    }
}
