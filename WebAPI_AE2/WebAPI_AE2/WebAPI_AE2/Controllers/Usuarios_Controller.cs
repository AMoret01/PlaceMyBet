using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI_AE2.Models;

namespace WebAPI_AE2.Controllers
{
    public class Usuarios_Controller : ApiController
    {
        // GET: api/Usuarios_
        public IEnumerable<Usuario> Get()
        {
            var repositorio = new Repositorio_Usuario();
            List<Usuario> usuarios = repositorio.retrieve();
            return usuarios;
        }

        // GET: api/Usuarios_/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuarios_
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Usuarios_/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuarios_/5
        public void Delete(int id)
        {
        }
    }
}
