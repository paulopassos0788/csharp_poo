namespace ScreenSound
{
    public class Episodio
    {
        private string _titulo;
        private string _resumo;
        private int _ordem;
        private int _duracao;
        private List<Convidado> convidados = new List<Convidado>();

        public Episodio(string titulo, string resumo, int ordem, int duracao)
        {
            _titulo = titulo;
            _resumo = resumo;
            _ordem = ordem;
            _duracao = duracao;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Resumo { get => _resumo; set => _resumo = value; }
        public int Ordem { get => _ordem; set => _ordem = value; }
        public int Duracao { get => _duracao; set => _duracao = value; }

        public void AdicionarConvidado(Convidado convidado)
        {
            convidados.Add(convidado);
        }

        public void ListarConvidados()
        {
            Console.WriteLine($"Convidados do episódio '{_titulo}':");
            foreach (var convidado in convidados)
            {
                Console.WriteLine($"- {convidado.Nome}");
            }
        }
    }
}
