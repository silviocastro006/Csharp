using System;
using hiber.entidades;
using hiber.infra;
using NHibernate;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            ISession session = HibernateUtil.getSession();
            ITransaction transaction = session.BeginTransaction();

            Pedido pedido = session.Get<Pedido>(6);

            IQueryable<Pedido> query = session.Query<Pedido>();

            query = query.Where(pedido => pedido.Cliente.Nome == "Silvio");

            IList<Pedido> pedidos = query.ToList();
            
            Console.WriteLine(pedidos[0].Cliente.Nome);
           
            transaction.Commit();

        }
    }
}