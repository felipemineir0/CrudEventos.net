using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Eventos.AcessoADados.ModelView;
using Eventos.RegrasDeNegocio;

namespace Eventos.App.Controllers
{
    //[Produces("application/json")]
    [Route("api/Evento")]
    public class EventoController : Controller
    {

        [HttpPost]
        public IActionResult Post([FromBody] EventosModelView eventoModelView)
        {
            try
            {
                var eventoBll = new EventoBll();
                eventoBll.Inserir(eventoModelView);
                return NoContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500, ex.InnerException.Message);
            }
        }

        //api/Evento/5
        [HttpGet("{id}")]
        public IActionResult Put(int id, [FromBody] EventosModelView eventosModelView)
        {
            try
            {
                var eventoBll = new EventoBll();
                eventoBll.Atualizar(id, eventosModelView);
                return NoContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        //api/Evento/5
        [HttpGet("{id}")]
        public IActionResult GetComId(int id)
        {
            try
            {
                var eventoBll = new EventoBll();
                var evento = eventoBll.ObterPorId(id);
                return Json(evento);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

        //api/Evento/5
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var eventoBll = new EventoBll();
                var listaDeEventos = eventoBll.ObterTodos();
                return Json(listaDeEventos);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(500);
            }
        }

    }
}