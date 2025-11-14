using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Modelos;
using RazorPages.Service;

namespace RazorPages1.Pages.Alumnos
{
    public class IndexModel : PageModel
    {
        private readonly IAlumnoRepositorio alumnosRepositorio;
        [BindProperty]
        public IEnumerable<Alumno> Alumnos { get; set; }

        public IndexModel(IAlumnoRepositorio alumnoRepositorio)
        {
            this.alumnosRepositorio = alumnoRepositorio;
        }

        public void OnGet()
        {
            Alumnos = alumnosRepositorio.GetAllAlumnos();
        }
    }
}
