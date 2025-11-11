using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Modelos;
using RazorPages.Service;

namespace RazorPages1.Pages.Alumnos
{
    public class EditModel : PageModel
    {
        private readonly IAlumnoRepositorio AlumnoRepositorio;

        public Alumno Alumno { get; set; }

        public EditModel(IAlumnoRepositorio alumnoRepositorio)
        {
            this.AlumnoRepositorio = alumnoRepositorio;
        }
        public void Post(int id)
        {
            Alumno = AlumnoRepositorio.GetAlumnoPorId(id);
        }
    }
}
