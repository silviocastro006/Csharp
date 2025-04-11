using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using hiber.infra.mapeamentos;
using MySql.Data.MySqlClient;
using NHibernate;

namespace hiber.infra
{
    public class HibernateUtil
    {
        public static ISessionFactory sessionFactory;

        public static ISession getSession()
        {
            sessionFactory = Fluently.Configure().Database(
                
                MySQLConfiguration.Standard.ConnectionString("Server=localhost;Port=3306;Database=nhibernate;Uid=root;Pwd=")
                .ShowSql()
                .FormatSql())
                .Mappings(m => {m.FluentMappings.AddFromAssemblyOf<ClienteMap>();
                })
                .BuildSessionFactory();

                return sessionFactory.OpenSession();
        }
    }
}