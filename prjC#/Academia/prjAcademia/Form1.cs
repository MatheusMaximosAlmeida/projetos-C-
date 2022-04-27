using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAcademia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BindingList<Aluno> Lista;
        private void Form1_Load(object sender, EventArgs e)
        {
            Lista = new BindingList<Aluno>();
            Lista.Add(new Aluno(1, "JOÃO", 20, 67, 1.73));
            Lista.Add(new Aluno(2, "MARIA", 22, 97, 1.80));
            Lista.Add(new Aluno(3, "JOSE", 28, 78, 1.56));
            Lista.Add(new Aluno(4, "ANA", 25, 80, 1.82));
            bs.DataSource = Lista;
            dgvAluno.DataSource = bs;


        }

        

    }
}
