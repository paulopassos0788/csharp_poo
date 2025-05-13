using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Aluno
    {
        private string nome;
        private int idade;
        private double nota;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public double Nota { get => nota; set => nota = value; }
    }
}
