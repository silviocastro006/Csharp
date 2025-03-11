using System.Security.Cryptography;

class Conta{
    
    private int Numero { get; set; }
    private double Saldo { get; set; }
    private string Titular { get; set; }
    private string Extrato { get; set; }

    public Conta(string titular, int numero)
    {
        Numero = numero;
        Titular = titular;
        Extrato = "=============== Extrato ============\n";
    }

    public void Deposito(){
        Console.Clear();
        Console.Write("Valor a ser depositado: ");
        double valor = double.Parse(Console.ReadLine());
        if(valor >0){
            Saldo+=valor;
            Extrato += $"+ R$ {valor}\n";
            Extrato += $"---------------------------------";
        } else{
            Console.WriteLine("Valor inválido para depósito!");
            Thread.Sleep(100);
        }
    }

    public void Saque(){
        Console.Clear();
        Console.Write("Valor a ser depositado: ");
        double valor = double.Parse(Console.ReadLine());
        if(valor>0){
            Saldo-=valor;
            Extrato += $"- R$ {valor}\n";
            Extrato += $"---------------------------------";
        } else{
            Console.WriteLine("Valor inválido para saque!");
            Thread.Sleep(100);
        }
    }

    public void ExibirExtrato(){
        Console.Clear();
        Console.Write(Extrato);
        Console.Write("");
        Console.Write("Digite algo para sair: ");
        Console.ReadKey();
    }
}