using Jorge_Estrada.Data;
using Jorge_Estrada.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Jorge_Estrada.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiecomerceController : ControllerBase
    {
        private readonly MyDbContext _context;

        public ApiecomerceController(MyDbContext context)
        {
          _context = context;
        }
        // GET: api/<ApiecomerceController>
        [HttpGet]
        public IEnumerable<Models.Categoria> Get()
        {
            IEnumerable<Models.Categoria> catego = _context.Categorias.ToList();
            return catego;
            //return new string[] { "value1", "value2" };
        }

        // GET api/<ApiecomerceController>/5
        [HttpGet("{id}")]
        public Categoria Get(int id)
        {
            

            Categoria modelo = _context.Categorias.Where(c => c.CategoriaId == id).FirstOrDefault();
            if (modelo == null)
            return new Categoria();

            return modelo;
        }

        // POST api/<ApiecomerceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ApiecomerceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ApiecomerceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
