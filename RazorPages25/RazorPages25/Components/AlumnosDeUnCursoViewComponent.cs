using Microsoft.AspNetCore.Mvc;
using RazorPages.Modelos;
using RazorPages.Services;

namespace RazorPages25.Components
{
    public class AlumnosDeUnCursoViewComponent:ViewComponent
    {
        public IAlumnoRepositorio AlumnoRepositorio { get; }
        public AlumnosDeUnCursoViewComponent(IAlumnoRepositorio alumnoRepositorio)
        {
            AlumnoRepositorio = alumnoRepositorio;
        }
        public IViewComponentResult Invoke(Curso curso)
        {
            var resultado = AlumnoRepositorio.GetAlumnosCurso(curso);
            return View(resultado);
        }
    }
}
