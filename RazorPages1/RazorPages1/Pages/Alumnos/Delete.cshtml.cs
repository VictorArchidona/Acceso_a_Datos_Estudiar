using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Modelos;
using RazorPages.Service;

namespace RazorPages1.Pages.Alumnos
{
    public class DeleteModel : PageModel
    {
        public IAlumnoRepositorio alumnoRepositorio { get; set; }
        [BindProperty]
        public Alumno Alumno { get; set; }

        public DeleteModel(IAlumnoRepositorio alumnoRepositorio)
        {
            this.alumnoRepositorio = alumnoRepositorio;
        }

        public IActionResult OnGet()
        {
            Alumno = alumnoRepositorio.GetAlumnoPorId(Alumno.Id);
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            Alumno = alumnoRepositorio.Delete(id);
            return RedirectToPage("/Alumno/Index");
        }
    }
}
