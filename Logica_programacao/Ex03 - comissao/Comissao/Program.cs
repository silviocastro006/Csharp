using System;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Threading;


/*
    Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua
    comissão será de 5% do total da venda e que você tem os seguintes dados:

    - Identificação do vendedor
    - Código da peça
    - Preço unitário da peça
    - Quantidade vendida

*/

class Program{

    public static List<Object> vendedores = new List<Object>();
    public static int id_vend = 1;

    static void Main(string[] args)
    {
        Menu();
    }


    public static void Menu(){
        Console.Clear();
        Console.WriteLine("============= MENU PRINCIPAL =============");
        Console.WriteLine("01 ) Criar um vendedor");
        Console.WriteLine("02 ) Lançar uma venda");
        Console.WriteLine("03 ) Fechamento de comissão");
        Console.WriteLine("04 ) Listar Vendas");
        Console.WriteLine("05 ) Fechar o sistema");
        Console.WriteLine("==========================================");
        Console.Write("Opção desejada: ");
        int op = int.Parse(Console.ReadLine());

        switch(op){
            case 1:
                cadastrarVendedor();
                break;
            case 2:
                lancarVenda();
                break;
            case 3:
                fechamentoComissao();
                break;
            case 4:
                listarVendas();
                break;
            case 5:
                Console.Clear();
                Console.Write("Saindo do sistema....");
                Thread.Sleep(100);
                System.Environment.Exit(0);
                break;

        }
    }

    public static void cadastrarVendedor(){
        Console.Clear();
        Console.WriteLine("================== CADASTRAR VENDEDOR =================");
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();
        vendedores.Add(new Vendedor(id_vend, nome));
        id_vend++;
        Console.Write($"Vendedor {nome} Cadastrado com sucesso!");
        Thread.Sleep(100);
        Menu();
    }

    public static void lancarVenda(){
        Console.WriteLine("================== LANÇAMENTO DE VENDA =================");
        listarVendedores();
        Console.Write("-----> insira o id do vendedor: ");
        int op = int.Parse(Console.ReadLine());

        Vendedor vendedor_selecionado = null;
        foreach(Vendedor vendedor in vendedores){
            if(vendedor.id == op){
                vendedor_selecionado = vendedor;
                break;
            }
        }

        if(vendedor_selecionado == null){
            Console.WriteLine($"Id {op} informado não existe!");
            Thread.Sleep(200);
            Menu();
        } else{
            vendedor_selecionado.venda();
            Thread.Sleep(200);
            Menu();
        }
    }

    public static void fechamentoComissao(){
        Console.WriteLine("================== FECHAMENTO DE COMISSÃO =================");
        listarVendedores();
        Console.Write("-----> insira o id do vendedor: ");
        int op = int.Parse(Console.ReadLine());

        Vendedor vendedor_selecionado = null;
        foreach(Vendedor vendedor in vendedores){
            if(vendedor.id == op){
                vendedor_selecionado = vendedor;
                break;
            }
        }

        if(vendedor_selecionado == null){
            Console.WriteLine($"Id {op} informado não existe!");
            Thread.Sleep(200);
            Menu();
        } else{
            Console.Clear();
            vendedor_selecionado.total_comissao();
            Thread.Sleep(200);
            Menu();
        }
    }

    public static void listarVendas(){
        Console.WriteLine("================== LISTAR VENDAS =================");
        listarVendedores();
        Console.Write("-----> insira o id do vendedor: ");
        int op = int.Parse(Console.ReadLine());

        Vendedor vendedor_selecionado = null;
        foreach(Vendedor vendedor in vendedores){
            if(vendedor.id == op){
                vendedor_selecionado = vendedor;
                break;
            }
        }

        if(vendedor_selecionado == null){
            Console.WriteLine($"Id {op} informado não existe!");
            Thread.Sleep(200);
            Menu();
        } else{
            Console.Clear();
            vendedor_selecionado.listar_vendas();
            Thread.Sleep(200);
            Menu();
        }
    }

    public static void listarVendedores(){
        foreach(Vendedor vendedor in vendedores){
            Console.WriteLine($"{vendedor.id} ----------- {vendedor.nome}");
        }
    }
 
}

public class Vendedor{

    public double comissao { get; set; }
    public List<double> vendas { get; set; }
    public string nome { get; set; }
    public int id { get; set; }

    public Vendedor(int id, string nome)
    {
        this.id = id;
        this.nome = nome;
        this.vendas = new List<double>();


    }

    public void venda(){
        Console.WriteLine("=================== LANÇAMENTO DE VENDA ==================");
        Console.Write("Valor da venda: R$ ");
        double valor = double.Parse(Console.ReadLine());
        vendas.Add(valor);
        Console.Write("Venda registrado com sucesso!");
        Thread.Sleep(100);
        Console.Clear();
        
    }

    public void listar_vendas(){
        Console.Clear();
        Console.WriteLine("=================== LISTA DE VENDA ==================");
        int c = 0;
        foreach(double valor in vendas){
            Console.WriteLine($"Venda nº {c+1}: R$ {valor}");
            c++;

        }
        Console.Write("Aperte qualquer tecla para sair: ");
        Console.ReadKey();
    }


    public void total_comissao(){
        Console.Clear();
        Console.WriteLine("=================== FECHAMENTO DE COMISSÃO ==================");
        this.comissao = (vendas.Sum())*5/100;
        Console.WriteLine($"O total de comissão do Vendedor {this.nome} é de R$: {this.comissao}");
        Console.Write("Aperte qualquer tecla para sair: ");
        Console.ReadKey();
    }
    
}