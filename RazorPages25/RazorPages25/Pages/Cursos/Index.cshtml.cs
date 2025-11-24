using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Modelos;

namespace RazorPages25.Pages.Cursos
{
    public class IndexModel : PageModel
    {
        public List<Curso> Cursos { get; set; }

        public void OnGet()
        {
            // Obtener todos los valores del enum y convertirlos a lista de cadenas
            Cursos = Enum.GetValues(typeof(Curso)).Cast<Curso>().ToList();
        }
    }
}
