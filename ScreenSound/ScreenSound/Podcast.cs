namespace ScreenSound
{
    public class Podcast
    {
        private string _nome;
        private string _host;
        private int _totalEpisodios = TotalEpisodios();
        private static List<Episodio> episodios = new List<Episodio>();

        public Podcast(string nome, string host)
        {
            _nome = nome;
            _host = host;
        }

        public string Nome { get => _nome; }
        public string Host { get => _host; }
        public int TotalEpisodios1 { get => _totalEpisodios; }

        public static int TotalEpisodios()
        {
            return episodios.Count;
        }

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
        }

        public void ExibirPodcast()
        {
            Console.WriteLine($"\nNome: {_nome}");
            Console.WriteLine($"\nHost: {_host}");
            Console.WriteLine($"\nTotal de Episódios: {TotalEpisodios()}");
            Console.WriteLine("\nEpisódios:");
            foreach (var episodio in episodios)
            {
                Console.WriteLine($"\n- {episodio.Titulo} ({episodio.Duracao} min)");
                episodio.ListarConvidados();
            }
        }
    }
}
