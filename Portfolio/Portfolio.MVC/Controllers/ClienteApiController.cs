using Portfolio.Domain.Entities;
using Protfolio.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Portfolio.MVC.Controllers
{
    public class ClienteApiController : ApiController
    {
        private readonly ApplicationCliente appCli;
        public ClienteApiController()
        {
            appCli = ApplicationConstrutor.AplicacaoCliente();
        }
        // GET: api/ClienteApi
        public IEnumerable<Cliente> Get()
        {
            return appCli.GetAll();
        }

        // GET: api/ClienteApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ClienteApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ClienteApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ClienteApi/5
        public void Delete(int id)
        {
        }
    }
}
