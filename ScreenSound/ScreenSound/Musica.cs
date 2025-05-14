
namespace ScreenSound
{
    public class Musica
    {
        private string nome;
        private Banda artista;
        private int duracao;
        private bool disponivel;
        public string DescricaoResumida => $"A musica {nome} pertence a banda {artista}";

        public Musica(Banda artista, string nome)
        {
            this.artista = artista;
            this.nome = nome;
        }

        public string Nome { get => nome;}
        public Banda Artista { get => artista; }
        public int Duracao { get => duracao; set => duracao = value; }
        public bool Disponivel { get => disponivel; set => disponivel = value; }

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

    }
}
