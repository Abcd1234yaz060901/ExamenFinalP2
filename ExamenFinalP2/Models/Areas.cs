using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ExamenFinalP2.Models
{
    public class Areas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        [ScaffoldColumn(false)]
        public int IDArea { get; set; }

        [Display(Name = "Nombre del Area")]
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public ICollection<Visitas> Visitas { get; set; }
    }
}