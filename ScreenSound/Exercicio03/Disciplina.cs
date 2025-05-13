using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Disciplina
    {
        private string nome;
        private List<Aluno> alunos = new List<Aluno>();

        public string Nome { get => nome; set => nome = value; }
        internal List<Aluno> Alunos { get => alunos; set => alunos = value; }
    }
}
