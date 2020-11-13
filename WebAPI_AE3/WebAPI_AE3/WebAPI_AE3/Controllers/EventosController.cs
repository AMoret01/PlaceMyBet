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
    
    public class EventoController : ApiController
    {
        // GET: api/Evento
        
        public IEnumerable<Evento> Get()
        {
            EventosRepository repository = new EventosRepository();
            List<Evento> eventos = repository.retrieve();
            return eventos;
        }
        
        public IEnumerable<EventoDTO> GetDTO()
        {
            var repository = new EventosRepository();
            List<EventoDTO> eventos = repository.retrieveDTO();
            return eventos;
        }

        /*** Ejercicio 1 ***/
        // GET: api/Eventos/idevento
        public IEnumerable<EventoMercado> Get(int id)
        {
            var repo = new EventosRepository();
            List<EventoMercado> eventos = repo.eventoMercado(id);
            return eventos;
        }
        /*** Fin Ejercicio 1 ***/

        // POST: api/Evento
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Evento/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Evento/5
        public void Delete(int id)
        {
        }
    }
}
