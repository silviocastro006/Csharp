using SerenattoEnsaio.Dados;
using SerenattoEnsaio.Modelos;
using SerenattoPreGravacao.Dados;

IEnumerable<Cliente> clientes = DadosClientes.GetClientes().ToList();
IEnumerable<string> formasPagamento = DadosFormaDePagamento.FormasDePagamento;
IEnumerable<Produto> cardapioLoja = DadosCardapio.GetProdutos().ToList();
IEnumerable<int> pedidos = DadosPedidos.QuantidadeItensPedidosPorDia.SelectMany(lista => lista).ToList();
IEnumerable<Produto> cardapioDelivery = DadosCardapio.CardapioDelivery().ToList();

#region
// Console.WriteLine("RELATÓRIO DE DADOS CLIENTES");

// foreach(var cliente in clientes)
// {
//     Console.WriteLine($"{cliente.Id} | {cliente.Nome} | {cliente.Endereco} | {cliente.Telefone}");
// }

// Console.WriteLine("-------------------------------------");

// Console.WriteLine("RELATÓRIO DE FORMAS DE PAGAMENTO");

// var pesquisa = from p in formasPagamento
//                where p.Contains('o')
//                select p;

// System.Console.WriteLine(string.Join(" - ", pesquisa));

// Console.WriteLine("-------------------------------------");

// Console.WriteLine("RELATÓRIO DE FORMAS DE PAGAMENTO");

// var pesquisa2 = formasPagamento.Where(p => p.Contains('o'));

// Console.WriteLine(string.Join("-",pesquisa2));

// Console.WriteLine("-------------------------------------");

// Console.WriteLine("DADOS CARDAPIO DA LOJA");

// foreach(var item in cardapioLoja)
// {
//     Console.WriteLine($"{item.Id} - {item.Nome} - {item.Preco}");
// }

// Console.WriteLine("-------------------------------------");

// Console.WriteLine("DADOS CARDAPIO DA LOJA ORDENADOS POR NOME");

// var pesquisa3 = from item in cardapioLoja
//                 orderby item.Nome
//                 select item.Nome+" - "+item.Preco;

// foreach (var item in pesquisa3)
// {
//     Console.WriteLine($"{item}");
// }

// Console.WriteLine(" -------------------------- ");

// var pesquisa4 = cardapioLoja.OrderBy(item => item.Nome).Select(item => $"{item.Nome} {item.Preco:C}").ToList();

// foreach (var item in pesquisa4)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine("DADOS CARDAPIO DA LOJA ORDENADOS POR NOME");

// var produtosPreco = cardapioLoja.Select(c => new
// {
//     NomeProduto = c.Nome,
//     PrecoProduto = c.Preco
// });

// foreach (var item in produtosPreco)
// {
//     Console.WriteLine($"{item.NomeProduto} | {item.PrecoProduto}");
// }

// Console.WriteLine("RELATÓRIOS DE PRODUTO POR");

// var produtosPreco = cardapioLoja.Select(c => new
// {
//     NomeProduto = c.Nome,
//     PrecoProduto = c.Preco
// });

// foreach (var item in produtosPreco)
// {
//     Console.WriteLine($"{item.NomeProduto} | {item.PrecoProduto:c}");
// }

// Console.WriteLine(" ================ RELATÓRIOS DE PRODUTO POR COMBO ================ ");

// var produtosPrecoCombo = cardapioLoja.Select(c => new
// {
//     NomeProduto = c.Nome,
//     PrecoProduto = c.Preco*3
// });

// foreach (var item in produtosPrecoCombo)
// {
//     Console.WriteLine($"{item.NomeProduto} | {item.PrecoProduto:c}");
// }

// Console.WriteLine(" ================ RELATÓRIOS QUANTIDADE PRODUTOS PEDIDOS NO MÊS ================ ");

// Console.Write("PEDIDOS DO MES POR DIA: ");

// foreach (var pedido in pedidos)
// {
//     Console.Write($"{pedido} ");
// }

// Console.WriteLine(" ");
// Console.Write("TOTAL DE PEDIDOS INDIVIDUAIS: ");
// //var pedidoIndividual = DadosPedidos.QuantidadeItensPedidosPorDia.SelectMany(l => l).Count(x => x==1);
// var pedidoIndividual2 = pedidos.Count(x => x==1);
// Console.Write(pedidoIndividual2);
// Console.WriteLine(" ");

// Console.Write("TOTAL DE PEDIDOS COM QUANTIDADE DIFERENTE DE ITENS: ");

// IEnumerable<int> totalPedidosDiferentesMes = pedidos.Distinct();

// foreach (var pedido in totalPedidosDiferentesMes)
// {   
//     Console.Write($" {pedido}");
// }
#endregion

Console.WriteLine("-----------------------------------");
Console.WriteLine("RELATÓRIO PRODUTOS CARDAPIO DELIVERY");

IEnumerable<string> produtoCardapioLoja = cardapioLoja.Select(x => x.Nome);
IEnumerable<string> produtoCardapioDelivery = cardapioDelivery.Select(x=> x.Nome);

var produtosLoja = produtoCardapioLoja.Except(produtoCardapioDelivery).ToList();

var produtoDelivery = produtoCardapioDelivery.Except(produtoCardapioLoja).ToList();

foreach (var produto in produtoDelivery)
{
    Console.WriteLine($"{produto}");   
}