using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Modelos;
using RazorPages.Services;

namespace RazorPages25.Pages.Alumnos
{
    public class DetailsModel : PageModel
    {
        private readonly IAlumnoRepositorio alumnoRepositorio;
        public Alumno alumno { get; set; }

        public DetailsModel(IAlumnoRepositorio alumnoRepositorio)
        {
            this.alumnoRepositorio = alumnoRepositorio;
        }

        public void OnGet(int ID)
        {
            alumno = alumnoRepositorio.GetAlumno(ID);
        }
    }
}
