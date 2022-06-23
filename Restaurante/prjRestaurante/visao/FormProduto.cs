using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRestaurante.visao
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void FormProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormPrincipal pai = (FormPrincipal)this.MdiParent;
            pai.frProdutos = null;
        }

        private void formProduto_Load(object sender, EventArgs e)
        {
            controle.ProdutoDB tabela = new controle.ProdutoDB();
            tabela.Listar(bs);
            lbIDProduto.DataBindings.Add(new Binding("text", bs, "idproduto"));
            lbNome.DataBindings.Add(new Binding("text", bs, "nome"));
            lbPreco.DataBindings.Add(new Binding("text", bs, "preco"));
            bn.BindingSource = bs;
        }

    }
}
