using Eventos.AcessoADados.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eventos.AcessoADados.ObjetosDeAcesso
{
    public class EventoDAO
    {


        public void Inserir(Evento evento)
        {
            using (var bancoDeDados = new BancoDeDados())
            {
                bancoDeDados.Eventos.Add(evento);
                bancoDeDados.SaveChanges();
            }

        }

        public Evento ObterPorId(int id)
        {
            using (var bancoDeDados = new BancoDeDados())
            {
                return bancoDeDados.Eventos.Find(id);
            }

        }

        public void Deletar(int id)
        {
            using (var bancoDeDados = new BancoDeDados())
            {
                var evento = ObterPorId(id);
                bancoDeDados.Eventos.Remove(evento);
                bancoDeDados.SaveChanges();
            }
        }

        public void Atualizar(Evento evento)
        {
            using (var bancoDeDados = new BancoDeDados())
            {
                bancoDeDados.Eventos.Update(evento);
                bancoDeDados.SaveChanges();
            }
        }

        public List<Evento> ObterTodos()
        {
            using (var bancoDeDados = new BancoDeDados())
            {
                return bancoDeDados.Eventos.ToList();
            }
        }
    }
}
