using e_shop.Context;
using e_shop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace e_shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly CRUDContext _CRUDContext;

        public ProdutosController(CRUDContext CRUDContext)
        {
            _CRUDContext = CRUDContext;
        }


        // GET: api/Produtos
        [HttpGet]
        public IEnumerable<Produto> Get()
        {
            return _CRUDContext.Produtos;
        }

        // GET api/Produtos/5
        [HttpGet("{id}")]
        public Produto Get(int id)
        {
            return _CRUDContext.Produtos.SingleOrDefault(x => x.ProdutoId == id);
        }

        // POST api/Produtos
        [HttpPost]
        public void Post([FromBody] Produto produto)
        {
            _CRUDContext.Produtos.Add(produto);
            _CRUDContext.SaveChanges();
        }

        // PUT api/Produtos/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Produto produto)
        {
            produto.ProdutoId = id;
            _CRUDContext.Produtos.Update(produto);
            _CRUDContext.SaveChanges();
        }

        // DELETE api/<ProdutosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CRUDContext.Produtos.FirstOrDefault(x => x.ProdutoId == id);
            if (item != null)
            {
                _CRUDContext.Produtos.Remove(item);
                _CRUDContext.SaveChanges();
            }
        }
    }
}
