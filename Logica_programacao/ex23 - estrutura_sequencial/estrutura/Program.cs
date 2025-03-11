using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ SOMA DE VAORES ============");
            Console.Write("Primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"SOMA = {n1+n2}");
        }
    }