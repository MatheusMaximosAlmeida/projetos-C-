﻿using System;
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
    public partial class formFichaAluno : Form
    {
        internal Aluno Registro { get; set; }
        
        public formFichaAluno()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Registro = new Aluno(8, "ALUNO TESTE", 45, 70, 1.56);
            this.Dispose();
        }

     



    }
}
