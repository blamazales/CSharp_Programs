using System;
using System.Globalization;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            try
            {
                Console.Write("Entre com o número da conta: ");
                int numero = int.Parse(Console.ReadLine());

                Console.Write("Entre com o titular da conta: ");
                string titular = Console.ReadLine();

                Console.Write("Haverá depósito inicial (s/n)? ");
                char resp = char.Parse(Console.ReadLine().Trim().ToUpper());

                if (resp == 'S')
                {
                    Console.Write("Entre com o valor do depósito inicial: ");
                    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    conta = new ContaBancaria(numero, titular, depositoInicial);
                }
                else
                {
                    conta = new ContaBancaria(numero, titular);
                }

                Console.WriteLine("\nDados da conta:");
                Console.WriteLine(conta);

                Console.WriteLine("\nEntre com um valor para depósito: ");
                double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(quantia);
                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(conta);

                Console.WriteLine("\nEntre com um valor para saque: ");
                quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(quantia);
                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine(conta);
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Entrada inválida. Por favor, insira os dados corretamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }
    }
}
