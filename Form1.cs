using System.Reflection.Metadata;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        CalculatorClass cal;
        double num1 = 0;
        double num2 = 0;

        public Form1()
        {
            InitializeComponent();
            cal = new CalculatorClass();

        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
           
           num1 = Convert.ToDouble(fnumbox.Text);
           num2 = Convert.ToDouble(snumbox.Text);
           string operation = operationbox.Text;
           
             if (operation == "+") {

                cal.CalculateBS = cal.getSum;
                answertext.Text = cal.Calculate(num1, num2).ToString();

            }
             else if(operation == "-") {

                cal.CalculateBS = cal.getDifference;
                answertext.Text = cal.Calculate(num1, num2).ToString();

            }
             else if(operation == "*") {

                cal.CalculateBS = cal.getProduct;
                answertext.Text = cal.Calculate(num1, num2).ToString();

            }
             else if(operation == "/") {

                cal.CalculateBS = cal.getQuotient;
                answertext.Text = cal.Calculate(num1, num2).ToString();


              } 
        }
    }
}
