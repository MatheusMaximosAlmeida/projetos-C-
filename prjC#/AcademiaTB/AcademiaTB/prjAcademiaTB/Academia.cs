using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAcademiaTB
{
    class Academia
    {
        public BindingList<Aluno> Alunos;

        public Academia(BindingList<Aluno> Alunos)
        {
            this.Alunos = Alunos;
        }

        public void Preencher()
        {
            try
            {
                AlunoDB tabela = new AlunoDB();
                tabela.Select(Alunos);
            }
            catch (Exception Erro)
            {
                System.Windows.Forms.MessageBox.Show("Erro: " + Erro.Message);
            }
        }

        public void Matricular(Aluno novo)
        {
            try
            {
                if (novo != null)
                {
                    AlunoDB tabela = new AlunoDB();
                    tabela.Inserir(novo);
                    Alunos.Add(novo);
                }
            }
            catch (Exception Erro)
            {
                System.Windows.Forms.MessageBox.Show(
                    "ERRO: " + Erro.Message);
            }

        }

        internal void Editar(Aluno aluno)
        {
            Aluno p = Alunos.FirstOrDefault(i => i.id == aluno.id);
            if (p != null)
            {
                p.Nome = aluno.Nome;
                p.Idade = aluno.Idade;
                p.Peso = aluno.Peso;
                p.Peso = aluno.Altura;
            }
        }
    }
}