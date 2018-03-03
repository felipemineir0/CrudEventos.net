using Eventos.AcessoADados.Modelos;
using Eventos.AcessoADados.ModelView;
using Eventos.AcessoADados.ObjetosDeAcesso;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.RegrasDeNegocio
{
    public class EventoBll
    {

        public void Inserir(EventosModelView eventoModelView)
        {
            var evento = new Evento();

            evento = PrepararEvento(eventoModelView, evento);

            var eventoDao = new EventoDAO();
            eventoDao.Inserir(evento);
        }

        public void Atualizar(int id, EventosModelView eventoModelView)
        {
            var eventoDao = new EventoDAO();
            var evento = eventoDao.ObterPorId(id);

            evento = PrepararEvento(eventoModelView, evento);
            eventoDao.Atualizar(evento);
        }

        public Evento ObterPorId(int id)
        {
            var eventoDao = new EventoDAO();
            return eventoDao.ObterPorId(id);
        }

        public void Deletar(int id)
        {
            var eventoDao = new EventoDAO();
            eventoDao.Deletar(id);
        }

        public List<Evento> ObterTodos()
        {
            var eventoDao = new EventoDAO();
            return eventoDao.ObterTodos();
        }


        public Evento PrepararEvento(EventosModelView eventoModelView, Evento evento)
        {
            evento.Nome = eventoModelView.Nome;
            evento.Data = eventoModelView.Data;
            evento.Local = eventoModelView.Local;
            evento.HoraInicio = eventoModelView.HoraInicio;
            evento.HoraFinal = eventoModelView.HoraFinal;
            evento.OpenBar = eventoModelView.OpenBar;
            evento.QuantidadeDeAmbientes = eventoModelView.QuantidadeDeAmbientes;

            if (evento.HoraInicio > 10 && evento.HoraFinal < 20 && evento.QuantidadeDeAmbientes > 2)
            {
                evento.FaixaEtaria = "Festa para menor de 16 anos";
            }
            else if (evento.HoraInicio > 20 && evento.HoraFinal < 2 && evento.OpenBar == false)
            {
                evento.FaixaEtaria = "Festa para maior de 16 anos";
            }
            else
            {
                evento.FaixaEtaria = "Festa 18+";
            }
            
            return evento;
        }
    }
}
