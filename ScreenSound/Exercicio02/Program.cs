using Exercicio02;

Produto produto1 = new Produto
{
    Nome = "Produto A",
    Preco = 10.99,
    Quantidade = -1
};

Produto produto2 = new Produto
{
    Nome = "Produto B",
    Preco = 20.50,
    Quantidade = 3
};

Produto produto3 = new Produto
{
    Nome = "Produto C",
    Preco = 15.75,
    Quantidade = 10
};

produto1.ExibirDetalhes();
produto2.ExibirDetalhes();
produto3.ExibirDetalhes();