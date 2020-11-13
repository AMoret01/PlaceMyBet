using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI;
using WebAPI_AE3.Models;


namespace WebAPI_AE3.Controllers
{
    public class ApuestasExamenController : ApiController
    {
        /*** Ejercicio 2 ***/

        public IEnumerable<ApuestaUsuario> GetApuestaExamen(double val1, double val2)
        {
            var repo = new ApuestasRepository();
            List<ApuestaUsuario> apuestas = repo.apuestaUsuario(val1, val2);
            return apuestas;
        }

        /*** Fin Ejercicio 2 ***/
    }
}
