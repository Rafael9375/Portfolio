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
    public class ProdutoApiController : ApiController
    {
        private readonly ApplicationProduto appPro;
        public ProdutoApiController()
        {
            appPro = ApplicationConstrutor.AplicacaoProduto();
        }
        // GET: api/ProdutoApi
        public IEnumerable<Produto> Get()
        {
            return appPro.GetAll();
        }

        // GET: api/ProdutoApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProdutoApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProdutoApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProdutoApi/5
        public void Delete(int id)
        {
        }
    }
}
