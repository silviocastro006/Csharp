using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            // INPUTS
            Console.Write("Primeira medida: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Segunda medida: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Terceira medida: ");
            float c = float.Parse(Console.ReadLine());

            // CALCULOS
            const double pi = 3.14159;
            float area_tri = (a*c);
            double area_cir = (pi*Math.Pow(c,2));
            double area_trap = (a+b)*c;
            double area_quad = Math.Pow(b,2);
            double area_reta = (a*b);

            // Resultados
            Console.WriteLine("=========== RESULTADO =========");
            Console.WriteLine($"Area triângulo retângulo: {area_tri}");
            Console.WriteLine($"Area círculo: {area_cir}");
            Console.WriteLine($"Area trapézio: {area_trap}");
            Console.WriteLine($"Area quadrado: {area_quad}");
            Console.WriteLine($"Area retângulo: {area_reta}");

        }
    }
}