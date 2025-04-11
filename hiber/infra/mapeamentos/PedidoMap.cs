using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using hiber.entidades;
using MySqlX.XDevAPI;

namespace hiber.infra.mapeamentos
{
    public class PedidoMap : ClassMap<Pedido>
    {
        public PedidoMap()
        {
            Schema("nhibernate");
            Table("pedido");
            Id(pedido => pedido.Id).Column("ID");
            Map(pedido => pedido.DataPedido).Column("DATAPEDIDO");
            References(pedido => pedido.Cliente).Column("IDCLIENTE");
            HasManyToMany(pedido => pedido.Produtos)
                .Table("itemproduto")
                .ParentKeyColumn("IDPEDIDO")
                .ChildKeyColumn("IDPRODUTO")
                .Cascade.All();
        }
    }
}