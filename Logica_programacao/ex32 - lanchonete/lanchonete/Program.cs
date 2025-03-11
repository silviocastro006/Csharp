using System;
using System.ComponentModel;
using System.Runtime.Versioning;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,Dictionary<string,float>> lanches = new Dictionary<int, Dictionary<string, float>>();

            for(int i = 1; i <= 5; i++){
                lanches[i] = new Dictionary<string, float>();
            }

            lanches[1]["Cachorro Quente"] = 4.00f;
            lanches[2]["X-salada"] = 4.50f;
            lanches[3]["X-bacon"] = 5.00f;
            lanches[4]["Torrada Simples"] = 2.00f;
            lanches[5]["Refrigerante"] = 1.50f;

            Console.WriteLine("=============== LANCHONETE ===============");
            
            foreach(var lanche in lanches){
                
                int codigo = lanche.Key;
                Dictionary<string, float> itens = lanche.Value;

                Console.Write($"cod {codigo}  ");

                foreach(var item in itens){
                    string nome = item.Key;
                    float valor = item.Value;

                    Console.Write($"{nome,-15} ---------- R$ {valor.ToString("F2")}");
                    Console.WriteLine("");

                }
                
            }

            Console.Write("Escolha o item: ");
            int op = int.Parse(Console.ReadLine());
            Console.Write("Quantidade desejada: ");
            int quant = int.Parse(Console.ReadLine());

            foreach(var lanche in lanches){
                
                int codigo = lanche.Key;

                if( op == codigo){

                    Dictionary<string, float> itens = lanche.Value;

                    foreach(var item in itens){
                        
                        string nome = item.Key;
                        float valor = item.Value;
                        float tot_valor = valor*quant;

                        Console.WriteLine($"Sua conta deu R$ {tot_valor.ToString("F2")}");
                        

                    }
                }
                
                
            }



        }
    }
}