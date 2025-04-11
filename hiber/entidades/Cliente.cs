using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hiber.entidades
{
    public class Cliente
    {

        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Email { get; set; }
        public virtual string Senha { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
    }
}