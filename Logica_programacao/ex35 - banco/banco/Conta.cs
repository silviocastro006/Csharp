using System;
using System.Diagnostics;
using System.Windows.Markup;

/*
    Funções da conta bancária
     - Abertura de conta no início do projeto (deverá ser um construtor com numero, titular e deposito inicial)
     - Deposito (se for 0 reais retorna erro, senão deposita (não pode ser negativo))
     - Saque (apenas se o saldo for maior que o valor solicitado, não pode ser 0 nem negativo)
     - Extrato ( toda movimentação será salva numa variável tipo string e concatenado para quando printar
       podermos ver todas as movimentações e o valor total em conta)
*/

class Conta{

    private int _numero;
    private string _titular;
    private string _extrato;

    public string Titular { 
        get {return _titular;}
        private set{
            if(value != null && value.Length>0){
                _titular = value;
            }
        ;} 
    }
    
    public int Numero { 
        get{return _numero;}
        private set{
            if(value>0){
                _numero = value;
            } else{
                Console.WriteLine("Valor inválido! Favor inserir um valor maior que 0.");
            }
        ;}
    }
    public double Saldo { 
        get;
        private set; 
    }
    public string Extrato { 
        get{return _extrato;} 
        set{
            if(int.Parse(value)>0){
                if(int.Parse(value)>0){
                    _extrato += $"+ R$ {value}\n";
                } else {
                    _extrato += $"- R$ {value}\n";
                }
            }
            } 
        }

    public Conta(int numero, string titular){
        Numero = numero;
        Titular = titular;
    }

    public Conta(int numero, string titular, double dep): this(numero, titular){
        Saldo += dep;
        Extrato += dep;
    }

    public void Deposito(){
        Console.Clear();
        Console.Write("Informe o valor a ser depositado: R$ ");
        double valor = double.Parse(Console.ReadLine());
        this.Saldo += valor;
        Console.Write("Valor depositado com sucesso!");
        this.Extrato = valor.ToString();
    }

    public void Saque(){
        Console.Clear();
        Console.Write("Informe o valor a ser sacado: R$ ");
        double valor = double.Parse(Console.ReadLine());
        this.Saldo -= valor;
        Console.Write("Valor sacado com sucesso!");
        this.Extrato = valor.ToString();
    }

    public void VerExtrato(){
        Console.Clear();
        Console.WriteLine("==================== EXTRATO ==================");
        Console.Write(Extrato);
        Console.Write("Pressione qualquer tecla para sair: ");
        Console.ReadKey();
    }

    public override string ToString()
    {
        Console.Clear();

        return $@"
        =============== INFORMAÇÕES DA CONTA ===========
        Numero da conta: {this._numero}
        Titular: {this._titular}
        Saldo: {this.Saldo}";

    }







}