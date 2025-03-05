using (HttpClient cliente = new HttpClient())

try
{
    
    {
        string resposta = await cliente.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
        Console.WriteLine(resposta);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Temos um problema {ex}");
    
}