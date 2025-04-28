Console.WriteLine("=== JOGO DE ADIVINHAÇÃO ===");
Console.WriteLine("Tente adivinhar o número entre 1 e 100");
Console.WriteLine("Digite 0 para desistir do jogo");

Random random = new Random();
int numeroSecreto = random.Next(1, 101);
int tentativa = 0;
int numeroTentativas = 0;
bool acertou = false;
bool desistiu = false;

do
{
    numeroTentativas++;
    Console.Write("\nDigite sua tentativa (0 para sair): ");

    bool entradaValida = int.TryParse(Console.ReadLine(), out tentativa);

    if (!entradaValida)
    {
        Console.WriteLine("Por favor, digite um número válido!");
        continue;
    }

    // Verifica se o usuário quer sair
    if (tentativa == 0)
    {
        desistiu = true;
        continue;
    }

    if (tentativa == numeroSecreto)
    {
        acertou = true;
    }
    else if (tentativa < numeroSecreto)
    {
        Console.WriteLine("O número secreto é MAIOR.");
    }
    else
    {
        Console.WriteLine("O número secreto é MENOR.");
    }

    switch (Math.Abs(tentativa - numeroSecreto))
    {
        case 0:
            Console.WriteLine("Parabéns! Você acertou!");
            break;
        case <= 5:
            Console.WriteLine("Está muito quente!");
            break;
        case <= 15:
            Console.WriteLine("Está quente.");
            break;
        case <= 30:
            Console.WriteLine("Está morno.");
            break;
        default:
            Console.WriteLine("Está frio.");
            break;
    }

} while (!acertou && !desistiu);

if (acertou)
{
    Console.WriteLine($"\n=== FIM DE JOGO ===");
    Console.WriteLine($"Você acertou o número {numeroSecreto} em {numeroTentativas} tentativas!");
}
else
{
    Console.WriteLine($"\n=== JOGO ENCERRADO ===");
    Console.WriteLine($"Você desistiu. O número secreto era {numeroSecreto}.");
}

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();
