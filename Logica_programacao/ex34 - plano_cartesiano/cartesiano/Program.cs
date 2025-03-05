using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Valor de X: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Valor de Y:");
            int y = int.Parse(Console.ReadLine());

            while(true){
                
                if(x==0 && y==0){
                Console.WriteLine("Origem");
                }

                if(x==0){
                    Console.WriteLine("Eixo X");
                } else if (y==0) {
                    Console.WriteLine("Eixo Y");
                } else if (x>0 && y>0){
                    Console.WriteLine("Quadrante 1");
                } else if (x<0 && y>0){
                    Console.WriteLine("Quadrante 2");
                } else if (x<0 && y<0){
                    Console.WriteLine("Quadrante 3");
                } else if (x>0 && y<0){
                    Console.WriteLine("Quadrante 4");
                }

                Thread.Sleep(100);
                Console.Write("Valor de X: ");
                x = int.Parse(Console.ReadLine());
                if(x==999){
                    break;
                }
                Console.Write("Valor de Y:");
                y = int.Parse(Console.ReadLine());
            }

            

            
        }
    }
}