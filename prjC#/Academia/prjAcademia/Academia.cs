using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAcademia
{
    class Academia
    {
        public BindingList<Aluno> Aluno;

        public Academia(BindingList<Aluno> Alunos)
        {
            this.Alunos = Alunos;

        }
    }
}
