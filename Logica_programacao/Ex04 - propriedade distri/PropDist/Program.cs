using System;
using System.Globalization;

/*
Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os
valores lidos, baseando-se na utilização do conceito de propriedade distributiva.

Dica: se forem lidas as variáveis A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B
com D e por último C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo,
devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as
multiplicações.
*/

class Program{

    static void Main(string[] args)
    {
        int prim = int.Parse(Console.ReadLine());
        int secu = int.Parse(Console.ReadLine());
        int ter = int.Parse(Console.ReadLine());
        int qua = int.Parse(Console.ReadLine());
        Console.Clear();



        int[] lista = {prim, secu, ter, qua};
        int combinacoes = 0;

        /*
            - se for igual a qualquer um dos índices anteriores ele dá continue
            incrementa e passa para o próximo
        */

        for(int i = 0; i < lista.Length; i++){

            for(int j = 0; j < lista.Length; j++){

                if(j==i) continue;

                for(int k = 0; k < lista.Length; k++){

                    if(k==j || k==i) continue;

                    int resA = lista[i] * lista[j];
                    int resB = lista[i] * lista[k];
                    int tot = resA+resB;
                    
                    Console.WriteLine($"{lista[i]} x ({lista[j]} + {lista[k]}) = {resA} + {resB} = {tot}");
                    combinacoes++;
                }
            }

        }

        Console.WriteLine("Combinações: "+combinacoes);


    }
}