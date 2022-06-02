using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculadora MX = new Calculadora();

        private void btn0_Click(object sender, EventArgs e)
        {
            MX.SetVisor(btn0.Text);
            lbVisor.Text = MX.Visor;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MX.SetVisor(btn1.Text);
            lbVisor.Text = MX.Visor;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MX.SetVisor(btn2.Text);
            lbVisor.Text = MX.Visor;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            MX.SetVisor(btn3.Text);
            lbVisor.Text = MX.Visor;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            MX.SetVisor(btn4.Text);
            lbVisor.Text = MX.Visor;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            MX.SetVisor(btn5.Text);
            lbVisor.Text = MX.Visor;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            MX.SetVisor(btn6.Text);
            lbVisor.Text = MX.Visor;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            MX.SetVisor(btn7.Text);
            lbVisor.Text = MX.Visor;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            MX.SetVisor(btn8.Text);
            lbVisor.Text = MX.Visor;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            MX.SetVisor(btn9.Text);
            lbVisor.Text = MX.Visor;
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            MX = new Calculadora();
            lbVisor.Text = MX.Visor;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            MX.Visor = "0";
            lbVisor.Text = MX.Visor;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            MX.Op = "+";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MX.Calcular();
            lbVisor.Text = MX.Visor;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            MX.Op = "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            MX.Op = "*";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            MX.Op = "/";
        }

        private void btnInverterSinal_Click(object sender, EventArgs e)
        {
            MX.InverterSinal();
            lbVisor.Text = MX.Visor;
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            MX.RaizQuadrada();
            lbVisor.Text = MX.Visor;
        }

        private void btnFracao_Click(object sender, EventArgs e)
        {
            MX.Fracao();
            lbVisor.Text = MX.Visor;
        }

        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            MX.Quadrado();
            lbVisor.Text = MX.Visor;
        }

        private void btnPontoDecimal_Click(object sender, EventArgs e)
        {
            MX.PontoDecimal();
            lbVisor.Text = MX.Visor;
        }

        private void btnBK_Click(object sender, EventArgs e)
        {
            MX.Backspace();
            lbVisor.Text = MX.Visor;
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            MX.Porcentagem();
            lbVisor.Text = MX.Visor;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                MX.SetVisor(Convert.ToString(e.KeyChar));
                lbVisor.Text = MX.Visor;
            }
        }

        

    }
}
