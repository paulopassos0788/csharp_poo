/*
 * Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
 */

using System.Net.Http.Headers;

Dictionary<string, int> prod = AdicionarProduto();

BuscaProduto(prod);

static void BuscaProduto(Dictionary<string, int> prod)
{
    Console.WriteLine("Digite o nome do produto que deseja consultar:");
    string produto = Console.ReadLine();

    if (prod.ContainsKey(produto))
    {
        Console.WriteLine($"A quantidade do produto {produto} em estoque é: {prod[produto]}");
    }
    else
    {
        Console.WriteLine($"O produto {produto} não está cadastrado no estoque.");
    }
}

Dictionary<string, int> AdicionarProduto()
{
    Dictionary<string, int> estoque = new Dictionary<string, int>();

    Console.WriteLine("Digite o nome do produto:");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite a quantidade do produto:");
    int quantidade = int.Parse(Console.ReadLine());

    estoque.Add(nome, quantidade);

    return estoque;

}