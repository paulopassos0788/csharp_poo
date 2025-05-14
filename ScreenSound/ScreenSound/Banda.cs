namespace ScreenSound
{
    public class Banda
    {
        private string nome;
        private List<Album> albuns = new List<Album>();

        public Banda(string nome)
        {
            this.nome = nome;
        }

        public string Nome { get => nome; }

        public void AdicionarAlbum(Album album)
        {
            albuns.Add(album);
        }

        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da banda {nome}:");
            foreach (var album in albuns)
            {
                Console.WriteLine($"- {album.Nome} (Duração total: {album.DuracaoTotal} segundos)");
            }
        }
        
    }
}
