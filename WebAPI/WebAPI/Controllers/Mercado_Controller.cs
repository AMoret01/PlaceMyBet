using WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    [Route("api/Mercado/{action}")]
    public class MercadoController : ApiController
    {
        // GET: api/Mercado
        [HttpGet]
        [ActionName("Get")]
        public IEnumerable<Mercado> Get()
        {
            Repositorio_Mercado repository = new Repositorio_Mercado();
            List<Mercado> mercados = repository.retrieve();
            return mercados;
        }

        [HttpGet]
        [ActionName("GetDTO")]
        public IEnumerable<MercadoDTO> GetDTO()
        {
            var repository = new Repositorio_Mercado();
            List<MercadoDTO> mercados = repository.retrieveDTO();
            return mercados;
        }

        // GET: api/Mercado/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Mercado
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Mercado/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Mercado/5
        public void Delete(int id)
        {
        }
    }
}
