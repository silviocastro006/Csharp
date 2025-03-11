using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.Clear();

            for(int i = x; i >= 0; i--){
                if(i%2 != 0){
                    Console.WriteLine($"impar = {i}");
                } else {
                    Console.WriteLine($"par = {i}");
                }
            }
        }
    }
}