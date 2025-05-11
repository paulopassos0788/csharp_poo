/*
 * Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.
 */

void CalcularSomaLista(List<int> lista)
{
    int soma = 0;
    foreach (int numero in lista)
    {
        soma += numero;
    }
    Console.WriteLine($"A soma dos elementos da lista é: {soma}");
}

void EntradaDados()
{
    List<int> lista = new List<int>();
    Console.Write("Digite os números da lista separados por espaço: ");
    string[] numeros = Console.ReadLine().Split(' ');
    foreach (string numero in numeros)
    {
        if (int.TryParse(numero, out int num))
        {
            lista.Add(num);
        }
        else
        {
            Console.WriteLine($"'{numero}' não é um número válido e será ignorado.");
        }
    }
    CalcularSomaLista(lista);
}

EntradaDados();