using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira um valor: ");
            float valor = float.Parse(Console.ReadLine());

            while(valor != 9999) {

                 if(valor >=0 && valor <= 25){
                Console.WriteLine("Valor no intervalo de [0,25]");
                } else if (valor > 25 && valor <= 50){
                    Console.WriteLine("Valor no intervalo de [25,50]");
                } else if (valor > 50 && valor <=75){
                    Console.WriteLine("Valor no intervalo de [50,75]");
                } else if (valor > 75 && valor <= 100){
                    Console.WriteLine("Valor no intervalo de [75,100]");
                } else {
                    Console.Write("Valor fora dos intervalos");
                }
                Console.WriteLine("");

                Console.Write("Insira um valor: ");
                valor = float.Parse(Console.ReadLine());
            }
            

           
        }
    }
}