using System;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;

/*
    Faça um programa que:

    - Leia a cotação do dólar
    - Leia um valor em dólares
    - Converta esse valor para Real
    - Mostre o resultado

*/

public class Estoque{



    static void Main(string[] args){

        Console.Write("Cotaçaõ do Dolar: ");
        float cota = float.Parse(Console.ReadLine());

        Console.Write("Valor em Dolar: $ ");
        double valor = float.Parse(Console.ReadLine());

        double total = (valor*cota);
        string conver = total.ToString("C", new CultureInfo("en-US"));

        Console.Write($"Esse valor equivale a R$ {conver}");




    }


}
