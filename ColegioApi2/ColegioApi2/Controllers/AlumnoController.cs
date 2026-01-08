using ColegioApi2.Data;
using ColegioApi2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult<IEnumerable<Alumno>>> Get()
        {
            return await Context.Alumnos.ToListAsync();
        }

        // GET api/<AlumnoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Alumno>> Get(int id)
        {
            return await Context.Alumnos.FindAsync(id);
        }

        [HttpGet("busqueda/{busca}")]
        public async Task<IEnumerable<Alumno>> Get(string busca)
        {
            return await Context.Alumnos.Where(a => a.Nombre.Contains(busca)).ToListAsync();
        }

        // POST api/<AlumnoController>
        [HttpPost]
        public async  Task<ActionResult<Alumno>> Post([FromBody] Alumno alumno)
        {
            if(alumno.ID != 0)
            {
                var alumnoActualizado = Context.Alumnos.Attach(alumno);
                alumnoActualizado.State = EntityState.Modified;
            }
            else
            {
                Context.Alumnos.Add(alumno);
            }
            await Context.SaveChangesAsync();
            return Ok();
        }

        // PUT api/<AlumnoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlumnoController>/5
        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            await Context.Database.ExecuteSqlRawAsync("DELETE FROM Alumnos WHERE Id = {0}", id);
            return Ok(new { mensaje = $"Alumno {id} borrado" });
        }
    }
}
