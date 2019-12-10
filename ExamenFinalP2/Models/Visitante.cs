using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamenFinalP2.Models
{
    public class Visitante
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        [ScaffoldColumn(false)]
        public int IDVisitante { get; set; }

        [Display(Name = "Visitante")]
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Cedula { get; set; }

        [Display(Name = "Fecha de creacion")]
        [DataType(DataType.Date)]
        public DateTime FechaCreacion { get; set; }

        [DataType(DataType.MultilineText)]
        public string Direccion { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }

        
        public ICollection<Visitas> Visitas { get; set; }
        
    }
}