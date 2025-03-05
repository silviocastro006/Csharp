using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

public class Program{
    // escolha do menu
    static short resp;

    // Banco de produtos
    static Dictionary<string, object> Estoque = new Dictionary<string, object>();

    public static void Main(string[] args)
    {
        
        menu();
        
    }
    
    
    static void menu(){
        
        
        Console.Clear();
        Console.WriteLine("======= MENU PRINCIPAL =======");
        Console.WriteLine($"Se for a primeira vez rodando, cadastre o produto primeiro por favor (não quero mais mexer nesse código)");
        Console.WriteLine("1 Cadastrar produto");
        Console.WriteLine("2 Excluir produto");
        Console.WriteLine("3 Listar produtos");
        Console.WriteLine("4 Sair");
        Console.WriteLine("===============================");
        
        
        try{
            Console.Write("Opção desejada: ");
            resp = short.Parse(Console.ReadLine());
        }catch(Exception ex){
            Console.WriteLine("Favor digitar uma opção válida!");
            Console.ReadKey();
            menu();
        }
        
        
        switch(resp){
            case 1: Cadastrar();break;
            case 2: Excluir();break;
            case 3: Listar();break;
            case 4: System.Environment.Exit(0);break;
            default: menu();break;
        }
   
        
    }

    static void Cadastrar(){

        string nome_prod;
        int cod_prod;
        int quant_prod;
        double val_prod;

        Console.Clear();
        Console.WriteLine("======= CADASTRO DE PRODUTOS =======");
        
        while(true){
            try{
                Console.Write("Nome do produto: ");
                nome_prod = Console.ReadLine();
                
                if(!string.IsNullOrEmpty(nome_prod)){
                    break;
                } else {
                    Console.WriteLine("O nome precisa ser preenchido");
                }
            } catch(Exception ex){
                Console.Write($"Erro: {ex.ToString} ");
            }
        }

        while(true){
            try{
                Console.Write("Código do produto: ");
                cod_prod = int.Parse(Console.ReadLine());
                break;
            } catch(Exception ex){
                Console.Write("Favor inserir um valor válido!");
            }
        }

        while(true){
            try{
                Console.Write("Quantidade do produto: ");
                quant_prod = int.Parse(Console.ReadLine());
                break;
            } catch(Exception ex){
                Console.Write("Favor inserir um valor válido!");
            }
        }

        
        while(true){
            try{
                Console.Write("Valor unitário: R$");
            val_prod = double.Parse(Console.ReadLine());
                break;
            } catch(Exception ex){
                Console.Write("Favor inserir um valor válido!");
            }
        }
        

        // instanciar o produto
        Produto novoProduto = new Produto(cod_prod,quant_prod,val_prod); 

        // Adicionar ao dicionário
        Estoque[nome_prod] = novoProduto;
        Console.Clear();
        Console.WriteLine("Valores Cadastrados:");
        Console.WriteLine($"Código: {((Produto)Estoque[nome_prod]).Codigo}");
        Console.WriteLine($"Nome: {nome_prod}");
        Console.WriteLine($"Quantidade: {((Produto)Estoque[nome_prod]).Quantidade}");
        Console.WriteLine($"Valor unitário: R$ {((Produto)Estoque[nome_prod]).Valor}");
        Thread.Sleep(1000);
        menu();

    }

    static void Excluir(){
        Console.Clear();
        Console.WriteLine("======= EXCLUSÃO DE PRODUTOS =======");
        int cod;
        while(true){
            Console.Write("Digite o código do produto: ");
            try{
                cod = int.Parse(Console.ReadLine());
                
                foreach(var item in Estoque){
                    if(cod.Equals(((Produto)item.Value).Codigo)){
                        Estoque.Remove(item.Key);
                        Console.WriteLine($"{item.Key} excluido com sucesso!");
                        Thread.Sleep(200);
                        menu();

                    } else{
                        Console.WriteLine("Código não localizado!");
                        Thread.Sleep(200);
                        menu();
                    }
                }

            }catch(Exception ex){
                Console.WriteLine("Favor inserir um valor válido!");
                Thread.Sleep(200);
                Excluir();
                break;
            }
        }
    }

    static void Listar(){

        Console.Clear();
        Console.WriteLine("-------------------------------------------------- LISTA DE PRODUTOS -----------------------------------------------------");

        foreach(var item in Estoque){

            string nome = item.Key;

            Produto produto = (Produto) item.Value;

            double valor = Math.Round(produto.Valor,2);

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            Console.Write($"Código: {produto.Codigo,-23} | Nome: {nome,-31} | Quantidade: {produto.Quantidade,-10} | Valor unitário: R${valor,-10}\n");
        }

        Console.WriteLine();
        Console.Write("Digite qualquer tecla para sair.....");
        Console.ReadKey();
        menu();
    }

}

// Classe para armazenar os dados do produto
class Produto
{
    public int Codigo { get; set; }
    public int Quantidade { get; set; }
    public double Valor { get; set; }

    public Produto(int codigo, int quantidade, double valor)
    {
        Codigo = codigo;
        Quantidade = quantidade;
        Valor = valor;
    }
}