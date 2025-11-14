using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Modelos;
using RazorPages.Service;

namespace RazorPages1.Pages.Alumnos
{
    public class DetailsModel : PageModel
    {
        private readonly IAlumnoRepositorio AlumnoRepositorio;

        [BindProperty]
        public Alumno Alumno { get; set; }

        public DetailsModel(IAlumnoRepositorio alumnoRepositorio)
        {
            this.AlumnoRepositorio = alumnoRepositorio;
        }
        public void OnGet(int id)
        {
            Alumno = AlumnoRepositorio.GetAlumnoPorId(id);
        }
    }
}
