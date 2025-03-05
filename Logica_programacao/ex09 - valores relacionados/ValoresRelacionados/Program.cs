using System;

/*
    Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes
    entre eles. Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual.
*/

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ Relacionamento entre números ===========");
            Console.Write("Insira o primeiro valor: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo valor: ");
            int v2 = int.Parse(Console.ReadLine());

            
            if(v1 == v2){
                Console.WriteLine($"{v1} é igual {v2}");
            }

            if(v1 != v2){

                Console.WriteLine($"{v1} é NÃO igual {v2}");

                if(v1 > v2){
                    Console.WriteLine($"{v1} é maior {v2}");
                } else {
                    Console.WriteLine($"{v2} é maior {v1}");
                }

                if(v1 < v2){
                    Console.WriteLine($"{v1} é menor {v2}");
                } else {
                    Console.WriteLine($"{v2} é menor {v1}");
                }

                if(v1 >= v2){
                    Console.WriteLine($"{v1} é maior ou igual a {v2}");
                } else { 
                    Console.WriteLine($"{v2} é maior ou igual {v1}");
                }

                if(v1 <= v2){
                    Console.WriteLine($"{v1} é menor ou igual a {v2}");
                } else {
                    Console.WriteLine($"{v2} é menor ou igual a {v1}");
                }


            }
                
            
        }
    }
}