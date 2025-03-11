using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============== QUADRANTES DO PLANO CARTESIANO ===============");
            
            Console.Write("valor de X: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("valor de y: ");
            int v2 = int.Parse(Console.ReadLine());

            while(v1 != 0 && v2 !=0){
                
                if(v1 > 0 && v2 > 0){
                    Console.WriteLine("Primeiro Quadrante");
                } else if (v1 < 0 && v2 > 0){
                    Console.WriteLine("Segundo Quadrante");
                        } else if(v1 < 0 && v2 < 0){
                            Console.WriteLine("Terceiro Quadrante");
                            } else if(v1 > 0 && v2 < 0){
                                Console.WriteLine("Quarto Quadrante");
                            }
                
                Console.Write("valor de X: ");
                v1 = int.Parse(Console.ReadLine());
                Console.Write("valor de y: ");
                v2 = int.Parse(Console.ReadLine());
                
            }
        }
    }