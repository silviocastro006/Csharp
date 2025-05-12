using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Curso_Api.Models;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;

namespace Curso_Api.infra.mapeamentos
{
    public class FilmeMap : ClassMap<Filme>
    {
        public FilmeMap()
        {
            Schema("cursoapi");
            Table("filme");
            Id(x => x.Id).Column("id");
            Map(x => x.Titulo).Column("titulo");
            Map(x => x.Genero).Column("genero");
            Map(x => x.Duracao).Column("duracao");
        }

    }
}