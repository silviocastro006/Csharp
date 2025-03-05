using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número: ");
            int num = int.Parse(Console.ReadLine());
            if(num<0){
                Console.Write("Número é negativo");
            } else{
                Console.Write("Número é positivo");
            }
        }
    }
}