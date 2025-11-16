using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Modelos;
using RazorPages.Service;

namespace RazorPages1.Pages.Alumnos
{
    public class DeleteModel : PageModel
    {
        public IAlumnoRepositorio AlumnoRepositorio { get; set; }

        [BindProperty]
        public Alumno Alumno { get; set; }

        public DeleteModel(IAlumnoRepositorio alumnoRepositorio)
        {
            AlumnoRepositorio = alumnoRepositorio;
        }

        public IActionResult OnGet(int id)
        {
            Alumno = AlumnoRepositorio.GetAlumnoPorId(id);
            return Page();
        }

        public IActionResult OnPost()
        {
            // Lógica para eliminar el alumno
            AlumnoRepositorio.Delete(Alumno.Id);
            return RedirectToPage("Index");
        }
    }
}
