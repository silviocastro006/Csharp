using System;
using System.ComponentModel;

/*
Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz
12 Km por litro.

Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média.

Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.

Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a
fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade média,
tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais.

*/

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== Calculo de gasto de gasolina ============");
            Console.WriteLine("Primeiramente vamos indicar o tempo gasto");
            Console.Write("Horas (0 se for menor que 1 hora): ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Minutos: ");
            int minutos = int.Parse(Console.ReadLine());
            Console.Write("Velocidade em KM/h: ");
            float velocidade = float.Parse(Console.ReadLine());
            Console.Write("Quanto o seu carro rende por litro de gasolina?: ");
            float rendimento = float.Parse(Console.ReadLine());

            // Conversão de tempo
            int tempo = horas+(minutos/60);

            // Chamar a função
            float distancia = CalculoDistancia(tempo, velocidade);
            float gasto = CalculoGastoListro(distancia, rendimento);

            // Resultado
            Console.Clear();
            Console.WriteLine("================= Calculo =============");
            Console.WriteLine($"Tempo percorrido: {horas}:{minutos}h");
            Console.WriteLine($"Velocidade média: {velocidade}Km/h");
            Console.WriteLine($"Distancia percorrida: {distancia} Km");
            Console.WriteLine($"Rendimento do carro: {rendimento}km por litro");
            Console.WriteLine($"Total de gasolina gasta: {gasto} litros");

        }

        static float CalculoDistancia(float tempo, float velocidade){
            
            float distancia = tempo * velocidade;

            return distancia;
        }

        static float CalculoGastoListro(float distancia, float rendimento){

            float litro = distancia / rendimento;

            return litro;
        }
    }
}