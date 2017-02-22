using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EjemploBasico.Models
{
    public class PacienteModel
    {
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool? FueAtendido { get; set; }

    }
}