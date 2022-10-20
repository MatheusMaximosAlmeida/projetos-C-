using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLAPPY_BIRD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int gravidade = 5;
        int speed = 10;
        int placar = 0;


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravidade = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravidade = 5;
            }
        }

        private void Jogo_Tick(object sender, EventArgs e)
        {
            Bird.Top += gravidade;
            tuboInferior.Left -= speed;
            tuboSuperior.Left -= speed;

            if (tuboInferior.Left < 0 - tuboInferior.Width * 2)
            {
                Random p = new Random();
                tuboInferior.Left = this.Width + tuboInferior.Width * p.Next(2, 20);
                placar++;
            }

            if (tuboSuperior.Left < 0 - tuboInferior.Width * 2)
            {
                Random p = new Random();
                tuboSuperior.Left = this.Width + tuboInferior.Width * p.Next(2, 20);
                placar++;
            }

            if (Bird.Bounds.IntersectsWith(tuboInferior.Bounds) || Bird.Bounds.IntersectsWith(tuboSuperior.Bounds) || Bird.Top < 0 || Bird.Bounds.IntersectsWith (Ground.Bounds)) 
            {
                Jogo.Stop();
                lbMensagem.Text = "Você perdeu!";
            }

            lbPlacar.Text = String.Format("PLACAR: {0}", placar.ToString().PadLeft(2, '0')); 
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape)) Environment.Exit(0);
            if (!Char.IsWhiteSpace(e.KeyChar))
            {
                Jogo.Start();
                placar = 0;

                Random p = new Random();
                tuboInferior.Left = this.Width + tuboInferior.Width * p.Next(2, 20);
                tuboSuperior.Left = this.Width + tuboInferior.Width * p.Next(2, 20);

                Bird.Top = this.Height / 2;
                lbMensagem.Text = "Pressione ESC para sair...";
            }
        }
    }
}
