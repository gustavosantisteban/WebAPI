using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploBasico.Models
{
    public class Repository
    {
        private static Dictionary<string, PacienteModel> resultado;

        static Repository()
        {
            resultado = new Dictionary<string, PacienteModel>();
            resultado.Add("Will", new PacienteModel { Nombre = "Will", Email = "rootsantisteban@gmail.com", FueAtendido = true });
            resultado.Add("Maxi", new PacienteModel { Nombre = "Maxi", Email = "maxirodriguez@gmail.com", FueAtendido = true });
            resultado.Add("Juan", new PacienteModel { Nombre = "Juan", Email = "juanperez@gmail.com", FueAtendido = false });
        }

        public static void Add(PacienteModel newResponse)
        {
            string key = newResponse.Nombre.ToLowerInvariant();
            if(resultado.ContainsKey(key))
            {
                resultado[key] = newResponse;
            } else
            {
                resultado.Add(key, newResponse);
            }
        }

        public static IEnumerable<PacienteModel> Resultado
        {
            get { return resultado.Values; }
        }
    }
}