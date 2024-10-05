namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string expression = "";
        bool commaUsed = false;
        bool isResultDisplayed = false;

        private void button1_Click(object sender, EventArgs e)
        {
            HandleNumberInput(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HandleNumberInput(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HandleNumberInput(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandleNumberInput(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HandleNumberInput(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HandleNumberInput(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HandleNumberInput(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HandleNumberInput(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HandleNumberInput(button9.Text);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            HandleNumberInput(button0.Text);
        }

        private void HandleNumberInput(string number)
        {
            if (isResultDisplayed)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                expression = "";
                commaUsed = false;
                isResultDisplayed = false;
            }

            textBox1.Text += number;
            textBox2.Text += number;
            expression += number;
        }

        private void buttonOneClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            expression = "";
            commaUsed = false;
            isResultDisplayed = false;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            HandleOperatorInput("+");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            HandleOperatorInput("-");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            HandleOperatorInput("*");
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            HandleOperatorInput("/");
        }

        private void HandleOperatorInput(string operatorSymbol)
        {
            if (expression.Length > 0 && !IsOperator(expression[^1]))
            {
                textBox1.Text += operatorSymbol;
                textBox2.Text += operatorSymbol;
                expression += operatorSymbol;
                commaUsed = false;
                isResultDisplayed = false;
            }
        }

        private void buttonEqually_Click(object sender, EventArgs e)
        {
            try
            {
                // Выполняем вычисление выражения
                var result = new System.Data.DataTable().Compute(expression.Replace(",", "."), null);
                textBox1.Text += "=" + Convert.ToString(result);
                expression = Convert.ToString(result);
                isResultDisplayed = true;
            }
            catch (Exception ex)
            {
                textBox1.Text = "Ошибка";
                textBox2.Text = "Ошибка";
                isResultDisplayed = true;
            }
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (!commaUsed)
            {
                textBox1.Text += ",";
                textBox2.Text += ",";
                expression += ",";
                commaUsed = true;
                isResultDisplayed = false;
            }
        }

        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }
    }
}
