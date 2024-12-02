using System;

/*
    Usuário possui uma conta com saldo,
    Pode sacar e depositar o valor.
*/

namespace Caixa
{
    class Program
    {
        static decimal saldoDisponivel = 0;

        static void Main(string[] args)
        {
            MenuOperacoes();
        }

        public static void MenuOperacoes()
        {
            Console.Clear();
            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine($"1 - Ver saldo\n2- Fazer depósito\n3 - Realizar saque\n0 - Para sair");
            int opcaoMenu = int.Parse(Console.ReadLine());

            switch (opcaoMenu)
            {
                case 0: Environment.Exit(0); break;
                case 1: VerSaldoEmConta(); break;
                case 2: RealizarDeposito(); break;
                case 3: RealizarSaque(); break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente!");
                    MenuOperacoes();
                    break;
            }
        }

        public static void VerSaldoEmConta()
        {
            Console.WriteLine($"Você tem disponivel para saque: {saldoDisponivel.ToString("C")}");
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            MenuOperacoes();
        }

        public static void RealizarDeposito()
        {
            Console.WriteLine("Qual o valor deseja depositar: R$");
            decimal valorDeposito = decimal.Parse(Console.ReadLine());

            if (valorDeposito > 0)
            {
                saldoDisponivel += valorDeposito;
                Console.WriteLine($"VALOR DEPOSITADO: {valorDeposito:C}");
                Console.WriteLine($"\nSaldo total: {saldoDisponivel:C}");
            }
            else
            {
                Console.WriteLine("Por favor, digite um valor válido para depositar...");
            }

            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            MenuOperacoes();
        }

        public static void RealizarSaque()
        {
            Console.Write("Insira um valor para sacar: R$");
            decimal valorDeSaque = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"\nSAQUE SOLICITADO: {valorDeSaque:C}");

            if (valorDeSaque > saldoDisponivel)
            {
                Console.WriteLine($"Por favor, insira um valor válido, seu saldo é {saldoDisponivel:C}");
                Console.ReadKey();
                MenuOperacoes();
            }

            saldoDisponivel -= valorDeSaque;
            Console.WriteLine("Saque realizado com sucesso.");
            Console.WriteLine($"SEU SALDO ATUAL: {saldoDisponivel:C}");
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            MenuOperacoes();

        }
    }
}