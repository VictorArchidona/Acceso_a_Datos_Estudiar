using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Modelos;
using RazorPages.Service;

namespace RazorPages1.Pages.Alumnos
{
    public class EditModel : PageModel
    {
        private readonly IAlumnoRepositorio AlumnoRepositorio;

        public Alumno alumno { get; set; }

        public EditModel(IAlumnoRepositorio alumnoRepositorio)
        {
            this.AlumnoRepositorio = alumnoRepositorio;
        }
        public void OnGet(int id)
        {
            alumno = AlumnoRepositorio.GetAlumnoPorId(id);
        }

        public IActionResult OnPost(Alumno alumno)
        {
            AlumnoRepositorio.Update(alumno);
            return RedirectToPage("Index");
        }
    }
}
