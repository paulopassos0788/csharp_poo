namespace ScreenSound
{
    public class Album
    {
        public string Name { get; set; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);
        private List<Musica> musicas = new List<Musica>();

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"\nLista de musicas do Album: {Name}");
            Console.WriteLine($"\nDuração total: {DuracaoTotal} segundos");
            Console.WriteLine("\nMúsicas:");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"--> {musica.Nome}");
            }
        }
    }
}
