using Microsoft.AspNetCore.Mvc;
using ParcialPrograIX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcialPrograIX.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ParcialPrograIX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        // GET: api/<AlumnoController>
        [HttpGet]
        public ActionResult<IEnumerable<Alumno>> Get()
        {
            var alumnoService = new AlumnoSerivce();
            {
                var alumno = alumnoService.GetAlumnos();
                if (alumno != null)
                {
                    return Ok(alumno);
                }
                return NotFound("Mensaje: There are not clients");
            }
        }

        // GET api/<AlumnoController>/5
        [HttpGet("{id}")]
        public ActionResult<Alumno> Get(int id)
        {
            var alumnoService = new AlumnoSerivce();
            {
                var alumno = alumnoService.GetAlumnoById(id);
                if (alumno != null)
                {
                    return Ok(alumno);
                }
                return NotFound("Mensaje: There are not client with id: " + id);
            }
        }

        // POST api/<AlumnoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AlumnoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlumnoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
