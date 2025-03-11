using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Valor salário por hora: ");
            float sal_tempo = float.Parse(Console.ReadLine());

            float salario = horas * sal_tempo;

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Salario: R$ {salario}");


        }
    }
}