using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Eventos.AcessoADados.Modelos
{
    public class Evento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEvento { get; set; }
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

        [ForeignKey]
        public List<Participante> participantes;
        public int MaximoIngressos { get; set; }
        public int IngressosVendidos { get; set; }
    }
    public class Participante
    {
        public int IdEvento { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
