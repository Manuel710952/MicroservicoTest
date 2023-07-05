using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MicroservicioTest.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicioTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
     
        [HttpGet]
        [Produces("application/json")]
        public IActionResult GetAll()
        {
            
            var datos = new List<string> { "dato1", "dato2", "dato3" };

            return Ok(datos);
        }

        
        [HttpGet("{id}")]
        [Produces("application/json")]
        public IActionResult GetById(int id)
        {
           
            var dato = "dato" + id;

            return Ok(dato);
        }

        
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult Create([FromBody] Materia materia)
        {
           

            return Ok("Dato creado exitosamente");
        }

        // PUT api/ejemplo/5
        [HttpPut("{id}")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult Update(int id, [FromBody] string value)
        {
           

            return Ok("Dato actualizado exitosamente");
        }

        // DELETE api/ejemplo/5
        [HttpDelete("{id}")]
        [Produces("application/json")]
        public IActionResult Delete(int id)
        {
           

            return Ok("Dato eliminado exitosamente");
        }
    }
}