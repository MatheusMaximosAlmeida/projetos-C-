using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjListbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                double peso = Convert.ToDouble(txtPeso.Text);
                lista.Items.Add(peso); // Adiciona valor na lista
                txtPeso.Focus(); // Posiciona o mouse na caixa txtPeso
                txtPeso.Text = "0";
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inseriro peso na lista");
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

            if (lista.Items.Count > 0)
            {
                lista.Items.Remove(lista.SelectedItem);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lista.Items.Count > 0)
            {
                double peso = Convert.ToDouble(txtPeso.Text);
                lista.Items[lista.SelectedIndex] = peso;
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double soma = 0;
            for (int i = 0; i < lista.Items.Count; i++)
            {
                soma += Convert.ToDouble(lista.Items[i]);
            }
            lbResposta.Text = "A soma é = " + soma.ToString();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double soma = 0;
            double media;
            for (int i = 0; i < lista.Items.Count; i++)
            {
                soma += Convert.ToDouble(lista.Items[i]);
            }
            media = soma / lista.Items.Count;
            lbResposta.Text = "A média é = " + media.ToString();
        }

    }
}
