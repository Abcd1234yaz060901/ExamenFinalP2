using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamenFinalP2.Models
{
    public class Visitas
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        [ScaffoldColumn(false)]
        public int IDVisitas { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [DataType(DataType.MultilineText)]
        public string MotivoVisita { get; set; }

        [DataType(DataType.Time)]
        public DateTime HoraEntrada { get; set; }

        [DataType(DataType.Time)]
        public DateTime HoraSalida { get; set; }

        [Display(Name = "Visitante")]
        public int IDVisitante { get; set; }
        public Visitante Visitante { get; set; }

        [Display(Name = "Area")]
        public int IDArea { get; set; }
        public Areas Areas { get; set; }

    }
}