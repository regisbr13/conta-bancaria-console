using System;
using System.Globalization;

namespace ContaBacariaConsole
{
    class Program
    {
        //Programa simples de console para cadastro de uma conta bancária.

        static void Main(string[] args)
        {
            //Cadastro:
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Conta conta = new Conta(numero, titular);
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());
            if (conta.HaveraDeposito(resposta))
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular, saldo);
            }

            //Mostrar conta:
            Console.WriteLine();
            Console.WriteLine("Conta criada com sucesso:");
            Console.WriteLine(conta);

            //Depósito:
            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor);
            Console.WriteLine("Conta atualizada:");
            Console.WriteLine(conta);


            //Saque (taxa de R$ 3,00 por saque):
            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);
            Console.WriteLine("Conta atualizada:");
            Console.WriteLine(conta);

            Console.ReadLine();
        }
    }
}
