using System;

/*
    Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
    V = 3.14159 * R * R * A
    Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.
*/

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================ Calculo de Volume ===============");
            Console.Write("Informe o Raio: ");
            float raio = float.Parse(Console.ReadLine());
            Console.Write("Informe a Altura em metros: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Clear();
            double diametro = Diametro(raio);
            double volume = Volume(diametro, altura);
            Console.WriteLine("================ Resultado ===============");
            Console.WriteLine($"Diametro: {diametro}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Volume m³: {volume}");
        }

        static double Diametro(float raio){
            double diametro = Math.Pow(raio,2);
            return diametro;
        }

        static double Volume(double diametro, double altura){
            double volume = 3.14159 * diametro * altura;
            return volume;
        }
    }
}