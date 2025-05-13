
namespace ScreenSound
{
    public class Musica
    {
        private string nome;
        private string artista;
        private int duracao;
        private bool disponivel;
        public string DescricaoResumida => $"A musica {nome} pertence a banda {artista}";

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Artista: {artista}");
            Console.WriteLine($"Duração: {duracao} segundos");
            Console.WriteLine($"Descricao resumida da banda: {DescricaoResumida}");
            if (disponivel)
            {
                Console.WriteLine("Disponível no plano.");
            }
            else
            {
                Console.WriteLine("Adquira o plano Plus+");
            }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Artista
        {
            get { return artista; }
            set { artista = value; }
        }

        public int Duracao
        {
            get { return duracao; }
            set { duracao = value; }
        }

        public bool Disponivel
        {
            get { return disponivel; }
            set { disponivel = value; }
        }
    }
}
