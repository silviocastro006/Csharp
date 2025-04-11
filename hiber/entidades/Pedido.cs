using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hiber.entidades
{
    public class Pedido
    {

        public virtual int Id { get; set; }
        public virtual DateTime DataPedido { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual IList<Produto> Produtos {get; set; }


        public Pedido()
        {
        }

        public Pedido(Cliente cliente, IList<Produto> produtos)
        {
            DataPedido = DateTime.Now;
            Cliente = cliente;
            Produtos = produtos;
            
        }
    }
}