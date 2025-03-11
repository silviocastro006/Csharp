using System;

/*
    Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. A fórmula de conversão de
    temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus
    Fahrenheit e a variável C representa é a temperatura em graus Celsius.

    Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius. A fórmula de conversão de
    temperatura a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F é a temperatura em graus Fahrenheit e a
    variável C é a temperatura em graus Celsius.
*/

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================= Conversor de Temperatura ================");
            Console.WriteLine("1 ) Converter para Celcius");
            Console.WriteLine("2 ) Converter para Farenheit");
            Console.Write("Opção escolhida: ");
            int op = int.Parse(Console.ReadLine());

            switch(op){
                case 1:
                    ConverterCelsius();
                    break;
                case 2:
                    ConverterFarenheit();
                    break;
                default:
                    System.Environment.Exit(0);
                    break;
            }
        }

        static void ConverterFarenheit(){

            Console.Clear();
            Console.Write("Insira a temperatura em Celsius: ");
            float celsius = float.Parse(Console.ReadLine());
            float valorF = (9 * celsius + 160) / 5;
            Console.WriteLine($"{celsius} ºC = {valorF} ºF");

                    
        }

        static void ConverterCelsius(){

            Console.Clear();
            Console.Write("Insira a temperatura em Farenheit: ");
            float farenheit = float.Parse(Console.ReadLine());
            float valorC = (farenheit - 32) * 5 / 9;
            Console.WriteLine($"{farenheit} ºF = {valorC} ºC");
        }
    }
}