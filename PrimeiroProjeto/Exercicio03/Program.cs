/*
 * Criar um programa que, dado a entrada de dados de um número n inteiro, 
 * a partir do teclado, exibir a n-ésima posição de uma lista.
 * 
 */

List<int> numeros = new List<int>();

int numero;

while (true)
{
    Console.WriteLine("Digite um número inteiro (ou -1 para sair): ");
    numero = int.Parse(Console.ReadLine());
    if (numero == -1)
    {
        break;
    }
    numeros.Add(numero);

}

foreach(int n in numeros)
{
    Console.WriteLine("Numeros: " +n);
}

