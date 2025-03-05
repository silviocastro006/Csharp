using System;
using System.Net.Http.Headers;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número: ");
            int num = int.Parse(Console.ReadLine());
            if(num%2==0){
                Console.WriteLine("Número é par");
            } else {
                Console.WriteLine("Número é impar");
            }
        }
    }
}