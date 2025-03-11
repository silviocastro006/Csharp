using System;
using System.Formats.Asn1;
using System.Net.NetworkInformation;

class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o raio do círculo: ");
            float raio = float.Parse(Console.ReadLine());

            const double pi = 3.13159;

            double area_circ = pi * Math.Pow(raio,2);

            Console.WriteLine($"A area de um círculo com raio de {raio} é igual a {area_circ}");
        }
    }