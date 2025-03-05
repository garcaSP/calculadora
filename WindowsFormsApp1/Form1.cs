using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public double resultado = 0;
        public Form1()
        {
            InitializeComponent();
            btIgual.Enabled = true;
        }

        void AtrOperador(string operador)
        {
            lblOpr.Text = operador;
        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            AtrOperador(btSoma.Text);
            TravarDiv();
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            AtrOperador(btSub.Text);
            TravarDiv();
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            AtrOperador(btMult.Text);
            TravarDiv();
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            AtrOperador(btDiv.Text);
            TravarDiv();
        }

        void TravarDiv()
        {
            btIgual.Enabled = !(lblOpr.Text == "..." || (lblOpr.Text == btDiv.Text && numOpr2.Value == 0));
        }

        private bool TravarSegue()
        {
            bool lt = !(lblResultado.Text == "...");
            btSegue.Enabled = lt;
            return lt;
        }
        private void btIgual_Click(object sender, EventArgs e)
        {
            double num1, num2 = 0;
            num1 = (double)numOpr1.Value;
            num2 = (double)numOpr2.Value;

            if (lblOpr.Text == btSoma.Text)
                resultado = num1 + num2;
            else if (lblOpr.Text == btSub.Text)
                resultado = num1 - num2;
            else if (lblOpr.Text == btMult.Text)
                resultado = num1 * num2;
            else if (lblOpr.Text == btDiv.Text)
                resultado = num1 / num2;
            else
            {
                return;
            }

            lblResultado.Text = resultado.ToString("");
            TravarSegue();
        }

        private void numOpr2_ValueChanged(object sender, EventArgs e)
        {
            TravarDiv();
            TravarSegue();
        }

        private void numOpr1_ValueChanged(object sender, EventArgs e)
        {
            TravarDiv();
            TravarSegue();
        }

        private void btSegue_Click(object sender, EventArgs e)
        {
            if(TravarSegue() == false)
                return;
                numOpr1.Value = (decimal)resultado;
        }

        private void btLimpa_Click(object sender, EventArgs e)
        {
            numOpr1.Value = 0;
            numOpr2.Value = 0;
            lblOpr.Text = "...";
            lblResultado.Text = "...";
            TravarSegue();
        }
    }
}
