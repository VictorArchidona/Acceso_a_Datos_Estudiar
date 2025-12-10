using ColegioApi2.Data;
using ColegioApi2.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ColegioApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        public MyContext Context { get; set; }

        public AlumnoController(MyContext context)
        {
            Context = context;          
        }
  
        // GET: api/<AlumnoController>
        [HttpGet]
        public ActionResult<IEnumerable<Alumno>> Get()
        {
            return Context.Alumnos.ToList();
        }

        // GET api/<AlumnoController>/5
        [HttpGet("{id}")]
        public ActionResult<Alumno> Get(int id)
        {
            return Context.Alumnos.Find(id);
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
