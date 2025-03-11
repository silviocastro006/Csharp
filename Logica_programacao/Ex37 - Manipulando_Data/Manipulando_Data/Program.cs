// testes de data

using System;
using System.Globalization;


DateTime atual = DateTime.Now;
DateTime hoje = new DateTime(2025,3,10);
DateOnly data_atual = new DateOnly();

string nome_mes = atual.ToString("MMMM",new CultureInfo("pt-BR")).ToUpper();
Console.WriteLine(nome_mes);