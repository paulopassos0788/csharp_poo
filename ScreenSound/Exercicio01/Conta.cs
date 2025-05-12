namespace Exercicio01
{
    internal class Conta
    {
        private int numero;
        private string titular;
        private double saldo;

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Número da conta: {numero}");
            Console.WriteLine($"Titular: {titular}");
            Console.WriteLine($"Saldo: R$ {saldo}");
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

    }
}
