using System;

/*
    Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa
    pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.
*/

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============= Calculadora de idade ==============");
            Console.Write("Insira quantos anos: ");
            int anos = int.Parse(Console.ReadLine());
            Console.Write("Insira quantos meses: ");
            int meses = int.Parse(Console.ReadLine());
            Console.Write("Insira quantos dias: ");
            int dias = int.Parse(Console.ReadLine());

            // calculo dias
            int tot_dias = (anos*365) + (meses*30) + dias;

            // resultado
            Console.WriteLine($"Quantidade de dias de vida: {tot_dias}");
        }
    }
}