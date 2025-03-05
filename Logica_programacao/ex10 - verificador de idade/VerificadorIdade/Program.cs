using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Verificador de idade ==========");
            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            string nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            int idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            string nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            int idade2 = int.Parse(Console.ReadLine());

            if(idade1 > idade2){
                Console.WriteLine($"{nome1} é mais velho(a) que o(a) {nome2}");
            } else {
                Console.WriteLine($"{nome2} é mais velho(a) que o(a) {nome1}");
            }
            
        }
    }
}