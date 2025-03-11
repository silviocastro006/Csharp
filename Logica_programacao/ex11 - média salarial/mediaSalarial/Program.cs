using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Média Salarial ==========");
            Console.Write("Salário do primeiro funcionário: ");
            float sal1 = float.Parse(Console.ReadLine());
            Console.Write("Salário do segundo funcionário: ");
            float sal2 = float.Parse(Console.ReadLine());
            float media = (sal1+sal2)/2;
            Console.WriteLine($"Média: {media}");
            
        }
    }
}