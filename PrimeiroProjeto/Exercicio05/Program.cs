/*
 * Escrever uma função que a partir de dois números de ponto flutuante a e b 
 * exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings. 
 */

void ExibirOperacoesBasicas(float a, float b, string operacao)
{
    switch (operacao)
    {
        case "+":
            Console.WriteLine($"A soma de {a} e {b} é: {a + b}");
            break;
        case "-":
            Console.WriteLine($"A subtração de {a} e {b} é: {a - b}");
            break;
        case "*":
            Console.WriteLine($"A multiplicação de {a} e {b} é: {a * b}");
            break;
        case "/":
            if (b != 0)
                Console.WriteLine($"A divisão de {a} e {b} é: {a / b}");
            else
                Console.WriteLine("Divisão por zero não é permitida.");
            break;
        default:
            Console.WriteLine("Operação inválida.");
            break;
    }
}

void EntradaDados()
{
    Console.Write("Digite a operacao: ");
    string operacao = Console.ReadLine();

    while (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/")
    {
        Console.Write("Operação inválida. Digite uma operação válida (+, -, *, /): ");
        operacao = Console.ReadLine();
       
    }

    Console.Write("Digite o primeiro número: ");
    float a = float.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    float b = float.Parse(Console.ReadLine());

    ExibirOperacoesBasicas(a, b, operacao);

}

EntradaDados();
