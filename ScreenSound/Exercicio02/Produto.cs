namespace Exercicio02
{
    public class Produto
    {
        public string Nome { get; set; }

        private double _preco;
        public double Preco
        {
            get => _preco;
            set
            {
                if (value < 0)
                    throw new ArgumentException("O preço não pode ser negativo.");
                _preco = value;
            }
        }

        private int _quantidade;
        public int Quantidade
        {
            get => _quantidade;
            set
            {
                if (value < 0)
                    throw new ArgumentException("A quantidade não pode ser negativa.");
                _quantidade = value;
            }
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco:C}");
            Console.WriteLine($"Quantidade: {Quantidade}");
        }
    }

}
