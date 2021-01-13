using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlazorAdmin2.Data;
using MySql.Data.MySqlClient;
using Dapper.Contrib.Extensions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazorAdmin2.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        // GET: api/<PresentesController>
        /// <summary>
        /// Recebe os presentes
        /// </summary>
        /// <returns>Presentes</returns>
        [HttpGet]
        public IEnumerable<Clientes> Get()
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = painatal; Uid = root; Pwd =; ");
            var res = DBConn.GetAll<Clientes>();



            return res;
        }

        // GET api/<PresentesController>/
        /// <summary>
        /// Recebe apenas o presente daquele id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>O Presente</returns>
        [HttpGet("{id}")]
        public Clientes Get(int id)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = painatal; Uid = root; Pwd =; ");
            var res = DBConn.Get<Clientes>(id);
            


            return res;
        }


        // POST api/<PresentesController>
        /// <summary>
        /// Cria um presente na base de dados
        /// </summary>
        /// <param name="presente"></param>
        /// <returns>O presente</returns>
        [HttpPost]
        public Clientes Post([FromBody] Clientes cliente)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = goldyan; Uid = root; Pwd =; ");

            var idNewRec = DBConn.Insert<Clientes>(cliente);

            var res = DBConn.Get<Clientes>(idNewRec);

            return res;
        }
        /// <summary>
        /// Dá update ao id do presente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="presente"></param>
        /// <returns>O presente atualizado</returns>
        // PUT api/<PresentesController>/5
        [HttpPut("{id}")]
        public ActionResult<Clientes> Put(int id, [FromBody] Clientes cliente)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = painatal; Uid = root; Pwd =; ");

            var recLido = DBConn.Get<Clientes>(id);

            if (recLido != null)
            {
                //recLido.Nomes = presente.Nomes;
                //recLido.Quantidade = presente.Quantidade;

                bool updated = DBConn.Update(recLido);

                return Ok(recLido);
            }
            else
            {
                return NotFound();
            }





        }
        /// <summary>
        /// Dá delete ao presente escolhido
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<PresentesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            MySqlConnection DBConn = new MySqlConnection("Server = localhost; Database = painatal; Uid = root; Pwd =; ");
            var res = DBConn.Get<Clientes>(id);
            if (res != null)
            {
                DBConn.Delete(res);
            }
            else
            {

            }

        }
    }
}
