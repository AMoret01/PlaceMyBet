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
    
    public class ApuestaController : ApiController
    {
        public IEnumerable<ApuestaDTO> Get()
        {
            var repo = new ApuestasRepository();
            List<ApuestaDTO> apuestas = repo.retrieveDTO();
            return apuestas;


        }

        public IEnumerable<ApuestaUsuario> GetApuestaExamen(double val1, double val2)
        {
            var repo = new ApuestasRepository();
            List<ApuestaUsuario> apuestas = repo.apuestaUsuario(val1, val2);
            return apuestas;
        }



        // GET: api/Apuesta/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Apuesta
        public void Post([FromBody] Apuesta apuesta)
        {
            var repo = new ApuestasRepository();
            repo.Save(apuesta);
        }

        // PUT: api/Apuesta/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Apuesta/5
        public void Delete(int id)
        {
        }
    }
}
