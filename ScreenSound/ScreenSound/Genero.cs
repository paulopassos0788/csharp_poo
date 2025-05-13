namespace ScreenSound
{
    public class Genero
    {
        private string nome;
        private List<Musica> musicas = new List<Musica>();
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }
        public void ExibirDetalhes()
        {
            Console.WriteLine($"\nLista de musicas do Genero: {Nome}");
            Console.WriteLine("\nMúsicas:");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"--> {musica.Nome}");
            }
        }
    }
}
