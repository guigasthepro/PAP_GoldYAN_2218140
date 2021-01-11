using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorAdmin2.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncomendasController : ControllerBase
    {
        // GET: api/<Encomendas>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Encomendas>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Encomendas>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Encomendas>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Encomendas>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
