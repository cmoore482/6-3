using System.Diagnostics;
using System.Net.Security;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleCalculator
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            string Opertor = TxtOperator.Text;
            decimal Answer = 0;
            decimal Op1 = Convert.ToDecimal(TxtOperand1.Text);
            decimal Op2 = Convert.ToDecimal(TxtOperand2.Text);
           
            if (Opertor == "/")
            {
                Answer = Op1 / Op2;
            }

            if (Opertor == "*")
            {
                Answer = Op1 * Op2;
            }

            if (Opertor == "-")
            {
                Answer = Op1 - Op2;
            }

            if (Opertor == "+")
            {
                Answer = Op1 + Op2;
            }

            Answer = Math.Round(Answer, 4);
            TxtResult.Text = Answer.ToString();
            
            TxtOperand1.Clear();
            TxtOperand2.Clear();
            TxtOperator.Clear();
            TxtOperand1.Focus();
        }

        private void TxtOperator_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
