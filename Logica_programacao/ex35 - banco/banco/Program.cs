using System;
using System.Globalization;

class Program
    {
        static void Main(string[] args)
        {
            MenuInicial();
        }

        static void MenuInicial(){
            Console.Clear();
            Console.Write(@"
============ MENU PRINCIPAL ===========
01 ) ABERTURA DE CONTA
02 ) FECHAR PROGRAMA
Opção escolhida: ");
            int esc = int.Parse(Console.ReadLine());
            switch(esc){
                case 1:
                    AberturaConta();
                    break;
                case 2:
                    System.Environment.Exit(0);
                    break;
            }
        }

        static void AberturaConta(){
            Console.Clear();
            Console.Write(@"
============= ABERTURA DE CONTA ===========
Informe o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Titular da conta: ");
            string tit = Console.ReadLine();
            Console.Write("Haverá depósito inicial? [S/N]: ");
            string esc = Console.ReadLine().ToUpper();

            if(esc.Equals("S")){
                Console.Write("Entre com o depósito inicial: R$ ");
                double dep = double.Parse(Console.ReadLine());
                Conta conta = new Conta(numero,tit,dep);
                MenuConta(conta);
            } else{
                Conta conta = new Conta(numero, tit);
                MenuConta(conta);
            }

            
        }

        static void MenuConta(Conta conta){
            Console.Clear();
            Console.Write(@"
============ MOVIMENTACOES CONTA ===========
01 ) DEPOSITO
02 ) SAQUE
03 ) EXTRATO
04 ) INFORMAÇÕES DA CONTA
05 ) FECHAR O PROGRAMA
Opção escolhida: ");
            int esc = int.Parse(Console.ReadLine());

            switch(esc){
                case 1:
                    conta.Deposito();
                    MenuConta(conta);
                    break;
                case 2:
                    conta.Saque();
                    MenuConta(conta);
                    break;
                case 3:
                    conta.VerExtrato();
                    MenuConta(conta);
                    break;
                case 4:
                    Console.WriteLine(conta.ToString());
                    Console.Write("Pressione qualquer tecla para sair: ");
                    Console.ReadKey();
                    MenuConta(conta);
                    break;
                case 5: 
                    System.Environment.Exit(0);
                    break;
            }
        }

    }