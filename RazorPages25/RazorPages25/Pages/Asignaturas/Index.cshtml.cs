using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Modelos;
using RazorPages.Services;
using System.Diagnostics.Eventing.Reader;

namespace RazorPages25.Pages.Asignaturas
{
    public class IndexModel : PageModel
    {   
        public AsignaturaRepositorio AsignaturaRepositorio { get; }
        public ProfesorRepositorio ProfesorRepositorio { get; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Profesor> Profesores { get; set; }
        public int profesor { get; set; }
        public IndexModel(AsignaturaRepositorio asignaturaRepositorio, ProfesorRepositorio profesorRepositorio)
        {
            AsignaturaRepositorio = asignaturaRepositorio;
            ProfesorRepositorio = profesorRepositorio;
        }

        public void OnGet(int? profesor)
        {
            Profesores = ProfesorRepositorio.GetAllProfesores().ToList();
            if (profesor.HasValue) 
                Asignaturas = AsignaturaRepositorio.GetAsignaturasProfesor(profesor.Value).ToList();
            else
                Asignaturas = AsignaturaRepositorio.GetAllAsignaturas().ToList();
        }
    }
}
