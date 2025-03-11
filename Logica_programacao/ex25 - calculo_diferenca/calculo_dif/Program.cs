using System;

    class Program
    {
        static void Main(string[] args)
        {
            float n1 = float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());
            float n3 = float.Parse(Console.ReadLine());
            float n4 = float.Parse(Console.ReadLine());

            float diferenca = (n1*n2) - (n3*n4);

            Console.WriteLine($"DIFERNÇA = {diferenca}");
        }
    }