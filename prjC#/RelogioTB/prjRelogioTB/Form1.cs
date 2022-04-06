using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRelogioTB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string caminho = Environment.CurrentDirectory + "\\fundo.png";
        Image fundo;
        Graphics g;


        private void Form1_Load(object sender, EventArgs e)
        {
            fundo = Image.FromFile(caminho);
            pbRelogio.Image = fundo;
            g = pbRelogio.CreateGraphics();
            pbRelogio.Height = fundo.Height;


        }
    }
}
