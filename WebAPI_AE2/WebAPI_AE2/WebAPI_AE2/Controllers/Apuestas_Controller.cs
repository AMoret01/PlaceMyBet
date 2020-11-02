using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_AE2.Models;

namespace WebAPI_AE2.Controllers
{
    public class Apuestas_Controller : ApiController
    {
        // GET: api/Apuestas_
        public IEnumerable<Apuesta> Get()
        {
            var repositorio = new Repositorio_Apuestas();
            List<Apuesta> apuestas = repositorio.retrieve();
            return apuestas;
        }

        // GET: api/Apuestas_/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Apuestas_
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Apuestas_/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apuestas_/5
        public void Delete(int id)
        {
        }
    }
}
