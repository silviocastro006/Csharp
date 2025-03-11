using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================ LINHAS DOIDAS =================");
            Console.Write("Insira um valor: ");
            int val = int.Parse(Console.ReadLine());


            for(int i = 1; i <= val; i++){

                double v1 = i;
                double v2 = Math.Pow(i,2);
                double v3 = Math.Pow(i,3);

                Console.WriteLine($"{v1} {v2} {v3}");
            }
        }
    }