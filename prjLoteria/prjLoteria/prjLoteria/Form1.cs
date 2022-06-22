using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLoteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (rbMegaSena.Checked)
            {
                Cartela c = new Cartela(60);
                c.Imprimir(pnCartela, 6, 10);
                c.Sortear(60, 6);
            }
            if (rbLotoFacil.Checked)
            {
                Cartela c = new Cartela(25);
                c.Imprimir(pnCartela, 5, 5);
                c.Sortear(25, 15);
            }

            if (rbLotoMania.Checked)
            {
                Cartela c = new Cartela(100);
                c.Imprimir(pnCartela, 10, 10);
                c.Sortear(100, 50);
            }
            if (rbQuina.Checked)
            {
                Cartela c = new Cartela(80);
                c.Imprimir(pnCartela, 8, 10);
                c.Sortear(80, 5);
            }
        }
    }
}
