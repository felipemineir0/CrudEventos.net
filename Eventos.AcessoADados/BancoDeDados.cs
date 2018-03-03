using Microsoft.EntityFrameworkCore;
using Eventos.AcessoADados.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.AcessoADados
{
    public class BancoDeDados : DbContext
    {

        public DbSet<Evento> Eventos { get; set; }

        //public BancoDeDados(DbContextOptions<BancoDeDados> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql("server = localhost; " +
                "userid=root;" + "password=root;database=eventos;");
        }
    }

}
