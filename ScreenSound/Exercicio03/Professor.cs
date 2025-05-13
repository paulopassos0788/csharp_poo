namespace Exercicio03
{
    public class Professor
    {
        private string nome;
        private Disciplina disciplina;

        public string Nome { get => nome; set => nome = value; }
        internal Disciplina Disciplina { get => disciplina; set => disciplina = value; }

        public void ExibirDadosProfessor()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Disciplina: {Disciplina.Nome}");
            Console.WriteLine("Alunos:");
            foreach (var aluno in Disciplina.Alunos)
            {
                Console.WriteLine($"- {aluno.Nome}, Idade: {aluno.Idade}, Nota: {aluno.Nota}");
            }
        }
    }
}
