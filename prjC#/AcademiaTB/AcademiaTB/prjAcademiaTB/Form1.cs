using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAcademiaTB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BindingList<Aluno> Lista;

        Academia BoaForma;

        private void Form1_Load(object sender, EventArgs e)
        {
            ServidorSQL servidor = new ServidorSQL();
            if (servidor.CriarBanco() == true)
            {
                MessageBox.Show("Banco de dados criado com sucesso!");
            }
            BoaForma = new Academia(new BindingList<Aluno>());
            BoaForma.Preencher();
            bs.DataSource = BoaForma.Alunos;
            dgvAlunos.DataSource = bs;
            dgvAlunos.AutoResizeColumns();
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            formFichaAluno ficha = new formFichaAluno();
            ficha.Registro = null;
            ficha.ShowDialog();
            if (ficha.Registro != null)
            {
                BoaForma.Matricular(ficha.Registro);
                bs.MoveLast();
                bs.ResetBindings(false);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formFichaAluno ficha = new formFichaAluno();
            ficha.Registro = (Aluno)bs.Current;
            ficha.ShowDialog();
            if (ficha.Registro != null)
            {
                BoaForma.Editar(ficha.Registro);
                bs.ResetBindings(false);
                dgvAlunos.AutoResizeColumns();
            }
        }
    }
}
