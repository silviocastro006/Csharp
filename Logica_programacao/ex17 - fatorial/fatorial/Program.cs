using System;
using System.Runtime.ConstrainedExecution;

/*
    Fazer o calculo fatorial de um número com recursividade
*/

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================== Calculo de Fatorial =====================");
            Console.Write("Insira um valor: ");
            int valor = int.Parse(Console.ReadLine());
            Fatorial(valor);

        }

        static void Fatorial(int n){

            int final = 1;

            Console.Write($"{n}! = ");

            for(int i = n; i >= 1;i--){
                
                Console.Write(i+" ");

                if(i == 1){
                    Console.Write("= ");
                } else{
                    Console.Write("X ");
                }
                
                final *= i;
                
            }

            Console.Write(final);
        }
    }