using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.Banco
{
    public class ScreenSoundContext : DbContext
     {

        // Define as tabelas (DbSets)
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Musica> Musicas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var stringConexao = "server=localhost;database=screensound;user=root;password=;";
            optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao)).UseLazyLoadingProxies();
        }

        
    }
}