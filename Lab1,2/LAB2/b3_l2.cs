using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class b3_l2 : Form
    {    
        public b3_l2()
        {
            InitializeComponent();
        }

        private void tinh_bt_Click(object sender, EventArgs e)
        {   
            OpenFileDialog inputFileDialog = new OpenFileDialog();
            if (inputFileDialog.ShowDialog() == DialogResult.OK)
            {
                string inputPath = inputFileDialog.FileName;

                OpenFileDialog outputFileDialog = new OpenFileDialog();
                if (outputFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string outputPath = outputFileDialog.FileName;
                    try
                    {
                        string text = "" ;
                        string[] linetext = null ;


                        using (FileStream fs = new FileStream(inputFileDialog.FileName, FileMode.Open))
                        using (StreamReader streamReader = new StreamReader(fs))
                        {
                            text = streamReader.ReadToEnd();
                            linetext = text.Split('\n');
                            input_tb.Text = text;
                        }

                        File.WriteAllText(outputPath, "");

                        using (FileStream fs = new FileStream(outputFileDialog.FileName, FileMode.Open))
                        using (StreamWriter streamWriter = new StreamWriter(fs))
                        {
                            for (int i = 0; i < linetext.Length; i++)
                            {
                                streamWriter.WriteLine(linetext[i] + " = " + CalculateExpression(linetext[i]) );
                            }
                        }

                        using (FileStream fs = new FileStream(outputFileDialog.FileName, FileMode.Open))
                        using (StreamReader streamReader = new StreamReader(fs))
                        {
                            text = streamReader.ReadToEnd();
                            linetext = text.Split('\n');
                            output_lb.Text = text;
                        }
                        MessageBox.Show("Nội dung đã được tính toán và ghi lại vào : " + outputPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra khi chuyển đổi file: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn file đầu ra để lưu nội dung!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn file đầu vào để chuyển đổi!");
            }
        }
        static string CalculateExpression(string expression)
        {
            expression = expression.Replace(" ", "");

            Stack<double> numbers = new Stack<double>();
            Stack<char> operators = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];

                if (char.IsDigit(ch))
                {
                    string numStr = ch.ToString();
                    while (i + 1 < expression.Length && (char.IsDigit(expression[i + 1]) || expression[i + 1] == '.'))
                    {
                        numStr += expression[i + 1];
                        i++;
                    }
                    double number = double.Parse(numStr);
                    numbers.Push(number);
                }
                else if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '^')
                {
                    while (operators.Count > 0 && HasPrecedence(ch, operators.Peek()))
                    {
                        double result = ApplyOperator(numbers.Pop(), numbers.Pop(), operators.Pop());
                        numbers.Push(result);
                    }
                    operators.Push(ch);
                }
                else if (ch == '(')
                {
                    operators.Push(ch);
                }
                else if (ch == ')')
                {
                    while (operators.Peek() != '(')
                    {
                        double result = ApplyOperator(numbers.Pop(), numbers.Pop(), operators.Pop());
                        numbers.Push(result);
                    }
                    operators.Pop(); 
                }
            }
            while (operators.Count > 0)
            {
                double result = ApplyOperator(numbers.Pop(), numbers.Pop(), operators.Pop());
                numbers.Push(result);
            }

            return numbers.Pop().ToString();
        }

        static bool HasPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
                return false;
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
                return false;
            return true;
        }

        static double ApplyOperator(double operand2, double operand1, char op)
        {
            switch (op)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    return operand1 / operand2;
                case '^':
                    return Math.Pow(operand1, operand2);
                default:
                    throw new ArgumentException("Toán tử không hợp lệ: " + op);
            }
        }

        private void input_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

