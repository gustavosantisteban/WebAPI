using EjemploBasico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EjemploBasico.Controllers
{
    public class RsvpController : ApiController
    {
        public IEnumerable<PacienteModel> GetAtendidos()
        {
            return Repository.Resultado.Where(x => x.FueAtendido == true);
        }

        public void PostResponse(PacienteModel response)
        {
            if(ModelState.IsValid)
            {
                Repository.Add(response);
            }
        }
    }
}
