using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Primeiro número: ");
            float n1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            float n2 = float.Parse(Console.ReadLine());

            if(n1%n2==0){
                Console.WriteLine($"{n1} é multiplo de {n2}");
            } else {
                Console.WriteLine($"{n1} não é múltiplo de {n2}");
            }

            if(n2%n1==0){
                Console.WriteLine($"{n2} é multiplo de {n1}");
            } else {
                Console.WriteLine($"{n2} não é múltiplo de {n1}");
            }
        }
    }
}