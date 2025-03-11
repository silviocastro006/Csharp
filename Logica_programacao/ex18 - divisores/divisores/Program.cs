using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================== DIVISORES DE UM NÚMERO =====================");
            Console.Write("Insira um valor: ");
            int val = int.Parse(Console.ReadLine());
            
            // inicio da string
            Console.Write($"Os valores primos de {val} são: ");

            // verificação
            for(int i = 1; i <= val; i++){
                if(val%i == 0){
                    Console.Write(i+" ");
                }
            }
        }
    }