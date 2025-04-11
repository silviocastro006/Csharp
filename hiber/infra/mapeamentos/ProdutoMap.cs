using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using hiber.entidades;
using NHibernate.Criterion;

namespace hiber.infra.mapeamentos
{
    public class ProdutoMap : ClassMap<Produto>
    {
        public ProdutoMap()
        {
            Schema("nhibernate");
            Table("produto");
            Id(produto => produto.Id).Column("ID");
            Map(produto => produto.Nome).Column("NOME");
            Map(produto => produto.Preco).Column("PRECO");
            
        }
    }
}