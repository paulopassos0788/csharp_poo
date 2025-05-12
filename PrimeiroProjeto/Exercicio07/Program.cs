/*
 * Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela
 */

Dictionary<string, double> CadastrarNotas()
{
    Dictionary<string, double> notas = new Dictionary<string, double>();
    Console.WriteLine("Digite o nome do aluno:");
    string nome = Console.ReadLine();
    Console.WriteLine("Quantas notas deseja cadastrar?");
    int quantidadeNotas = int.Parse(Console.ReadLine());
    for (int i = 0; i < quantidadeNotas; i++)
    {
        Console.WriteLine($"Digite a nota {i + 1}:");
        double nota = double.Parse(Console.ReadLine());
        notas.Add($"Nota {i + 1}", nota);
    }
    return notas;
}

CalcularMediaNotas();

void CalcularMediaNotas()
{
    Dictionary<string, double> notas = CadastrarNotas();

    var media = notas.Average(n => n.Value);
    Console.WriteLine($"A média das notas do aluno é: {media}");
}