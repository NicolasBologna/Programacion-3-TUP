using Ejercicio1.Presentacion;
using Ejercicio1.Presentacion.Modelos;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Ejercicio1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cervezas : ControllerBase
    {
        // GET: api/<Cervezas>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(CervezasData.DbContext.Cervezas);
        }

        // GET api/<Cervezas>/5
        [HttpGet("{id}", Name = "GetCerveza")]
        public IActionResult Get(int id)
        {
            var cerveza = CervezasData.DbContext.Cervezas.FirstOrDefault(c => c.Id == id);

            if (cerveza is null)
                return NotFound();

            return Ok(cerveza);
        }

        // POST api/<Cervezas>
        [HttpPost]
        public IActionResult Post([FromBody] CervezaParaCrearDto nuevaCerveza)
        {
            if (nuevaCerveza is null)
                return BadRequest();

            var cerveza = CervezasData.Add(nuevaCerveza);

            return CreatedAtRoute("GetCerveza", new { id = cerveza.Id }, cerveza);
        }

        // PUT api/<Cervezas>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Cervezas>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
