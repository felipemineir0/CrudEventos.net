using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventos.AcessoADados.ModelView
{
    public class EventosModelView
    {

        [Required]
        public string Nome { get; set; }
        [Required]
        public string Data { get; set; }
        [Required]
        public string Local { get; set; }
        [Required]
        public int HoraInicio { get; set; }
        [Required]
        public int HoraFinal { get; set; }
        public bool OpenBar { get; set; }
        public int QuantidadeDeAmbientes { get; set; }
        public string FaixaEtaria { get; set; }

        public List<Participante> Participantes;
        public int MaximoIngressos { get; set; }
        public int IngressosVendidos { get; set; }
    }

    public class Participante
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
