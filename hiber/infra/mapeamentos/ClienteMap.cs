using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using hiber.entidades;

namespace hiber.infra.mapeamentos
{
    public class ClienteMap : ClassMap<Cliente>
    {
        public ClienteMap()
        {
            Schema("nhibernate");
            Table("cliente");
            Id(cliente => cliente.Id).Column("ID");
            Map(cliente => cliente.Nome).Column("NOME");
            Map(cliente => cliente.Email).Column("EMAIL");
            Map(cliente => cliente.Senha).Column("SENHA");
        }
    }
}