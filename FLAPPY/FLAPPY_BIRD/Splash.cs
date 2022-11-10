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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Barra.Increment(1);

            lbPorcento.Text = Barra.Value.ToString().PadLeft(3, '0') +
                " %";
            lbUsuario.Text = "USUÁRIO: " +
                Environment.UserName + "(" +
                Environment.MachineName + ")";

            if (Barra.Value == 100)
            {
                this.Cursor = Cursors.Default;
                timer1.Stop();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
        }
    }
}
