using System;
using System.Security.Cryptography;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hora inicial: ");
            int hi = int.Parse(Console.ReadLine());
            Console.Write("Hora final: ");
            int hf = int.Parse(Console.ReadLine());

            int duracao;

            if(hi < hf){
                duracao = hf - hi;
            } else{
                duracao = 24 - hi +hf;
            }

            Console.WriteLine($"Duração: {duracao}");

        }
    }
}