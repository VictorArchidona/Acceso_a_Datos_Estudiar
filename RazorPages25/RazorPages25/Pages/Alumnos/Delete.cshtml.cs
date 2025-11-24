using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Modelos;
using RazorPages.Services;

namespace RazorPages25.Pages.Alumnos
{
    public class DeleteModel : PageModel
    {        
        public IAlumnoRepositorio AlumnoRepositorio { get; }
        [BindProperty]
        public Alumno alumno { get; set; }
        public DeleteModel(IAlumnoRepositorio alumnoRepositorio)
        {
            AlumnoRepositorio = alumnoRepositorio;
        }

        public void OnGet(int Id)
        {
            alumno = AlumnoRepositorio.GetAlumno(Id);
        }
        public IActionResult OnPost()
        {
            AlumnoRepositorio.Delete(alumno.Id);
            return RedirectToPage("Index");
        }
    }
}
