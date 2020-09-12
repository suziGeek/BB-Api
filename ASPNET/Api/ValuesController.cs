using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNET.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNET.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IProductRepository repo;

        public  ValuesController(IProductRepository repo)
        {
            this.repo = repo;
        }


        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return repo.GetAllProducts(); 
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return repo.GetProduct(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Product productToInsert)
        {
            repo.InsertProduct(productToInsert);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(Product product)
        {
            repo.DeleteProduct(product);
        }
    }
}
