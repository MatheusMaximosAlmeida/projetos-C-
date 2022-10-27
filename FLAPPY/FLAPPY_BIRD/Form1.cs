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
        int Recorde = 0;


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

            if (Bird.Bounds.IntersectsWith(tuboInferior.Bounds) ||
                 Bird.Bounds.IntersectsWith(tuboSuperior.Bounds) ||
                 Bird.Top < 0 ||
                 Bird.Bounds.IntersectsWith(Ground.Bounds))
            {
                Jogo.Stop();
                lbMensagem.Text = "Voce perdeu!";
                if (placar > Recorde)
                {
                    Recorde = placar;
                    lbRecord.Text = String.Format("Recorde: {0}", Recorde);
                    Registro.Gravar("FLAPPY", "recorde", Recorde.ToString());
                }
            }

            lbPlacar.Text = String.Format("PLACAR: {0}", placar.ToString().PadLeft(2, '0'));

            acelerar();

        }

        private void acelerar()
        {
            if (placar > 15) speed = 10;
            if (placar > 25) speed = 15;
            if (placar > 35) speed = 18;
            if (placar > 40) speed = 22;
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
        private void Form1_Load(object sender, EventArgs e)
        {
            Recorde = Int32.Parse(
                Registro.Ler("FLAPPY", "Recorde"));
            lbRecord.Text = String.Format("REC: {0}", Recorde);
            if (DateTime.Now.Hour > 18)
            {
                this.BackColor = Color.Black;
                lbRecord.BackColor = Color.Black;
            }
            else
            {
                this.BackColor = Color.SkyBlue;
                lbRecord.BackColor = Color.SkyBlue;
            }
        }
    }
}
