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
            TravarBotao();
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            AtrOperador(btSub.Text);
            TravarBotao();
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            AtrOperador(btMult.Text);
            TravarBotao();
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            AtrOperador(btDiv.Text);
            TravarBotao();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            cominJS.Visible = true;
            Point comin = new Point(-123, -8);
            cominJS.Location = comin;
        }

        void TravarBotao()
        {
            btIgual.Enabled = !(lblOpr.Text == "..." || (lblOpr.Text == btDiv.Text && numOpr2.Value == 0));
        }
        void ChecaMeia(double resu)
        { 
            if(numOpr2.Value == 69 || numOpr1.Value == 69 || resu == 69)
                pictureBox7.Visible = true;
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;
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
                lblResultado.Text = "Erro";
            ChecaMeia(resultado);
                lblResultado.Text = resultado.ToString();
        }

        private void numOpr2_ValueChanged(object sender, EventArgs e)
        {
            TravarBotao();
        }

        private void numOpr1_ValueChanged(object sender, EventArgs e)
        {
            TravarBotao();
        }
    }
}
