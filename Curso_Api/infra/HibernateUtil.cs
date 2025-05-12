using NHibernate;
using ISession = NHibernate.ISession;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Curso_Api.infra.mapeamentos;

namespace Curso_Api.infra
{
    public class HibernateUtil
    {
        private static readonly ISessionFactory sessionFactory = Fluently.Configure().Database(
                
                MySQLConfiguration.Standard.ConnectionString("Server=localhost;Port=3306;Database=cursoapi;Uid=root;Pwd=")
                .ShowSql()
                .FormatSql())
                .Mappings(m => {m.FluentMappings.AddFromAssemblyOf<FilmeMap>();
                })
                .BuildSessionFactory();

        public static ISession GetSession() => sessionFactory.OpenSession();
    }
}